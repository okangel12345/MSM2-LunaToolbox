using LunaLauncheri300;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace LunaLauncheri30
{
    public partial class LunaRocketPanel : Form
    {
        public LunaRocketPanel()
        {
            InitializeComponent();

            FileBrowser.LoadFilesIntoTree(Tree_SourceFiles, validExtensions, "source");

            richTextBox1.Paint += RichTextBox1_Paint;

            Styling.SetTitleBarColor(this.Handle, Color.FromArgb(26, 26, 26));
            Styling.ApplyButtonStyle(this, FlatStyle.Flat, Color.FromArgb(80, 80, 80), Color.FromArgb(34, 34, 34), Color.FromArgb(45, 45, 45), 1);
        }

        private void RichTextBox1_Paint(object sender, PaintEventArgs e)
        {
            // Create a rectangle around the RichTextBox for the border
            Rectangle borderRect = richTextBox1.ClientRectangle;

            // Optional: Adjust the rectangle to add space for the border thickness
            int borderThickness = 5;  // Set the thickness of the border
            borderRect.Inflate(-borderThickness, -borderThickness);  // Shrink the rectangle to make room for the border

            // Create a LinearGradientBrush for the gradient border
            using (LinearGradientBrush brush = new LinearGradientBrush(borderRect, Color.Blue, Color.Red, 45f))
            {
                // Draw the gradient border around the RichTextBox
                e.Graphics.FillRectangle(brush, borderRect);
            }

            // Draw the RichTextBox content (text, etc.)
            // Make sure to avoid the gradient covering the text
            richTextBox1.Invalidate();  // Invalidate the control to ensure it repaints correctly
        }

        public static readonly List<string> validExtensions = new List<string>
        {
            ".actor",
            ".config",
            ".material",
            ".materialgraph",
            ".nodegraph",
            ".texture"
        };

        private void btn_SearchTree_Click(object sender, EventArgs e)
        {
            FileBrowser.SearchTreeView(Tree_SourceFiles, textBox_SearchTree);
        }

        private void textBox_SearchTree_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;

                FileBrowser.SearchTreeView(Tree_SourceFiles, textBox_SearchTree);
            }
        }

        private void btn_RefreshTree_Click(object sender, EventArgs e)
        {
            FileBrowser.LoadFilesIntoTree(Tree_SourceFiles, validExtensions, "source");
        }

        private void btn_InputAsset_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Assets (*.actor;*.config;*.material;*.materialgraph;*.nodegraph;*.texture)|*.actor;*.config;*.material;*.materialgraph;*.nodegraph;*.texture";
            openFileDialog.Title = "Select an Asset File";
            openFileDialog.Multiselect = false;

            string igRoot = Environment.GetEnvironmentVariable("IG_ROOT");
            if (string.IsNullOrEmpty(igRoot))
            {
                MessageBox.Show("The IG_ROOT environment variable is not set.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string sourceFolderPath = Path.Combine(igRoot, "i30", "devel", "assets", "source");
            openFileDialog.InitialDirectory = sourceFolderPath;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog.FileName;

                if (selectedFilePath.StartsWith(sourceFolderPath, StringComparison.OrdinalIgnoreCase))
                {
                    textBox_Input.Text = selectedFilePath;

                    string outputFilePath = selectedFilePath.Replace("assets/source", "assets/built");

                    string fileName = Path.GetFileNameWithoutExtension(selectedFilePath);
                    string extensionName = Path.GetExtension(selectedFilePath).TrimStart('.');

                    string modifiedFileName = fileName.Replace('.', '_');

                    outputFilePath = Path.Combine(Path.GetDirectoryName(outputFilePath), $"{modifiedFileName}_{extensionName}");

                    textBox_Output.Text = outputFilePath;
                }
                else
                {
                    MessageBox.Show("The selected file must be located within the 'assets/source' directory.", "Invalid File", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btn_OpenFolder_Click(object sender, EventArgs e)
        {
            string folderPath = textBox_Output.Text;
            if (Directory.Exists(folderPath))
            {
                // Open folder using ShellExecute without creating new explorer instances
                ShellExecute(IntPtr.Zero, "open", folderPath, null, null, 5);
            }
            else
            {
                MessageBox.Show("The specified folder does not exist. Compile the file first.", "Luna Launcher", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        [DllImport("shell32.dll", EntryPoint = "ShellExecute")]
        private static extern int ShellExecute(IntPtr hwnd, string lpOperation, string lpFile, string lpParameters, string lpDirectory, int nShowCmd);

        private void Tree_SourceFiles_DoubleClick(object sender, EventArgs e)
        {
            TreeNode selectedNode = Tree_SourceFiles.SelectedNode;


            if (selectedNode != null)
            {
                string selectedFilePath = selectedNode.FullPath;

                string fileExtension = Path.GetExtension(selectedFilePath).ToLower();
                if (validExtensions.Contains(fileExtension))
                {
                    // Display the original file path in textBox_Input


                    string igRoot = Environment.GetEnvironmentVariable("IG_ROOT");
                    if (string.IsNullOrEmpty(igRoot))
                    {
                        MessageBox.Show("The IG_ROOT environment variable is not set.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    string sourceFolderPath = Path.Combine(igRoot, "i30", "devel", "assets");

                    // Modify the path for textBox_Output
                    string outputFilePath = selectedFilePath.Replace("source", "built");

                    // Get the file name and replace dots with underscores, then add the extension name
                    string fileName = Path.GetFileNameWithoutExtension(selectedFilePath);
                    string extensionName = Path.GetExtension(selectedFilePath).TrimStart('.');

                    // Replace all dots with underscores in the file name
                    string modifiedFileName = fileName.Replace('.', '_');

                    // Create the final output path
                    outputFilePath = Path.Combine(sourceFolderPath, Path.GetDirectoryName(outputFilePath), $"{modifiedFileName}_{extensionName}");
                    string inputPath = Path.Combine(sourceFolderPath, selectedFilePath);

                    textBox_Input.Text = inputPath;
                    // Display the modified path in textBox_Output
                    textBox_Output.Text = outputFilePath;
                }
                else
                {
                    //MessageBox.Show("The selected file does not have a valid extension or is a folder.", "Luna Launcher - Select an asset", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void checkBox_Stage_CheckedChanged(object sender, EventArgs e)
        {
            EnableStageFields();
        }

        private void EnableStageFields()
        {
            Color Color = Color.FromArgb(22, 22, 22);
            Color LabelColor = Color.FromArgb(190, 190, 190);
            BorderStyle Border = BorderStyle.FixedSingle;
            bool EnabledBool = true;
            string selectedFilePath = textBox_Output.Text;

            if (checkBox_Stage.Checked && checkBox_Stage.Enabled)
            {
                Color = Color;
                Border = Border;
                EnabledBool = EnabledBool;
                LabelColor = LabelColor;
            }
            else
            {
                Color = Color.FromArgb(12, 12, 12);
                Border = BorderStyle.None;
                EnabledBool = false;
                LabelColor = Color.FromArgb(120, 120, 120);

                checkBox_Stage.Checked = false;
            }

            textBox_StageName.Enabled = EnabledBool;
            textBox_StageAuthor.Enabled = EnabledBool;
            textBox_StageGame.Enabled = EnabledBool;
            textBox_StagePath.Enabled = EnabledBool;

            textBox_StageName.BackColor = Color;
            textBox_StageName.BorderStyle = Border;
            textBox_StageAuthor.BackColor = Color;
            textBox_StageAuthor.BorderStyle = Border;
            textBox_StageGame.BackColor = Color;
            textBox_StageGame.BorderStyle = Border;
            textBox_StagePath.BackColor = Color;
            textBox_StagePath.BorderStyle = Border;


            label6.ForeColor = LabelColor;
            label5.ForeColor = LabelColor;
            label7.ForeColor = LabelColor;
            label8.ForeColor = LabelColor;
        }

        private void btn_Compile_Click(object sender, EventArgs e)
        {
            LunaRocketLogic.CompileAsset(textBox_Input.Text, textBox_Output.Text, checkBox_Header.Checked, checkBox_Cleanup.Checked, checkBox_Stage.Checked, textBox_StageName.Text, textBox_StageAuthor.Text, textBox_StageGame.Text, textBox_StagePath.Text, richTextBox1);
        }

        private void checkBox_Header_CheckedChanged(object sender, EventArgs e)
        {
            UpdateStageCheckboxState();
        }

        private void checkBox_Cleanup_CheckedChanged(object sender, EventArgs e)
        {
            UpdateStageCheckboxState();
        }

        private void UpdateStageCheckboxState()
        {
            // Enable checkBox_Stage only if both checkBox_Header and checkBox_Cleanup are checked
            checkBox_Stage.Enabled = checkBox_Header.Checked && checkBox_Cleanup.Checked;
            EnableStageFields();
        }

        private void btn_LogCopy_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(richTextBox1.Text))
            {
                Clipboard.SetText(richTextBox1.Text);
            }
        }

        private void btn_ClearLog_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = string.Empty;
        }

        private void btn_HelpStage_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Swap header: Gives the compiled asset an universal header so it can be added as a new file." +
                "\n\nCleanup .built files: Removes leftover folders after compiling." +
                "\n\nPack as .stage: requires both previous options to be enabled. It'll automatically pack the output file as a stage file." +
                " Keep in mind that it'll use the custom path in 'New file path', it must also start with 0/ - otherwise the file won't be saved.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
