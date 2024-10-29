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
      chatFrame1 = new MSNChatControl.ChatFrame();
      chatFrame1.SuspendLayout();
      SuspendLayout();
      // 
      // chatFrame1
      // 
      chatFrame1.Dock = DockStyle.Fill;
      chatFrame1.Feature = 0U;
      chatFrame1.Location = new Point(0, 0);
      chatFrame1.Name = "chatFrame1";
      chatFrame1.NickName = "X6681";
      chatFrame1.Size = new Size(800, 450);
      chatFrame1.TabIndex = 0;
      // 
      // ChatRoom
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(800, 450);
      Controls.Add(chatFrame1);
      Name = "ChatRoom";
      Text = "ChatRoom";
      chatFrame1.ResumeLayout(false);
      ResumeLayout(false);
    }
    #endregion

    private MSNChatControl.ChatFrame chatFrame1;
  }
}
