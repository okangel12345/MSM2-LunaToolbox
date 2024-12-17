using System;
using System.Diagnostics;
using System.IO;
using System.Media;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using LunaLauncheri30;
using LunaLauncheri30.HelpForms;
using static System.Resources.ResXFileRef;
using static System.Windows.Forms.DataFormats;

namespace LunaLauncheri300
{
    public partial class MainWindow : Form
    {

        public MainWindow()
        {
            InitializeComponent();
            LoadPanel(Home);
            LoadAllPanels();

            LoadQuickLaunchFields(false);


            timer1.Interval = 2000;
            timer1.Start();

            ApplyDarkTheme();
            Styling.SetTitleBarColor(this.Handle, Color.FromArgb(26, 26, 26));
            Styling.ApplyButtonStyle(this, FlatStyle.Flat, Color.FromArgb(80, 80, 80), Color.FromArgb(34, 34, 34), Color.FromArgb(42, 42, 42), 1);
        }

        private void ApplyDarkTheme()
        {
            // MenuStrip styling
            if (this.MainMenuStrip != null)
            {
                this.MainMenuStrip.BackColor = Color.FromArgb(25, 25, 25); // MenuStrip background set to black
                this.MainMenuStrip.ForeColor = Color.White;

                // Set custom renderer to ensure black border and full control styling
                this.MainMenuStrip.Renderer = new CustomToolStripRenderer();

                foreach (ToolStripMenuItem menuItem in this.MainMenuStrip.Items)
                {
                    ApplyMenuItemStyle(menuItem);
                }
            }
        }
        private void ApplyMenuItemStyle(ToolStripMenuItem menuItem)
        {
            menuItem.BackColor = Color.FromArgb(0, 0, 0); // Menu items background set to black
            menuItem.ForeColor = Color.White;

            foreach (ToolStripItem subItem in menuItem.DropDownItems)
            {
                subItem.BackColor = Color.FromArgb(25, 25, 25); // Submenu items background set to black
                subItem.ForeColor = Color.White;
            }
        }
        public class CustomToolStripRenderer : ToolStripProfessionalRenderer
        {
            protected override void OnRenderToolStripBorder(ToolStripRenderEventArgs e)
            {
                // Draw a black border explicitly
                using (Pen blackPen = new Pen(Color.FromArgb(24, 24, 24)))
                {
                    e.Graphics.DrawRectangle(blackPen, new Rectangle(Point.Empty, e.ToolStrip.Size - new Size(1, 1)));
                }
            }

            protected override void OnRenderToolStripBackground(ToolStripRenderEventArgs e)
            {
                // Ensure the background is fully black
                using (SolidBrush blackBrush = new SolidBrush(Color.FromArgb(18, 18, 18)))
                {
                    e.Graphics.FillRectangle(blackBrush, e.AffectedBounds);
                }
            }
            protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
            {
                // Set menu item background explicitly
                Rectangle rect = new Rectangle(Point.Empty, e.Item.Size);
                using (SolidBrush blackBrush = new SolidBrush(Color.FromArgb(18, 18, 18)))
                {
                    e.Graphics.FillRectangle(blackBrush, rect);
                }

                // Highlight selected or hovered items with a gray shade
                if (e.Item.Selected)
                {
                    using (SolidBrush grayBrush = new SolidBrush(Color.FromArgb(119, 204, 221)))
                    {
                        e.Graphics.FillRectangle(grayBrush, rect);
                    }
                    e.Item.ForeColor = Color.Black;
                }
                else
                {
                    e.Item.ForeColor = Color.White;
                }
            }
        }


        private void StopWindow(Process Process)
        {
            if (Process != null && !Process.HasExited)
            {
                // Kill the process
                Process.Kill();
                Process.WaitForExit();  // Optionally wait for the process to exit
                Process = null;  // Clear the process object
            }
        }

        private void EmbedVault_Click(object sender, EventArgs e)
        {

        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            string OSProcessName = "Overstrike";

            // Find the process by name
            Process targetProcessOS = Process.GetProcessesByName(OSProcessName).FirstOrDefault();
            targetProcessOS.Kill();
        }

