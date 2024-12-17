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
    public partial class OverstrikePanel : Form
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
        public OverstrikePanel()
        {
            InitializeComponent();

            Styling.SetTitleBarColor(this.Handle, Color.FromArgb(26, 26, 26));
            Styling.ApplyButtonStyle(this, FlatStyle.Flat, Color.FromArgb(80, 80, 80), Color.FromArgb(34, 34, 34), Color.FromArgb(45, 45, 45), 1);
        }

        public void LoadOverstrike()
        {
            try
            {
                // Set the path to the ModdingTool executable
                string moddingToolPath = Environment.ExpandEnvironmentVariables("%IG_ROOT%i30/Utilities/Overstrike/Overstrike.exe");

                // Verify the ModdingTool executable exists
                if (!File.Exists(moddingToolPath))
                {
                    MessageBox.Show($"The Overstrike executable was not found at: {moddingToolPath}");
                    return;
                }

                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    FileName = moddingToolPath,
                    WindowStyle = ProcessWindowStyle.Minimized // Start minimized
                };

                // Start the ModdingTool process
                Process process = null;
                try
                {
                    process = Process.Start(startInfo);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Failed to start the process: {ex.Message}");
                    return;
                }

                // Ensure the process object is valid
                if (process == null)
                {
                    MessageBox.Show("Failed to start the process. Process object is null.");
                    return;
                }

                IntPtr toolHandle = IntPtr.Zero;
                int retryCount = 10;
                int delay = 500;

                for (int i = 0; i < retryCount; i++)
                {
                    if (process.MainWindowHandle != IntPtr.Zero)
                    {
                        toolHandle = process.MainWindowHandle;
                        break;
                    }
                    System.Threading.Thread.Sleep(delay);
                    process.Refresh();
                }


                if (toolHandle == IntPtr.Zero)
                {
                    MessageBox.Show("Failed to retrieve the ModdingTool window handle after multiple attempts.");
                    return;
                }

                // Ensure panel1 is initialized
                if (panel1 == null)
                {
                    MessageBox.Show("Panel1 is not initialized or does not exist.");
                    return;
                }

                // Reparent the ModdingTool window to panel1
                SetParent(toolHandle, panel1.Handle);

                // Remove the title bar and resizable border
                int style = GetWindowLong(toolHandle, GWL_STYLE);
                style &= ~(WS_CAPTION | WS_THICKFRAME);
                SetWindowLong(toolHandle, GWL_STYLE, style);

                // Resize the embedded window to fill panel1
                panel1.Resize += (sender, e) =>
                {
                    MoveWindow(toolHandle, 0, 0, panel1.Width, panel1.Height, true);
                };
                MoveWindow(toolHandle, 0, 0, panel1.Width, panel1.Height, true);


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading ModdingTool: {ex.Message}");
            }
        }



        [DllImport("user32.dll", SetLastError = true)]
        private static extern bool MoveWindow(IntPtr hWnd, int X, int Y, int nWidth, int nHeight, bool bRepaint);

        private void OverstrikePanel_Load(object sender, EventArgs e)
        {
            LoadOverstrike();
        }

        private void btn_ReloadOS_Click(object sender, EventArgs e)
        {
            LoadOverstrike();
        }

        private void OverstrikePanel_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
