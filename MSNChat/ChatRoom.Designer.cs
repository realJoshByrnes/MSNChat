using MSNChatControlLibrary;

namespace MSNChat
{
  partial class ChatRoom
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      msnChatControl1 = new MSNChatControl();
      SuspendLayout();
      // 
      // msnChatControl1
      // 
      msnChatControl1.BackColor = Color.FromArgb(255, 192, 255);
      msnChatControl1.Dock = DockStyle.Fill;
      msnChatControl1.Feature = 0U;
      msnChatControl1.Location = new Point(0, 0);
      msnChatControl1.Name = "msnChatControl1";
      msnChatControl1.NickName = "User";
      msnChatControl1.Size = new Size(800, 450);
      msnChatControl1.TabIndex = 0;
      // 
      // ChatRoom
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(800, 450);
      Controls.Add(msnChatControl1);
      Name = "ChatRoom";
      Text = "ChatRoom";
      ResumeLayout(false);
    }

    #endregion

    private MSNChatControl msnChatControl1;
  }
}
