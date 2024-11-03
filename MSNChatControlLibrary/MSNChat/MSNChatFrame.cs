using System.Runtime.InteropServices;

namespace MSNChat;

[ComImport]
[Guid("125E64FA-3304-4BB9-A756-D0D44CC8CD7D")]
[CoClass(typeof(MSNChatFrameClass))]
public interface MSNChatFrame : IChatFrame
{
}
