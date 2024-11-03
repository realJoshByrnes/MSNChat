using System.Runtime.InteropServices;

namespace MSNChat;

[ComImport]
[CoClass(typeof(ChatSettingsClass))]
[Guid("D5EF4299-12F1-474D-98C5-3C658FD2E343")]
public interface ChatSettings : IChatSettings
{
}
