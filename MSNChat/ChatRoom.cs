using System.Diagnostics;

namespace MSNChat
{
  public partial class ChatRoom : Form
  {
    public ChatRoom()
    {
      InitializeComponent();
      chatFrame1.OcxHandleCreated += new EventHandler(chatFrame1_OcxHandleCreated);
    }

    private void chatFrame1_OcxHandleCreated(object? sender, EventArgs e)
    {
      Debug.WriteLine("chatFrame1_OcxHandleCreated", chatFrame1.OcxHandle.ToString("X8"));
    }
  }
}
