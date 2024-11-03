using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MSNChat;

[ComImport]
[ClassInterface((short)0)]
[TypeLibType(2)]
[Guid("FA980E7E-9E44-4D2F-B3C2-9A5BE42525F8")]
public class ChatSettingsClass : IChatSettings, ChatSettings
{
	[DispId(-501)]
	[ComAliasName("stdole.OLE_COLOR")]
	public virtual extern uint BackColor
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(-501)]
		[return: ComAliasName("stdole.OLE_COLOR")]
		get;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(-501)]
		[param: In]
		[param: ComAliasName("stdole.OLE_COLOR")]
		set;
	}

	[DispId(-513)]
	[ComAliasName("stdole.OLE_COLOR")]
	public virtual extern uint ForeColor
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(-513)]
		[return: ComAliasName("stdole.OLE_COLOR")]
		get;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(-513)]
		[param: In]
		[param: ComAliasName("stdole.OLE_COLOR")]
		set;
	}

	[DispId(1)]
	public virtual extern string RedirectURL
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(1)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(1)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
	}

	[DispId(2)]
	public virtual extern string ResDLL
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(2)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(2)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
	}
}
