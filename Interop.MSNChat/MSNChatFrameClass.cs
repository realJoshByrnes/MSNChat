// Decompiled with JetBrains decompiler
// Type: MSNChat.MSNChatFrameClass
// Assembly: Interop.MSNChat, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B3DBEF1A-99F6-48A3-AEB2-E075E4CB5FD7
// Assembly location: C:\Users\joshu\Projects\MSNChat\MSNChatControlLibrary\MSNChat\Interop.MSNChat.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MSNChat
{
  [Guid("F58E1CEF-A068-4C15-BA5E-587CAF3EE8C6")]
  [ClassInterface(ClassInterfaceType.None)]
  [TypeLibType(2)]
  [ComImport]
  public class MSNChatFrameClass : IChatFrame, MSNChatFrame
  {
    //[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    //public extern MSNChatFrameClass();

    [ComAliasName("stdole.OLE_COLOR")]
    [DispId(-501)]
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

    [DispId(2)]
    public extern virtual string RoomName
    {
      [
        DispId(2),
        MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)
      ]
      [return: MarshalAs(UnmanagedType.BStr)]
      get;
      [
        DispId(2),
        MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)
      ]
      [param: MarshalAs(UnmanagedType.BStr), In]
      set;
    }

    [DispId(3)]
    public extern virtual string HexRoomName
    {
      [
        DispId(3),
        MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)
      ]
      [return: MarshalAs(UnmanagedType.BStr)]
      get;
      [
        DispId(3),
        MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)
      ]
      [param: MarshalAs(UnmanagedType.BStr), In]
      set;
    }

    [DispId(4)]
    public extern virtual string NickName
    {
      [
        DispId(4),
        MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)
      ]
      [return: MarshalAs(UnmanagedType.BStr)]
      get;
      [
        DispId(4),
        MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)
      ]
      [param: MarshalAs(UnmanagedType.BStr), In]
      set;
    }

    [DispId(5)]
    public extern virtual string Server
    {
      [
        DispId(5),
        MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)
      ]
      [return: MarshalAs(UnmanagedType.BStr)]
      get;
      [
        DispId(5),
        MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)
      ]
      [param: MarshalAs(UnmanagedType.BStr), In]
      set;
    }

    [ComAliasName("stdole.OLE_COLOR")]
    [DispId(6)]
    public extern virtual uint BackHighlightColor
    {
      [
        DispId(6),
        MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)
      ]
      [return: ComAliasName("stdole.OLE_COLOR")]
      get;
      [
        DispId(6),
        MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)
      ]
      [param: ComAliasName("stdole.OLE_COLOR"), In]
      set;
    }

    [ComAliasName("stdole.OLE_COLOR")]
    [DispId(7)]
    public extern virtual uint ButtonFrameColor
    {
      [
        DispId(7),
        MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)
      ]
      [return: ComAliasName("stdole.OLE_COLOR")]
      get;
      [
        DispId(7),
        MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)
      ]
      [param: ComAliasName("stdole.OLE_COLOR"), In]
      set;
    }

    [ComAliasName("stdole.OLE_COLOR")]
    [DispId(8)]
    public extern virtual uint TopBackHighlightColor
    {
      [
        DispId(8),
        MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)
      ]
      [return: ComAliasName("stdole.OLE_COLOR")]
      get;
      [
        DispId(8),
        MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)
      ]
      [param: ComAliasName("stdole.OLE_COLOR"), In]
      set;
    }

    [DispId(9)]
    public extern virtual int ChatMode
    {
      [
        DispId(9),
        MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)
      ]
      get;
      [
        DispId(9),
        MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)
      ]
      [param: In]
      set;
    }

    [DispId(10)]
    public extern virtual string URLBack
    {
      [
        DispId(10),
        MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)
      ]
      [return: MarshalAs(UnmanagedType.BStr)]
      get;
      [
        DispId(10),
        MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)
      ]
      [param: MarshalAs(UnmanagedType.BStr), In]
      set;
    }

    [DispId(11)]
    public extern virtual string Category
    {
      [
        DispId(11),
        MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)
      ]
      [return: MarshalAs(UnmanagedType.BStr)]
      get;
      [
        DispId(11),
        MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)
      ]
      [param: MarshalAs(UnmanagedType.BStr), In]
      set;
    }

    [DispId(12)]
    public extern virtual string Topic
    {
      [
        DispId(12),
        MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)
      ]
      [return: MarshalAs(UnmanagedType.BStr)]
      get;
      [
        DispId(12),
        MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)
      ]
      [param: MarshalAs(UnmanagedType.BStr), In]
      set;
    }

    [DispId(13)]
    public extern virtual string WelcomeMsg
    {
      [
        DispId(13),
        MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)
      ]
      [return: MarshalAs(UnmanagedType.BStr)]
      get;
      [
        DispId(13),
        MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)
      ]
      [param: MarshalAs(UnmanagedType.BStr), In]
      set;
    }

    [DispId(15)]
    public extern virtual string BaseURL
    {
      [
        DispId(15),
        MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)
      ]
      [return: MarshalAs(UnmanagedType.BStr)]
      get;
      [
        DispId(15),
        MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)
      ]
      [param: MarshalAs(UnmanagedType.BStr), In]
      set;
    }

    [DispId(16)]
    [ComAliasName("stdole.OLE_COLOR")]
    public extern virtual uint InputBorderColor
    {
      [
        DispId(16),
        MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)
      ]
      [return: ComAliasName("stdole.OLE_COLOR")]
      get;
      [
        DispId(16),
        MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)
      ]
      [param: ComAliasName("stdole.OLE_COLOR"), In]
      set;
    }

    [DispId(17)]
    public extern virtual string CreateRoom
    {
      [
        DispId(17),
        MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)
      ]
      [return: MarshalAs(UnmanagedType.BStr)]
      get;
      [
        DispId(17),
        MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)
      ]
      [param: MarshalAs(UnmanagedType.BStr), In]
      set;
    }

    [DispId(19)]
    public extern virtual string ChatHome
    {
      [
        DispId(19),
        MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)
      ]
      [return: MarshalAs(UnmanagedType.BStr)]
      get;
      [
        DispId(19),
        MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)
      ]
      [param: MarshalAs(UnmanagedType.BStr), In]
      set;
    }

    [DispId(20)]
    public extern virtual string Locale
    {
      [
        DispId(20),
        MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)
      ]
      [return: MarshalAs(UnmanagedType.BStr)]
      get;
      [
        DispId(20),
        MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)
      ]
      [param: MarshalAs(UnmanagedType.BStr), In]
      set;
    }

    [DispId(21)]
    public extern virtual string ResDLL
    {
      [
        DispId(21),
        MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)
      ]
      [return: MarshalAs(UnmanagedType.BStr)]
      get;
      [
        DispId(21),
        MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)
      ]
      [param: MarshalAs(UnmanagedType.BStr), In]
      set;
    }

    [DispId(22)]
    [ComAliasName("stdole.OLE_COLOR")]
    public extern virtual uint ButtonTextColor
    {
      [
        DispId(22),
        MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)
      ]
      [return: ComAliasName("stdole.OLE_COLOR")]
      get;
      [
        DispId(22),
        MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)
      ]
      [param: ComAliasName("stdole.OLE_COLOR"), In]
      set;
    }

    [ComAliasName("stdole.OLE_COLOR")]
    [DispId(23)]
    public extern virtual uint ButtonBackColor
    {
      [
        DispId(23),
        MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)
      ]
      [return: ComAliasName("stdole.OLE_COLOR")]
      get;
      [
        DispId(23),
        MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)
      ]
      [param: ComAliasName("stdole.OLE_COLOR"), In]
      set;
    }

    [DispId(24)]
    public extern virtual string PassportTicket
    {
      [
        DispId(24),
        MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)
      ]
      [return: MarshalAs(UnmanagedType.BStr)]
      get;
      [
        DispId(24),
        MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)
      ]
      [param: MarshalAs(UnmanagedType.BStr), In]
      set;
    }

    [DispId(25)]
    public extern virtual string PassportProfile
    {
      [
        DispId(25),
        MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)
      ]
      [return: MarshalAs(UnmanagedType.BStr)]
      get;
      [
        DispId(25),
        MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)
      ]
      [param: MarshalAs(UnmanagedType.BStr), In]
      set;
    }

    [DispId(26)]
    public extern virtual uint Feature
    {
      [
        DispId(26),
        MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)
      ]
      get;
      [
        DispId(26),
        MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)
      ]
      [param: In]
      set;
    }

    [DispId(27)]
    public extern virtual string MessageOfTheDay
    {
      [
        DispId(27),
        MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)
      ]
      [return: MarshalAs(UnmanagedType.BStr)]
      get;
      [
        DispId(27),
        MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)
      ]
      [param: MarshalAs(UnmanagedType.BStr), In]
      set;
    }

    [DispId(28)]
    public extern virtual string ChannelLanguage
    {
      [
        DispId(28),
        MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)
      ]
      [return: MarshalAs(UnmanagedType.BStr)]
      get;
      [
        DispId(28),
        MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)
      ]
      [param: MarshalAs(UnmanagedType.BStr), In]
      set;
    }

    [DispId(29)]
    public extern virtual string InvitationCode
    {
      [
        DispId(29),
        MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)
      ]
      [return: MarshalAs(UnmanagedType.BStr)]
      get;
      [
        DispId(29),
        MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)
      ]
      [param: MarshalAs(UnmanagedType.BStr), In]
      set;
    }

    [DispId(30)]
    public extern virtual string NicknameToInvite
    {
      [
        DispId(30),
        MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)
      ]
      [return: MarshalAs(UnmanagedType.BStr)]
      get;
      [
        DispId(30),
        MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)
      ]
      [param: MarshalAs(UnmanagedType.BStr), In]
      set;
    }

    [DispId(31)]
    public extern virtual string MSNREGCookie
    {
      [
        DispId(31),
        MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)
      ]
      [return: MarshalAs(UnmanagedType.BStr)]
      get;
      [
        DispId(31),
        MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)
      ]
      [param: MarshalAs(UnmanagedType.BStr), In]
      set;
    }

    [DispId(32)]
    public extern virtual string CreationModes
    {
      [
        DispId(32),
        MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)
      ]
      [return: MarshalAs(UnmanagedType.BStr)]
      get;
      [
        DispId(32),
        MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)
      ]
      [param: MarshalAs(UnmanagedType.BStr), In]
      set;
    }

    [DispId(33)]
    public extern virtual string MSNProfile
    {
      [
        DispId(33),
        MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)
      ]
      [return: MarshalAs(UnmanagedType.BStr)]
      get;
      [
        DispId(33),
        MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)
      ]
      [param: MarshalAs(UnmanagedType.BStr), In]
      set;
    }

    [DispId(34)]
    public extern virtual string Market
    {
      [
        DispId(34),
        MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)
      ]
      [return: MarshalAs(UnmanagedType.BStr)]
      get;
      [
        DispId(34),
        MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)
      ]
      [param: MarshalAs(UnmanagedType.BStr), In]
      set;
    }

    [DispId(35)]
    public extern virtual string WhisperContent
    {
      [
        DispId(35),
        MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)
      ]
      [return: MarshalAs(UnmanagedType.BStr)]
      get;
      [
        DispId(35),
        MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)
      ]
      [param: MarshalAs(UnmanagedType.BStr), In]
      set;
    }

    [DispId(36)]
    public extern virtual string UserRole
    {
      [
        DispId(36),
        MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)
      ]
      [return: MarshalAs(UnmanagedType.BStr)]
      get;
      [
        DispId(36),
        MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)
      ]
      [param: MarshalAs(UnmanagedType.BStr), In]
      set;
    }

    [DispId(37)]
    public extern virtual string AuditMessage
    {
      [
        DispId(37),
        MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)
      ]
      [return: MarshalAs(UnmanagedType.BStr)]
      get;
      [
        DispId(37),
        MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)
      ]
      [param: MarshalAs(UnmanagedType.BStr), In]
      set;
    }

    [DispId(38)]
    public extern virtual string SubscriberInfo
    {
      [
        DispId(38),
        MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)
      ]
      [return: MarshalAs(UnmanagedType.BStr)]
      get;
      [
        DispId(38),
        MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)
      ]
      [param: MarshalAs(UnmanagedType.BStr), In]
      set;
    }

    [DispId(39)]
    public extern virtual string UpsellURL
    {
      [
        DispId(39),
        MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)
      ]
      [return: MarshalAs(UnmanagedType.BStr)]
      get;
      [
        DispId(39),
        MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)
      ]
      [param: MarshalAs(UnmanagedType.BStr), In]
      set;
    }
  }
}
