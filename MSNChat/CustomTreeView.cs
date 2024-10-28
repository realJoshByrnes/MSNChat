using System.ComponentModel;
using Windows.Win32;
using Windows.Win32.Foundation;
using Windows.Win32.UI.WindowsAndMessaging;

namespace MSNChat
{
  /*
   * CustomTreeView is a custom TreeView control that draws the selected node with the system highlight color and text color
   * when the TreeView does not have focus. This is necessary because the default TreeView control does not draw the selected
   * node well when the TreeView does not have focus, which can make it difficult for users to see which node is selected.
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
    }

    private void ContextMenu_Opening(object? sender, CancelEventArgs e)
    {
      // Prevent the default context menu from showing
      e.Cancel = true;

      if (this.SelectedNode == null)
        return;

      // Show the Form's system menu at the mouse position
      if (this.SelectedNode?.Tag is Form selectedForm)
      {
        HWND hWnd = (HWND)selectedForm.Handle;
        HMENU hMenu = PInvoke.GetSystemMenu(hWnd, false);
        TRACK_POPUP_MENU_FLAGS uFlags = TRACK_POPUP_MENU_FLAGS.TPM_LEFTALIGN |
                                        TRACK_POPUP_MENU_FLAGS.TPM_TOPALIGN |
                                        TRACK_POPUP_MENU_FLAGS.TPM_RETURNCMD |
                                        TRACK_POPUP_MENU_FLAGS.TPM_RIGHTBUTTON;
        unsafe
        {
          // Unsafed needed as there is an optional pointer parameter in TrackPopupMenu (prcRect), which is ignored.
          int wParam = PInvoke.TrackPopupMenu(hMenu, uFlags, Control.MousePosition.X, Control.MousePosition.Y, 0, hWnd);
          PInvoke.PostMessage(hWnd, PInvoke.WM_SYSCOMMAND, (uint)wParam, 0);
        }
      }
    }

    protected override void OnDrawNode(DrawTreeNodeEventArgs e)
    {
      if (!this.Focused && e.Node == this.SelectedNode)
      { // Case: Node selected but TreeView not focused
        // Draw the selected node with the system highlight color and text color.
        e.Graphics.FillRectangle(SystemBrushes.Highlight, e.Bounds);
        TextRenderer.DrawText(e.Graphics, e.Node.Text, this.Font, e.Bounds, SystemColors.HighlightText, TextFormatFlags.GlyphOverhangPadding);
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
