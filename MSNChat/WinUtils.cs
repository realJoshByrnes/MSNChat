using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using Windows.Win32;
using Windows.Win32.Foundation;

namespace MSNChat
{
  internal static class WinUtils
  {
    public static String getClassName(HWND hWnd)
    {
      string className = "";
      unsafe
      {
        // The maximum length for lpszClassName is 256.
        var classNameLen = 256;
        IntPtr strMem = Marshal.AllocHGlobal((classNameLen + 1) * sizeof(char));
        PWSTR lpClassName = new PWSTR((char*)strMem);

        if (PInvoke.GetClassName(hWnd, lpClassName, classNameLen + 1) != 0)
        {
          className = lpClassName.ToString();
        }
        Marshal.FreeHGlobal(strMem);
      }
      return className;
    }

    public static string GetWindowText(HWND hWnd)
    {
      string windowText = "";
      int stringLen = PInvoke.GetWindowTextLength(hWnd);
      if (stringLen != 0)
        unsafe
        {
          IntPtr stringMem = Marshal.AllocHGlobal((stringLen + 1) * sizeof(char));
          PWSTR lpString = new PWSTR((char*)stringMem);
          if (PInvoke.GetWindowText(hWnd, lpString, stringLen + 1) != 0)
          {
            windowText = lpString.ToString();
          }
          Marshal.FreeHGlobal(stringMem);
        }
      return windowText;
    }

    public static bool isDialogWindow(HWND hWnd)
    {
      return getClassName(hWnd) == "#32770";
    }
  }
}
