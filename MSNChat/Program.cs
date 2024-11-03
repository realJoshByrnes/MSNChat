using Microsoft.Win32.SafeHandles;
using System.Diagnostics;
using Windows.Win32;
using Windows.Win32.Foundation;
using Windows.Win32.System.Threading;

namespace MSNChat
{
  internal static class Program
  {
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
      // To customize application configuration such as set high DPI settings or default font,
      // see https://aka.ms/applicationconfiguration.

      if (!PInvoke.SetProcessDEPPolicy(PROCESS_DEP_FLAGS.PROCESS_DEP_ENABLE))
      {
        // Get the current process handle
        using (SafeProcessHandle hProcess = new SafeProcessHandle(Process.GetCurrentProcess().Handle, false))
        {
          // Call GetProcessDEPPolicy
          if (PInvoke.GetProcessDEPPolicy(hProcess, out uint flags, out BOOL permanent))
          {
            PROCESS_DEP_FLAGS depFlags = (PROCESS_DEP_FLAGS)flags;
            if ((depFlags & PROCESS_DEP_FLAGS.PROCESS_DEP_DISABLE_ATL_THUNK_EMULATION) != 0)
            {
              MessageBox.Show("This computer's Data Execution Policy will not allow the MSN Chat Control to load.\nPlease disable DEP for this process and try again.", "MSN Chat", MessageBoxButtons.OK, MessageBoxIcon.Error);
              return;
            }
          }
        }
      }

      ApplicationConfiguration.Initialize();
      Application.Run(new MDIChatClient());
    }
  }
}
