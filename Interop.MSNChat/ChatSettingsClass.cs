// Decompiled with JetBrains decompiler
// Type: MSNChat.ChatSettingsClass
// Assembly: Interop.MSNChat, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B3DBEF1A-99F6-48A3-AEB2-E075E4CB5FD7
// Assembly location: C:\Users\joshu\Projects\MSNChat\MSNChatControlLibrary\MSNChat\Interop.MSNChat.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MSNChat
{
  [ClassInterface(ClassInterfaceType.None)]
  [TypeLibType(2)]
  [Guid("FA980E7E-9E44-4D2F-B3C2-9A5BE42525F8")]
  [ComImport]
  public class ChatSettingsClass : IChatSettings, ChatSettings
  {
    //[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    //public extern ChatSettingsClass();

    [DispId(-501)]
    [ComAliasName("stdole.OLE_COLOR")]
    public extern virtual uint BackColor
    {
      [
        DispId(-501),
        MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)
      ]
      [param: ComAliasName("stdole.OLE_COLOR"), In]
      set;
      [
        DispId(-501),
        MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)
      ]
      [return: ComAliasName("stdole.OLE_COLOR")]
      get;
    }

    [DispId(-513)]
    [ComAliasName("stdole.OLE_COLOR")]
    public extern virtual uint ForeColor
    {
      [
        DispId(-513),
        MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)
      ]
      [param: ComAliasName("stdole.OLE_COLOR"), In]
      set;
      [
        DispId(-513),
        MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)
      ]
      [return: ComAliasName("stdole.OLE_COLOR")]
      get;
    }

    [DispId(1)]
    public extern virtual string RedirectURL
    {
      [
        DispId(1),
        MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)
      ]
      [param: MarshalAs(UnmanagedType.BStr), In]
      set;
      [
        DispId(1),
        MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)
      ]
      [return: MarshalAs(UnmanagedType.BStr)]
      get;
    }

    [DispId(2)]
    public extern virtual string ResDLL
    {
      [
        DispId(2),
        MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)
      ]
      [param: MarshalAs(UnmanagedType.BStr), In]
      set;
      [
        DispId(2),
        MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)
      ]
      [return: MarshalAs(UnmanagedType.BStr)]
      get;
    }
  }
}
