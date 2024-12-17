using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LunaLauncheri30
{
    public partial class GameIntegration : Form
    {
        // Import necessary WinAPI functions
        [DllImport("user32.dll", SetLastError = true)]
        public static extern bool SetLayeredWindowAttributes(IntPtr hwnd, uint crKey, byte bAlpha, uint dwFlags);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]

        private static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);

        [DllImport("user32.dll", SetLastError = true)]
        private static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);

        [DllImport("user32.dll", SetLastError = true)]
        private static extern int GetWindowLong(IntPtr hWnd, int nIndex);

        const int GWL_STYLE = -16;
        const int WS_CAPTION = 0x00C00000;
        const int WS_THICKFRAME = 0x00040000;

        public GameIntegration()
        {
            InitializeComponent();
            Styling.SetTitleBarColor(this.Handle, Color.FromArgb(26, 26, 26));
            Styling.ApplyButtonStyle(this, FlatStyle.Flat, Color.FromArgb(80, 80, 80), Color.FromArgb(34, 34, 34), Color.FromArgb(45, 45, 45), 1);
        }

        private async Task LoadGameAsync(string launcherPath, string Args, string TargetProcess)
        {
            try
            {

                // Verify the launcher executable exists
                if (!File.Exists(launcherPath))
                {
                    MessageBox.Show($"The launcher executable was not found at: {launcherPath}");
                    return;
                }

                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    FileName = launcherPath,
                    Arguments = Args,
                    WindowStyle = ProcessWindowStyle.Minimized // Start minimized
                };

                // Start the launcher process
                Process launcherProcess = null;
                try
                {
                    launcherProcess = Process.Start(startInfo);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Failed to start the launcher: {ex.Message}");
                    return;
                }

                if (launcherProcess == null)
                {
                    MessageBox.Show("Failed to start the launcher. Process object is null.");
                    return;
                }

                Thread.Sleep(2000);

                // Wait for the target process to appear asynchronously
                Process targetProcess = null;
                int retryCount = 20;
                int delay = 2500;

                for (int i = 0; i < retryCount; i++)
                {
                    targetProcess = Process.GetProcessesByName(TargetProcess).FirstOrDefault();
                    if (targetProcess != null)
                    {
                        break;
                    }
                    await Task.Delay(delay); // Asynchronously wait
                }

                if (targetProcess == null)
                {
                    MessageBox.Show($"Failed to find the target process '{TargetProcess}' after multiple attempts.");
                    return;
                }

                IntPtr targetHandle = targetProcess.MainWindowHandle;
                if (targetHandle == IntPtr.Zero)
                {
                    MessageBox.Show($"Failed to retrieve the target window handle for '{TargetProcess}'.");
                    return;
                }

                // Ensure panel1 is initialized
                if (panel1 == null)
                {
                    MessageBox.Show("Panel is not initialized or does not exist.");
                    return;
                }

                // Reparent the target window to panel1
                SetParent(targetHandle, panel1.Handle);

                // Remove the title bar and resizable border
                int style = GetWindowLong(targetHandle, GWL_STYLE);
                style &= ~(WS_CAPTION | WS_THICKFRAME);
                SetWindowLong(targetHandle, GWL_STYLE, style);

                // Resize the embedded window to fill panel1
                panel1.Resize += (sender, e) =>
                {
                    MoveWindow(targetHandle, 0, 0, panel1.Width, panel1.Height, true);
                };
                MoveWindow(targetHandle, 0, 0, panel1.Width, panel1.Height, true);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading game: {ex.Message}");
            }
        }


        [DllImport("user32.dll", SetLastError = true)]
        private static extern bool MoveWindow(IntPtr hWnd, int X, int Y, int nWidth, int nHeight, bool bRepaint);

        private async void btn_StartGame_Click(object sender, EventArgs e)
        {
            await LoadGameAsync(textBox_GamePath.Text, textBox_Args.Text, textBox_Process.Text);
            //Thread.Sleep(1000);
            //EndGameProcess();
            //Thread.Sleep(1000);
            //await LoadGameAsync(textBox_GamePath.Text, textBox_Args.Text, textBox_Process.Text);
        }

        private void btn_BrowseGame_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Select a Program File";
            openFileDialog.Filter = "Executable Files (*.exe)|*.exe|All Files (*.*)|*.*"; // You can adjust the filter to your needs

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                textBox_GamePath.Text = openFileDialog.FileName;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EndGameProcess();
        }

        private void EndGameProcess()
        {
            try
            {
                string targetProcessName = textBox_Process.Text;

                // Find the process by name
                Process targetProcess = Process.GetProcessesByName(targetProcessName).FirstOrDefault();

                if (targetProcess == null)
                {
                    MessageBox.Show($"The process '{targetProcessName}' is not currently running.");
                    return;
                }

                // Confirm and terminate the process
                var confirmResult = MessageBox.Show($"Are you sure you want to end '{targetProcessName}'?",
                                                     "Confirm End Process",
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Warning);
                if (confirmResult == DialogResult.Yes)
                {
                    targetProcess.Kill();
                    MessageBox.Show($"The process '{targetProcessName}' has been terminated.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while attempting to end the process: {ex.Message}");
            }
        }
        private async void btn_Reload_Click(object sender, EventArgs e)
        {
            // Kill, then load again
            EndGameProcess();
            await LoadGameAsync(textBox_GamePath.Text, textBox_Args.Text, textBox_Process.Text);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Info_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Note: It is recommended to have at least 16 GB of RAM and a CPU with 6 cores in order " +
                $"to execute the game through the launcher.\n\nThis is a VERY VERY VERY EXPERIMENTAL function and may cause issues in specific conditions.\n\nProceed with caution." +
                $"\n\nThe handle may not be accessible the first time, use the Reload button to try again." +
                $"\n\nWhile this method may let you run any app inside of your PC, it's recommended to stick with the games." +
                $"\n\nThe Process field needs to match the name of the process itself for it be displayed." +
                $"\n\nIt is also extremely recommended to exit the program manually before closing the app.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void GameIntegration_Load(object sender, EventArgs e)
        {

        }
    }
}
