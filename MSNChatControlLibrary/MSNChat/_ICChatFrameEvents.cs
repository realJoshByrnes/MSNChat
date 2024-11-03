using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MSNChat;

[ComImport]
[InterfaceType(2)]
[TypeLibType(4096)]
[Guid("5EEB8014-53B2-448B-9F3B-C553424832E1")]
public interface _ICChatFrameEvents
{
	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(1)]
	void OnRedirect([In][MarshalAs(UnmanagedType.BStr)] string strUrl);
}
