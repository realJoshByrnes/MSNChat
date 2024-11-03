using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using Windows.Win32;
using Windows.Win32.Foundation;
using Windows.Win32.UI.WindowsAndMessaging;

namespace MSNChat
{
  /*
   * CustomTreeView is a custom TreeView control that draws the selected node with the system highlight color and text color
   * when the TreeView does not have focus. This is necessary because the default TreeView control does not draw the selected
   * node well when the TreeView does not have focus, which can make it difficult for users to see which node is selected.
   *
   * For simplicity sake, we move a few event handlers from MDIChatClient to this class. This way, the MDIChatClient class
   * is less cluttered and easier to read. The MDIChatClient class can now focus on managing the MDI child forms and the
   * TreeView control, while the CustomTreeView class can focus on drawing the TreeView nodes and handling the context menu.
   */
  internal class CustomTreeView : TreeView
  {
    public CustomTreeView()
    {
      // Enable owner drawing of the TreeView nodes.
      this.DrawMode = TreeViewDrawMode.OwnerDrawText;

      // Select the node when the user clicks on it (also right click)
      this.NodeMouseClick += (sender, args) => this.SelectedNode = args.Node;

      // We create our own ContextMenu
      ContextMenuStrip cmStrip = new ContextMenuStrip();
      cmStrip.Opening += ContextMenu_Opening;
      this.ContextMenuStrip = cmStrip;

      // Show form after select
      this.AfterSelect += CustomTreeView_AfterSelect;
    }

    private void CustomTreeView_AfterSelect(object? sender, TreeViewEventArgs e)
    {
      if (e.Node == null)
      {
        return;
      }
      if (e.Node.Tag is Form)
      {
        Form selectedForm = (Form)e.Node.Tag;
        if (!selectedForm.Focused)
          selectedForm.Focus();
      }
      else if (e.Node.Tag != null)
      {
        PInvoke.SetForegroundWindow(new HWND((IntPtr)e.Node.Tag));
      }
    }

    private void ContextMenu_Opening(object? sender, CancelEventArgs e)
    {
      // Prevent the default context menu from showing
      e.Cancel = true;

      if (this.SelectedNode == null)
        return;

      TreeNode node = this.SelectedNode;

      HWND hWnd = (HWND)IntPtr.Zero;

      if (node.Tag is Form selectedForm)
      {
        // Form
        hWnd = (HWND)selectedForm.Handle;
      }
      else
      {
        // hWnd
        hWnd = new HWND((IntPtr)node.Tag);
      }
      Debug.WriteLine("System Menu for {0:X}", hWnd.Value);

      HMENU hMenu = PInvoke.GetSystemMenu(hWnd, false);
      TRACK_POPUP_MENU_FLAGS uFlags =
        TRACK_POPUP_MENU_FLAGS.TPM_LEFTALIGN
        | TRACK_POPUP_MENU_FLAGS.TPM_TOPALIGN
        | TRACK_POPUP_MENU_FLAGS.TPM_RETURNCMD
        | TRACK_POPUP_MENU_FLAGS.TPM_RIGHTBUTTON;
      unsafe
      {
        // Unsafed needed as there is an optional pointer parameter in TrackPopupMenu (prcRect), which is ignored.
        int wParam = PInvoke.TrackPopupMenu(
          hMenu,
          uFlags,
          Control.MousePosition.X,
          Control.MousePosition.Y,
          0,
          hWnd
        );
        PInvoke.PostMessage(hWnd, PInvoke.WM_SYSCOMMAND, (uint)wParam, 0);
      }
    }

    protected override void OnDrawNode(DrawTreeNodeEventArgs e)
    {
      if (!this.Focused && e.Node == this.SelectedNode)
      { // Case: Node selected but TreeView not focused
        // Draw the selected node with the system highlight color and text color.
        e.Graphics.FillRectangle(SystemBrushes.Highlight, e.Bounds);
        TextRenderer.DrawText(
          e.Graphics,
          e.Node.Text,
          this.Font,
          e.Bounds,
          SystemColors.HighlightText,
          TextFormatFlags.GlyphOverhangPadding
        );
        e.DrawDefault = false;
      }
      else
      {
        // Draw the node using the default drawing method.
        e.DrawDefault = true;
      }
    }
  }
}
