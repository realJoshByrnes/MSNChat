using MSNChatControlLibrary;

namespace MSNChat
{
  public partial class MDIChatClient : Form
  {
    private int childFormNumber = 0;

    public MDIChatClient()
    {
      InitializeComponent();
      this.Activated += (s, e) =>
      {
        if (ActiveMdiChild is ChatRoom)
          treeView.SelectedNode = ((ChatRoom)ActiveMdiChild).rootTreeNode;
      };
    }

    private void ShowNewForm(object sender, EventArgs e)
    {
      Form childForm = new ChatRoom(treeView);
      childForm.MdiParent = this;
      childForm.Text = "Window " + childFormNumber++;
      childForm.Show();
    }

    private void OpenFile(object sender, EventArgs e)
    {
      OpenFileDialog openFileDialog = new OpenFileDialog();
      openFileDialog.InitialDirectory = Environment.GetFolderPath(
        Environment.SpecialFolder.Personal
      );
      openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
      if (openFileDialog.ShowDialog(this) == DialogResult.OK)
      {
        string FileName = openFileDialog.FileName;
      }
    }

    private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
    {
      SaveFileDialog saveFileDialog = new SaveFileDialog();
      saveFileDialog.InitialDirectory = Environment.GetFolderPath(
        Environment.SpecialFolder.Personal
      );
      saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
      if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
      {
        string FileName = saveFileDialog.FileName;
      }
    }

    private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void CutToolStripMenuItem_Click(object sender, EventArgs e) { }

    private void CopyToolStripMenuItem_Click(object sender, EventArgs e) { }

    private void PasteToolStripMenuItem_Click(object sender, EventArgs e) { }

    private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
    {
      toolStrip.Visible = toolBarToolStripMenuItem.Checked;
    }

    private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
    {
      statusStrip.Visible = statusBarToolStripMenuItem.Checked;
    }

    private void TreeBarToolStripMenuItem_Click(object sender, EventArgs e)
    {
      treeView.Visible = treeBarToolStripMenuItem.Checked;
      splitter1.Visible = treeBarToolStripMenuItem.Checked;
    }

    private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
    {
      LayoutMdi(MdiLayout.Cascade);
    }

    private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
    {
      LayoutMdi(MdiLayout.TileVertical);
    }

    private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
    {
      LayoutMdi(MdiLayout.TileHorizontal);
    }

    private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
    {
      LayoutMdi(MdiLayout.ArrangeIcons);
    }

    private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
    {
      foreach (Form childForm in MdiChildren)
      {
        childForm.Close();
      }
    }

    private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
    {
      AboutBox aboutBox = new AboutBox();
      aboutBox.ShowDialog();
    }

    private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Form form = new Form();
      var cs = new ChatSettingsControl();
      cs.Dock = DockStyle.Fill;
      form.Controls.Add(cs);
      form.Text = "Chat Settings";
      form.ClientSize = new Size(420, 630);
      form.FormBorderStyle = FormBorderStyle.Fixed3D;
      form.MinimizeBox = false;
      form.MaximizeBox = false;
      form.ShowDialog();
    }
  }
}
