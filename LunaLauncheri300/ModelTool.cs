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
using LunaLauncheri30.DAT1;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LunaLauncheri30
{
    public partial class ModelTool : Form
    {
        public ModelTool()
        {
            InitializeComponent();

            textBox_InGameModelPath.Text = "";
            Hash();

            DataContext = this;

            Styling.SetTitleBarColor(this.Handle, Color.FromArgb(26, 26, 26));
            Styling.ApplyButtonStyle(this, FlatStyle.Flat, Color.FromArgb(80, 80, 80), Color.FromArgb(34, 34, 34), Color.FromArgb(45, 45, 45), 1);
        }

        private void Check_Hash_CheckedChanged(object sender, EventArgs e)
        {
            if (Check_Hash.Checked)
            {
                label3.ForeColor = Color.FromArgb(160, 160, 160);
                label2.ForeColor = Color.FromArgb(120, 120, 120);
                textBox_Hash.Enabled = true;
                textBox_Hash.BackColor = Color.FromArgb(22, 22, 22);
                textBox_InGameModelPath.Enabled = false;
                textBox_InGameModelPath.BackColor = Color.FromArgb(32, 32, 32);
            }
            else
            {
                label3.ForeColor = Color.FromArgb(120, 120, 120);
                label2.ForeColor = Color.FromArgb(160, 160, 160);
                textBox_Hash.Enabled = false;
                textBox_Hash.BackColor = Color.FromArgb(32, 32, 32);
                textBox_InGameModelPath.Enabled = true;
                textBox_InGameModelPath.BackColor = Color.FromArgb(22, 22, 22);
            }
        }

        protected bool _normalizeInput = true;
        public bool NormalizeInput
        {
            get => _normalizeInput;
            set
            {
                _normalizeInput = value;
                Hash();
            }
        }
        private void ProcessModelPath()
        {
            Hash();
        }

        private void Hash()
        {
            var input = textBox_InGameModelPath.Text;
            var crc64 = CRC64.Hash(input, true);
            textBox_Hash.Text = $"{crc64:X016}";
        }


        private void btn_ExtractModel_Click(object sender, EventArgs e)
        {
            // Define the path to the executable
            string igRoot = Environment.GetEnvironmentVariable("IG_ROOT"); // Get the IG_ROOT environment variable
            string executablePath = Path.Combine(igRoot, @"i30\Utilities\ModelTool\PS5\spiderman2.exe");

            // Check if the executable exists
            if (!File.Exists(executablePath))
            {
                MessageBox.Show($"The executable was not found at:\n{executablePath}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Get the input values from the text boxes
            if (!Check_Hash.Checked)
            {
                ProcessModelPath();
            }

            string hash = textBox_Hash.Text.Trim();

            // Open a SaveFileDialog to let the user select where to save the file
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Ascii File (*.ascii)|*.ascii"; // Default to .model extension
            saveFileDialog.DefaultExt = "*.ascii"; // Set default extension
            saveFileDialog.InitialDirectory = Path.Combine(igRoot, @"i30\Utilities\ModelTool\PS5"); // Set initial directory

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = saveFileDialog.FileName;

                // Ensure the selected path has a .model extension
                if (!selectedFilePath.EndsWith(".ascii", StringComparison.OrdinalIgnoreCase))
                {
                    selectedFilePath += ".ascii";
                }

                string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(selectedFilePath);


                // Build the arguments with the hash and the selected file name
                string arguments = $"{hash} {fileNameWithoutExtension}";

                // Execute the command
                try
                {
                    Process process = new Process();
                    process.StartInfo.FileName = executablePath;
                    process.StartInfo.Arguments = arguments;
                    process.StartInfo.WorkingDirectory = Path.GetDirectoryName(executablePath); // Set the working directory
                    process.StartInfo.CreateNoWindow = true; // Hide the console window

                    process.Start();
                    process.WaitForExit(); // Wait for the process to complete before proceeding

                    // Move the file to the user's selected location
                    string destinationFilePath = selectedFilePath;

                    // Assuming the file was created in the Utilities\ModelTool\PS5 directory (you may need to adjust based on the actual behavior)
                    string sourceFilePath = Path.Combine(igRoot, @"i30\Utilities\ModelTool\PS5", Path.GetFileName(selectedFilePath));

                    // Move the model file if it exists, replace it if already exists
                    if (File.Exists(sourceFilePath))
                    {
                        // Delete the destination file if it already exists
                        if (sourceFilePath != destinationFilePath)
                        {
                            if (File.Exists(destinationFilePath))
                            {
                                File.Delete(destinationFilePath);
                            }
                        }

                        File.Move(sourceFilePath, destinationFilePath);
                    }
                    else
                    {
                        richTextBox2.Text = $"The model file was not created at the expected location: {sourceFilePath}";
                        return;
                    }

                    // Move the _materials.txt file
                    string materialsFileName = fileNameWithoutExtension + "_materials.txt";
                    string materialsFilePath = Path.Combine(igRoot, @"i30\Utilities\ModelTool\PS5", materialsFileName);

                    if (File.Exists(materialsFilePath))
                    {
                        string destinationMaterialsFilePath = Path.Combine(Path.GetDirectoryName(destinationFilePath), materialsFileName);

                        // Delete the materials file if it already exists
                        if (destinationMaterialsFilePath != materialsFilePath)
                        {
                            if (File.Exists(destinationMaterialsFilePath))
                            {
                                File.Delete(destinationMaterialsFilePath);
                            }
                        }
                        File.Move(materialsFilePath, destinationMaterialsFilePath);
                    }
                    else
                    {
                        richTextBox2.AppendText($"The materials file was not created at the expected location: {materialsFilePath}");
                        return;
                    }

                    // Inform the user of the successful operation
                    richTextBox2.Text = ($"Files successfully saved to: {destinationFilePath}\nMaterials file: {Path.Combine(Path.GetDirectoryName(destinationFilePath), materialsFileName)}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error executing command: {ex.Message}", "Execution Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LoadInjectionPart(string Ext, TextBox textBox)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = $"{Ext} files (*{Ext})|*{Ext}";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                textBox.Text = openFileDialog.FileName;
            }
        }

        private void btn_Ascii_Click(object sender, EventArgs e)
        {
            LoadInjectionPart(".ascii", textBox_Ascii);
        }

        private void btn_Model_Click(object sender, EventArgs e)
        {
            LoadInjectionPart(".model", textBox_Model);
        }

        private void btn_Materials_Click(object sender, EventArgs e)
        {
            LoadInjectionPart(".txt", textBox_Materials);
        }

        private void btn_InjectAscii_Click(object sender, EventArgs e)
        {
            // Get the paths from the text boxes
            string modelPath = textBox_Model.Text.Trim();
            string asciiPath = textBox_Ascii.Text.Trim();
            string materialsPath = textBox_Materials.Text.Trim();

            InjectAsciiMethod(modelPath, asciiPath, materialsPath);
        }

        public void InjectAsciiMethod(string modelPath, string asciiPath, string materialsPath)
        {
            // Validate that the paths are not empty
            if (string.IsNullOrEmpty(modelPath) || string.IsNullOrEmpty(asciiPath))
            {
                MessageBox.Show("Please make sure at least Model and Ascii fields are filled.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Define the path to the executable
            string igRoot = Environment.GetEnvironmentVariable("IG_ROOT");
            if (string.IsNullOrEmpty(igRoot))
            {
                MessageBox.Show("IG_ROOT environment variable is not set.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string executablePath = Path.Combine(igRoot, @"i30\Utilities\ModelTool\spiderman_2_mi_031.exe");

            // Check if the executable exists
            if (!File.Exists(executablePath))
            {
                MessageBox.Show($"The executable was not found at:\n{executablePath}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Build the command arguments
            string arguments = $"\"{modelPath}\" \"{asciiPath}\" \"{materialsPath}\"";

            // Execute the command
            try
            {
                Process process = new Process();
                process.StartInfo.FileName = executablePath;
                process.StartInfo.Arguments = arguments;
                process.StartInfo.WorkingDirectory = Path.GetDirectoryName(executablePath); // Set the working directory
                process.StartInfo.CreateNoWindow = true; // Hide the console window
                process.StartInfo.UseShellExecute = false; // Run without shell execution

                // Redirect standard output and error
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.RedirectStandardError = true;

                // Event handlers to capture output and error
                process.OutputDataReceived += (sender, e) =>
                {
                    if (e.Data != null)
                    {
                        richTextBox1.Invoke(new Action(() =>
                        {
                            richTextBox1.AppendText(e.Data + Environment.NewLine);
                            richTextBox1.ScrollToCaret();
                        }));
                    }
                };

                process.ErrorDataReceived += (sender, e) =>
                {
                    if (e.Data != null)
                    {
                        richTextBox1.Invoke(new Action(() =>
                        {
                            richTextBox1.AppendText("ERROR: " + e.Data + Environment.NewLine);
                            richTextBox1.ScrollToCaret();
                        }));
                    }
                };

                process.Start();

                // Begin asynchronous read of the output and error streams
                process.BeginOutputReadLine();
                process.BeginErrorReadLine();

                // Wait for the process to exit and ensure output has been fully read


                process.WaitForExit(10000);  // 10 seconds timeout for the process to finish

                // Ensure the streams are fully drained if necessary
                if (!process.HasExited)
                {
                    process.Kill();  // Kill the process if it is still running
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error executing command: {ex.Message}", "Execution Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_HelpModel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Model tools were developed by id-daemon, this is just a GUI for them.\n\nInject .ascii to .model -> Inject any custom .ascii to any .model with an optional materials list." +
                "\n\nExtract .model -> Extracts a .model and converts it to .ascii, it requires the hash to work. The program hashes the path automatically." +
                "\n\nBefore extracting a .model, change the path in Utilities\\ModelTool\\PS5\\spider.ini", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
