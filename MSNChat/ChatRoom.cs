using Microsoft.Win32.SafeHandles;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;
using Windows.Win32;
using Windows.Win32.Foundation;
using Windows.Win32.UI.Accessibility;
using Windows.Win32.UI.WindowsAndMessaging;

namespace MSNChat
{
  public partial class ChatRoom : Form
  {
    public ChatRoom()
    {
      InitializeComponent();
      chatFrame1.OcxHandleCreated += new EventHandler(chatFrame1_OcxHandleCreated);
    }

    private void chatFrame1_OcxHandleCreated(object? sender, EventArgs e)
    {
      HWND hwndCWM = PInvoke.FindWindowEx((HWND)chatFrame1.OcxHandle, (HWND)IntPtr.Zero, "CWhisperManager", null);

      uint threadCWM;
      uint processCWM; // We don't actually need this, but it's worth keeping to show why it needs to be unsafe.
      unsafe {
        threadCWM = PInvoke.GetWindowThreadProcessId(hwndCWM, &processCWM);
      }

      PInvoke.SetWindowsHookEx(WINDOWS_HOOK_ID.WH_CALLWNDPROCRET, new HOOKPROC(HookProc), (HINSTANCE)0, threadCWM);
    }

    LRESULT HookProc(int code, WPARAM wParam, LPARAM lParam)
    {
      if (code < 0)
        return PInvoke.CallNextHookEx(null, code, wParam, lParam);

      CWPRETSTRUCT cwp = Marshal.PtrToStructure<CWPRETSTRUCT>(lParam);
      if (cwp.message == (uint) /* WM_CREATE */ 0x1)
      {
        if (WinUtils.isDialogWindow(cwp.hwnd))
          Debug.WriteLine($"CREATE {cwp.hwnd} - {WinUtils.GetWindowText(cwp.hwnd)}");
      }
      else if (cwp.message == (uint) /* WM_DESTROY */ 0x2)
      {
        if (WinUtils.isDialogWindow(cwp.hwnd))
          Debug.WriteLine($"DESTROY {cwp.hwnd} - {WinUtils.GetWindowText(cwp.hwnd)}");
      }
      else if (cwp.message == (uint) /* WM_SETTEXT */ 0xc)
      {
        if (WinUtils.isDialogWindow(cwp.hwnd))
          Debug.WriteLine($"SETTEXT {cwp.hwnd} - {WinUtils.GetWindowText(cwp.hwnd)}");
      }
      return PInvoke.CallNextHookEx(null, code, wParam, lParam);
    }
  }
}
