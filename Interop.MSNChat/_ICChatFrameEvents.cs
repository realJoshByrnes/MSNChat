// Decompiled with JetBrains decompiler
// Type: MSNChat._ICChatFrameEvents
// Assembly: Interop.MSNChat, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B3DBEF1A-99F6-48A3-AEB2-E075E4CB5FD7
// Assembly location: C:\Users\joshu\Projects\MSNChat\MSNChatControlLibrary\MSNChat\Interop.MSNChat.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MSNChat
{
  [InterfaceType(2)]
  [TypeLibType(4096)]
  [Guid("5EEB8014-53B2-448B-9F3B-C553424832E1")]
  [ComImport]
  public interface _ICChatFrameEvents
  {
    [DispId(1)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void OnRedirect([MarshalAs(UnmanagedType.BStr), In] string strUrl);
  }
}
