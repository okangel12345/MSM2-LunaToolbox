using LunaLauncheri300;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LunaLauncheri30
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            LoadTreeView();

            Styling.SetTitleBarColor(this.Handle, Color.FromArgb(26, 26, 26));
            Styling.ApplyButtonStyle(this, FlatStyle.Flat, Color.FromArgb(80, 80, 80), Color.FromArgb(34, 34, 34), Color.FromArgb(45, 45, 45), 1);
        }

        private void LoadTreeView()
        {
            FileBrowser.LoadFilesIntoTree(treeView1, LunaRocketPanel.validExtensions, "source");
        }

        private void treeView1_DoubleClick(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode != null)
            {
                string fullPath = treeView1.SelectedNode.FullPath;

                string trimmedPath = fullPath.Substring(fullPath.IndexOf("source") + "source".Length).TrimStart('\\');
                string Args = "-exec -asset " + trimmedPath;

                MainWindow.LaunchEngineTool("AssetEditor.exe", Args);
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode selectedNode = treeView1.SelectedNode;

            if (selectedNode?.Tag is string filePath && File.Exists(filePath))
            {
                try
                {
                    label2.Text = "Read only preview: " + filePath;
                    label2.Visible = true;
                    string fileContent = File.ReadAllText(filePath);

                    richTextBox1.Text = fileContent;
                    richTextBox1.Visible = true;
                    btn_OpenAsset.Visible = true;
                    pictureBox2.Visible = true;
                }
                catch (Exception ex)
                {
                    // Handle errors (e.g., file access issues)
                    MessageBox.Show($"Error reading file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // If no file path is found, clear the richTextBox1
                label2.Visible = false;
                richTextBox1.Clear();
                richTextBox1.Visible = false;
                btn_OpenAsset.Visible = false;
                pictureBox2.Visible= false;
            }
        }

        private void treeView1_Click(object sender, EventArgs e)
        {

        }

        private void btn_RefreshTree_Click(object sender, EventArgs e)
        {
            LoadTreeView();
        }

        private void btn_OpenAsset_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode != null)
            {
                string fullPath = treeView1.SelectedNode.FullPath;

                string trimmedPath = fullPath.Substring(fullPath.IndexOf("source") + "source".Length).TrimStart('\\');
                string Args = "-exec -asset " + trimmedPath;

                MainWindow.LaunchEngineTool("AssetEditor.exe", Args);
            }
        }
    }
}
