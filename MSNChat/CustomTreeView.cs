namespace MSNChat
{
  /*
   * CustomTreeView is a custom TreeView control that draws the selected node with the system highlight color and text color
   * when the TreeView does not have focus. This is necessary because the default TreeView control does not draw the selected
   * node well when the TreeView does not have focus, which can make it difficult for users to see which node is selected.
   */
  internal class CustomTreeView : TreeView
  {
    public CustomTreeView()
    {
      // Enable owner drawing of the TreeView nodes.
      this.DrawMode = TreeViewDrawMode.Normal;
    }

    protected override void OnDrawNode(DrawTreeNodeEventArgs e)
    {
      if (!this.Focused && e.Node == this.SelectedNode)
      { // Case: Node selected but TreeView not focused
        // Draw the selected node with the system highlight color and text color.
        e.Graphics.FillRectangle(SystemBrushes.Highlight, e.Bounds);
        TextRenderer.DrawText(e.Graphics, e.Node.Text, this.Font, e.Bounds, SystemColors.HighlightText, TextFormatFlags.GlyphOverhangPadding);
        e.DrawDefault = false;
      }
      else
      {
        // Draw the node using the default drawing method.
        e.DrawDefault = true;
      }
    }
  }
}