        // Check for Luna Process
        private bool IsLunaRunning = false;
        private void timer1_Tick(object sender, EventArgs e)
        {
            // Check for "LunaServer.exe" process
            var processes = Process.GetProcessesByName("LunaServer");

            // If process exists, set status label to "Running"
            if (processes.Length > 0)
            {
                toolStripStatusLabel1.Text = "Luna Server Status: Running";
                statusCheckingToolStripMenuItem.Text = "Status: Running";
                launchLunaServerToolStripMenuItem.Visible = false;
                closeLunaServerToolStripMenuItem.Visible = true;
                IsLunaRunning = true;
            }
            else
            {
                toolStripStatusLabel1.Text = "Luna Server Status: Not running";
                statusCheckingToolStripMenuItem.Text = "Status: Not running";
                launchLunaServerToolStripMenuItem.Visible = true;
                closeLunaServerToolStripMenuItem.Visible = false;
                IsLunaRunning = false;
            }
        }

        // Launchers
        public static void LaunchEngineTool(string ProgramName, string Args)
        {
            try
            {
                string programDirectory = Path.Combine(Environment.GetEnvironmentVariable("IG_ROOT"), "i30", "devel", "code", "Output");
                string programPath = Path.Combine(programDirectory, ProgramName);

                if (!File.Exists(programPath))
                {
                    MessageBox.Show("The specified program does not exist.");
                    return;
                }


                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    FileName = programPath,
                    Arguments = Args,
                    WorkingDirectory = programDirectory,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };

                Process.Start(startInfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error launching program: {ex.Message}");
            }
        }

        private void LaunchModdingTool(string ProgramName, string ProgramFolder, string Args)
        {
            try
            {
                string programDirectory = Path.Combine(Environment.GetEnvironmentVariable("IG_ROOT"), "i30", "Utilities", ProgramFolder);
                string programPath = Path.Combine(programDirectory, ProgramName);

                if (!File.Exists(programPath))
                {
                    MessageBox.Show("The specified program does not exist.");
                    return;
                }

                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    FileName = programPath,
                    Arguments = Args,
                    WorkingDirectory = programDirectory,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };

                Process.Start(startInfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error launching program: {ex.Message}");
            }
        }
        private void launchLunaServerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IsLunaRunning = true;
            LaunchEngineTool("LunaServer.exe", "");
        }

