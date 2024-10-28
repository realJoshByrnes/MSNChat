using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MSNChat
{
  public partial class MDIChatClient : Form
  {
    private int childFormNumber = 0;
    private Dictionary<Form, TreeNode> treeNodes = new();

    public MDIChatClient()
    {
      InitializeComponent();
      // Handle the MdiChildActivate event to update the TreeView.
      this.MdiChildActivate += MDIChatClient_MdiChildActivate;
    }

    // This method updates the TreeView when a child form is activated or closed.
    private void MDIChatClient_MdiChildActivate(object? sender, EventArgs e)
    {
      if (this.ActiveMdiChild != null)
      {
        if (treeNodes.TryGetValue(this.ActiveMdiChild, out TreeNode? value))
        { // Case: Existing Form Activated
          // Select the TreeNode in the TreeView.
          treeView.SelectedNode = value;
        }
        else
        { // Case: New Form Created
          // Create a new TreeNode
          TreeNode rootNode = new TreeNode(this.ActiveMdiChild.Text);
          // Associate the TreeNode with the child form.
          rootNode.Tag = this.ActiveMdiChild;
          // Add the TreeNode to the TreeView.
          treeView.Nodes.Add(rootNode);
          // Select the TreeNode in the TreeView.
          treeView.SelectedNode = rootNode;

          // Add the TreeNode to the Dictionary.
          treeNodes.Add(this.ActiveMdiChild, rootNode);
          // Update the TreeNode when the child form's Text changes.
          this.ActiveMdiChild.TextChanged += (s, e) => rootNode.Text = this.ActiveMdiChild.Text;
          // Remove the TreeNode when the child form is closed.
          this.ActiveMdiChild.FormClosed += (s, e) =>
          {
            // Remove the TreeNode from the TreeView.
            rootNode.Remove();
            // Remove the TreeNode from the Dictionary.
            treeNodes.Remove(this.ActiveMdiChild);
          };
        }
      }
      else
      { // Case: No Form Activated
        // Deselect the TreeNode in the TreeView.
        treeView.SelectedNode = null;
      }
    }

    private void ShowNewForm(object sender, EventArgs e)
    {
      Form childForm = new Form();
      childForm.MdiParent = this;
      childForm.Text = "Window " + childFormNumber++;
      childForm.Show();
    }

    private void OpenFile(object sender, EventArgs e)
    {
      OpenFileDialog openFileDialog = new OpenFileDialog();
      openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
      openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
      if (openFileDialog.ShowDialog(this) == DialogResult.OK)
      {
        string FileName = openFileDialog.FileName;
      }
    }

    private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
    {
      SaveFileDialog saveFileDialog = new SaveFileDialog();
      saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
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

    private void CutToolStripMenuItem_Click(object sender, EventArgs e)
    {
    }

    private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
    {
    }

    private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
    {
    }

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

    private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
    {
      if (e.Node != null && e.Node.Tag is Form)
        ((Form)e.Node.Tag).Focus();
    }
  }
}
