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
      chatFrame = new ChatFrame();
      SuspendLayout();
      // 
      // chatFrame
      // 
      chatFrame.Dock = DockStyle.Fill;
      chatFrame.Feature = 0U;
      chatFrame.Location = new Point(0, 0);
      chatFrame.Name = "chatFrame";
      chatFrame.NickName = "JD";
      chatFrame.Size = new Size(800, 450);
      chatFrame.TabIndex = 0;
      // 
      // ChatRoom
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(800, 450);
      Controls.Add(chatFrame);
      Name = "ChatRoom";
      Text = "ChatRoom";
      ResumeLayout(false);
    }

    #endregion

    private ChatFrame chatFrame;
  }
}