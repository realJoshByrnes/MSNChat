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

    public MDIChatClient()
    {
      InitializeComponent();
      this.MdiChildActivate += MDIChatClient_MdiChildActivate;
    }

    // The following Dictionary and Method is purely for the TreeView.
    private Dictionary<Form, TreeNode> treeNodes = new();

    private void MDIChatClient_MdiChildActivate(object? sender, EventArgs e)
    {
      if (this.ActiveMdiChild != null)
      {
        if (treeNodes.TryGetValue(this.ActiveMdiChild, out TreeNode? value)) // Existing child form.
        {
          treeView.SelectedNode = value;
        }
        else // New child form.
        {
          TreeNode rootNode = new TreeNode(this.ActiveMdiChild.Text);
          treeView.Nodes.Add(rootNode);
          treeView.SelectedNode = rootNode;
          treeNodes.Add(this.ActiveMdiChild, rootNode);
          this.ActiveMdiChild.FormClosed += (s, e) =>
          {
            rootNode.Remove();
            treeNodes.Remove(this.ActiveMdiChild);
          };
        }
      }
      else // No active child form.
      {
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
  }
}
