using System.Diagnostics;
using System.Runtime.InteropServices;
using MSNChatControlLibrary;
using Windows.Win32;
using Windows.Win32.Foundation;
using Windows.Win32.UI.WindowsAndMessaging;

namespace MSNChat
{
  public partial class ChatRoom : Form
  {
    public TreeNode rootTreeNode;
    private TreeView treeView;

    // Dictionary of Whisper Window (child) tree nodes.
    private Dictionary<HWND, TreeNode> wwTreeNodes = new();

    public ChatRoom(TreeView treeView)
    {
      InitializeComponent();
      this.treeView = treeView;
      this.rootTreeNode = new();
      this.rootTreeNode.Tag = this;
      treeView.BeginInvoke(() => treeView.Nodes.Add(rootTreeNode));

      this.TextChanged += (s, e) => rootTreeNode.Text = this.Text;
      this.FormClosed += (s, e) => rootTreeNode.Remove();
      this.Activated += (s, e) => treeView.SelectedNode = rootTreeNode;

      //chatFrame1.OcxHandleCreated += new EventHandler(chatFrame1_OcxHandleCreated);
    }

    //private void chatFrame1_OcxHandleCreated(object? sender, EventArgs e)
    //{
    //  // Now that we have an OCX hWnd, get the (child) CWhisperManager hWnd;
    //  HWND hwndCWM = PInvoke.FindWindowEx((HWND)chatFrame1.Handle, (HWND)IntPtr.Zero, "CWhisperManager", null);
    //  uint threadCWM;
    //  uint processCWM; // We don't actually need this, but it's worth keeping to show why it needs to be unsafe.
    //  // Get CWhisperManager ThreadID and ProcessID (all Whisper Windows are on this thread).
    //  unsafe
    //  {
    //    threadCWM = PInvoke.GetWindowThreadProcessId(hwndCWM, &processCWM);
    //  }
    //  // Set a hook on the CWhisperManager window's thread.
    //  PInvoke.SetWindowsHookEx(WINDOWS_HOOK_ID.WH_CALLWNDPROCRET, new HOOKPROC(HookProc), (HINSTANCE)0, threadCWM);
    //}

    // https://learn.microsoft.com/en-us/windows/win32/api/winuser/nc-winuser-hookproc
    LRESULT HookProc(int code, WPARAM wParam, LPARAM lParam)
    {
      if (code < 0)
      {
        // If nCode is less than zero, the hook procedure must return the value returned by CallNextHookEx function.
        return PInvoke.CallNextHookEx(null, code, wParam, lParam);
      }

      CWPRETSTRUCT cwp = Marshal.PtrToStructure<CWPRETSTRUCT>(lParam);

      if (WinUtils.isDialogWindow(cwp.hwnd))
      {
        switch (cwp.message)
        {
          case PInvoke.WM_CREATE:
            TreeNode treeNode = new TreeNode();
            treeNode.Tag = cwp.hwnd.Value;
            wwTreeNodes.Add(cwp.hwnd, treeNode);
            treeView.BeginInvoke(() => rootTreeNode.Nodes.Add(treeNode));
            break;
          case PInvoke.WM_DESTROY:
            if (wwTreeNodes.TryGetValue(cwp.hwnd, out TreeNode? node))
            {
              treeView.BeginInvoke(() =>
              {
                node?.Remove();
              });
              wwTreeNodes.Remove(cwp.hwnd);
            }
            else
            {
              Debug.WriteLine("Couldn't get treenode");
            }
            break;
          case PInvoke.WM_SETTEXT:
            if (wwTreeNodes.TryGetValue(cwp.hwnd, out TreeNode? node2))
            {
              treeView.BeginInvoke(() =>
              {
                node2.Text = WinUtils.GetWindowText(cwp.hwnd);
              }); // TODO: Get the param directly from the message
            }
            break;
          case PInvoke.WM_ACTIVATE:
            if ((cwp.wParam & (PInvoke.WA_ACTIVE | PInvoke.WA_CLICKACTIVE)) != 0)
            {
              if (wwTreeNodes.TryGetValue(cwp.hwnd, out TreeNode? node3))
              {
                this.treeView.BeginInvoke(() => this.treeView.SelectedNode = node3);
              }
            }
            break;
        }
      }
      /* If nCode is greater than or equal to zero, it is highly recommended that you call CallNextHookEx function and return the value it returns;
       * otherwise, other applications that have installed WH_CALLWNDPROCRET hooks will not receive hook notifications and may behave incorrectly
       * as a result. If the hook procedure does not call CallNextHookEx, the return value should be zero.
       */
      return PInvoke.CallNextHookEx(null, code, wParam, lParam);
    }
  }
}
