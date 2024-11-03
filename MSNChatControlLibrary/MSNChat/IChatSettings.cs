using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MSNChat;

[ComImport]
[Guid("D5EF4299-12F1-474D-98C5-3C658FD2E343")]
[TypeLibType(4160)]
public interface IChatSettings
{
	[DispId(-501)]
	[ComAliasName("stdole.OLE_COLOR")]
	uint BackColor
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
	uint ForeColor
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
	string RedirectURL
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
	string ResDLL
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