        private void vaultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LaunchEngineTool("Vault.exe", "-exec");
        }

        private void orbitAssetEditorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LaunchEngineTool("AssetEditor.exe", "-exec");
        }

        private void bulkAssetEditorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LaunchEngineTool("BulkAssetEditor.exe", "-exec");
        }

        private void insomniacPromptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LaunchEngineTool("InsomniacPrompt.exe", "-exec");
        }

        private void toolsHubToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LaunchEngineTool("ToolsHub.exe", "-exec");
        }

        private void levelEditorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LaunchEngineTool("LevelEditor.exe", "-exec");
        }

        private void closeLunaServerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SystemSounds.Asterisk.Play();
            try
            {
                DialogResult result = MessageBox.Show("Are you sure you want to shut down Luna Server?",
                                                      "Confirm Shutdown",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    Process[] processes = Process.GetProcessesByName("LunaServer");

                    // If the process is found, kill it
                    if (processes.Length > 0)
                    {
                        foreach (Process process in processes)
                        {
                            process.Kill();
                        }

                        MessageBox.Show("Luna Server has been shut down.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error shutting down LunaServer.exe: {ex.Message}");
            }
        }

        private void moddingToolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LaunchModdingTool("ModdingTool.exe", "ModdingTool", "");
        }

        private void overstrikeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LaunchModdingTool("Overstrike.exe", "Overstrike", "");
        }

        private void spideyTextureScalerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LaunchModdingTool("SpideyTextureScaler.exe", "SpideyTextureScaler", "");
        }

        // Panels


        ModdingToolPanel ModdingToolPanel = new ModdingToolPanel();
        LunaRocketPanel LunaRocketPanel = new LunaRocketPanel();
        OverstrikePanel OverstrikePanel = new OverstrikePanel();
        Home Home = new Home();
        AtmosphereTool atmosphereTool = new AtmosphereTool();
        ModelTool modelTool = new ModelTool();
        GameIntegration GameIntegration = new GameIntegration();

        // Load all panels to prevent slow workflow
        private void LoadAllPanels()
        {
            LoadFirstPanel(ModdingToolPanel);
            LoadFirstPanel(LunaRocketPanel);
            LoadFirstPanel(OverstrikePanel);
            LoadFirstPanel(atmosphereTool);
            LoadFirstPanel(modelTool);
            LoadFirstPanel(GameIntegration);
        }

        private void LoadFirstPanel(Form Form)
        {
            Form.TopLevel = false;
            Form.FormBorderStyle = FormBorderStyle.None;  // Optional: removes the border
            Form.Dock = DockStyle.Fill;

            Form.Show();
        }

        private void LoadPanel(Form Form)
        {
            Main_Panel.Controls.Clear();
            Form.TopLevel = false;
            Form.FormBorderStyle = FormBorderStyle.None;  // Optional: removes the border
            Form.Dock = DockStyle.Fill;

            Main_Panel.Controls.Add(Form);

            // Show Form1
            Form.Show();
        }

        private void LoadExt(Form Form)
        {

            Form.TopLevel = true;
            Form.Show();
        }

        private void btn_LoadLunaRocketPanel_Click(object sender, EventArgs e)
        {
            LoadPanel(LunaRocketPanel);
        }

        private void btn_ModdingToolPanel_Click(object sender, EventArgs e)
        {
            LoadPanel(ModdingToolPanel);
        }

        private void btn_OverstrikePanel_Click(object sender, EventArgs e)
        {
            LoadPanel(OverstrikePanel);
        }

        private void btn_Home_Click(object sender, EventArgs e)
        {
            LoadPanel(Home);
        }

        private void btn_AtmospherePanel_Click(object sender, EventArgs e)
        {
            LoadPanel(atmosphereTool);
        }

        private void btn_ModelToolPanel_Click(object sender, EventArgs e)
        {
            LoadPanel(modelTool);
        }


        private void btn_LoadGameIntegrationPanel_Click(object sender, EventArgs e)
        {
            LoadPanel(GameIntegration);
        }

        private void hashToolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HashTool HashTool = new HashTool();
            LoadExt(HashTool);
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InsomniacEngineHelp InsomniacEngineHelp = new InsomniacEngineHelp();
            LoadExt(InsomniacEngineHelp);
        }

        private void lunaRocketCompilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LunaRocketHelp LunaRocketHelp = new LunaRocketHelp();
            LoadExt(LunaRocketHelp);
        }

        private void assetWizardToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            LaunchEngineTool("AssetWizard.exe", "");
        }

        private CustomQuickLaunch customQuickLaunch;

        public void LoadQuickLaunchFields(bool LoadForm)
        {
            customQuickLaunch = new CustomQuickLaunch();

            if (LoadForm)
            {
                LoadExt(customQuickLaunch);
            }


            item1ToolStripMenuItem.Visible = customQuickLaunch.Enabled1;
            item2ToolStripMenuItem.Visible = customQuickLaunch.Enabled2;
            item3ToolStripMenuItem.Visible = customQuickLaunch.Enabled3;
            item4ToolStripMenuItem.Visible = customQuickLaunch.Enabled4;
            item5ToolStripMenuItem.Visible = customQuickLaunch.Enabled5;
            item6ToolStripMenuItem.Visible = customQuickLaunch.Enabled6;
            item7ToolStripMenuItem.Visible = customQuickLaunch.Enabled7;
            item8ToolStripMenuItem.Visible = customQuickLaunch.Enabled8;
            item9ToolStripMenuItem.Visible = customQuickLaunch.Enabled9;
            item10ToolStripMenuItem.Visible = customQuickLaunch.Enabled10;

            // Assuming the IconPaths are properties like customQuickLaunch.IconPath_1, IconPath_2, etc.
            string[] iconPaths = {
    customQuickLaunch.IconPath_1.Text,
    customQuickLaunch.IconPath_2.Text,
    customQuickLaunch.IconPath_3.Text,
    customQuickLaunch.IconPath_4.Text,
    customQuickLaunch.IconPath_5.Text,
    customQuickLaunch.IconPath_6.Text,
    customQuickLaunch.IconPath_7.Text,
    customQuickLaunch.IconPath_8.Text,
    customQuickLaunch.IconPath_9.Text,
    customQuickLaunch.IconPath_10.Text
};

            // Assuming the ToolStripMenuItems are item1ToolStripMenuItem, item2ToolStripMenuItem, etc.
            ToolStripMenuItem[] menuItems = {
    item1ToolStripMenuItem,
    item2ToolStripMenuItem,
    item3ToolStripMenuItem,
    item4ToolStripMenuItem,
    item5ToolStripMenuItem,
    item6ToolStripMenuItem,
    item7ToolStripMenuItem,
    item8ToolStripMenuItem,
    item9ToolStripMenuItem,
    item10ToolStripMenuItem
};

            // Loop through each icon path and corresponding menu item
            for (int i = 0; i < iconPaths.Length; i++)
            {
                try
                {
                    // Check if the path is not empty, the file exists, and the file is an actual file (not a directory)
                    if (!string.IsNullOrEmpty(iconPaths[i]) && File.Exists(iconPaths[i]) && !Directory.Exists(iconPaths[i]))
                    {
                        // Try loading the image and assign it to the menu item
                        try
                        {
                            menuItems[i].Image = Image.FromFile(iconPaths[i]);
                        }
                        catch (Exception ex)
                        {
                            // Handle any errors in loading the image (e.g., unsupported format)
                            Console.WriteLine($"Error loading image from {iconPaths[i]}: {ex.Message}");
                            menuItems[i].Image = null;
                        }
                    }
                    else
                    {
                        // Set image to null if the path is empty, the file doesn't exist, or it's a directory
                        menuItems[i].Image = null;
                    }
                }
                catch (Exception ex)
                {
                    // Catch any other unexpected errors (e.g., file access issues)
                    Console.WriteLine($"Error with file path {iconPaths[i]}: {ex.Message}");
                    menuItems[i].Image = null;
                }
            }


            item1ToolStripMenuItem.Text = customQuickLaunch.FieldName1Text;
            item2ToolStripMenuItem.Text = customQuickLaunch.FieldName2Text;
            item3ToolStripMenuItem.Text = customQuickLaunch.FieldName3Text;
            item4ToolStripMenuItem.Text = customQuickLaunch.FieldName4Text;
            item5ToolStripMenuItem.Text = customQuickLaunch.FieldName5Text;
            item6ToolStripMenuItem.Text = customQuickLaunch.FieldName6Text;
            item7ToolStripMenuItem.Text = customQuickLaunch.FieldName7Text;
            item8ToolStripMenuItem.Text = customQuickLaunch.FieldName8Text;
            item9ToolStripMenuItem.Text = customQuickLaunch.FieldName9Text;
            item10ToolStripMenuItem.Text = customQuickLaunch.FieldName10Text;
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadQuickLaunchFields(false);
        }

        private void customizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadQuickLaunchFields(true);
        }

        private void LaunchQuick(string Path)
        {
            try
            {
                if (string.IsNullOrEmpty(Path))
                {
                    MessageBox.Show("Path is null or empty.");
                    return;
                }
                Process.Start(Path);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error launching program: {ex.Message}");
            }
        }

        private void item1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            customQuickLaunch = new CustomQuickLaunch();
            LaunchQuick(customQuickLaunch.FieldPath1Text);
        }

        private void item2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            customQuickLaunch = new CustomQuickLaunch();
            LaunchQuick(customQuickLaunch.FieldPath2Text);
        }

        private void item3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            customQuickLaunch = new CustomQuickLaunch();
            LaunchQuick(customQuickLaunch.FieldPath3Text);
        }

        private void item4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            customQuickLaunch = new CustomQuickLaunch();
            LaunchQuick(customQuickLaunch.FieldPath4Text);
        }

        private void item5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            customQuickLaunch = new CustomQuickLaunch();
            LaunchQuick(customQuickLaunch.FieldPath5Text);
        }

        private void item6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            customQuickLaunch = new CustomQuickLaunch();
            LaunchQuick(customQuickLaunch.FieldPath6Text);
        }

        private void item7ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            customQuickLaunch = new CustomQuickLaunch();
            LaunchQuick(customQuickLaunch.FieldPath7Text);
        }

        private void item8ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            customQuickLaunch = new CustomQuickLaunch();
            LaunchQuick(customQuickLaunch.FieldPath8Text);
        }

        private void item9ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            customQuickLaunch = new CustomQuickLaunch();
            LaunchQuick(customQuickLaunch.FieldPath9Text);
        }

        private void item10ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            customQuickLaunch = new CustomQuickLaunch();
            LaunchQuick(customQuickLaunch.FieldPath2Text);
        }

        private void checkBox_Experiments_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Experiments.Checked == true)
            {
                pictureBox7.Visible = true;
                btn_LoadGameIntegrationPanel.Visible = true;
            }
            else
            {
                pictureBox7.Visible = false;
                btn_LoadGameIntegrationPanel.Visible = false;
            }
        }
    }
}
