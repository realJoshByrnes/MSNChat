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

      if (PInvoke.SetProcessDEPPolicy(PROCESS_DEP_FLAGS.PROCESS_DEP_ENABLE) != 1)
      {
        MessageBox.Show("Failed to modify DEP policy for this process.", "MSN Chat", MessageBoxButtons.OK, MessageBoxIcon.Error);
      };
      // TODO: GetProcessDEPPolicy. We can display more information if PROCESS_DEP_FLAGS.PROCESS_DEP_DISABLE_ATL_THUNK_EMULATION is set (as this will cause crashes).

      ApplicationConfiguration.Initialize();
      Application.Run(new MDIChatClient());
    }
  }
}
