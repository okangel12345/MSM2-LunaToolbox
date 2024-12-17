using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LunaLauncheri30.HelpForms
{
    public partial class InsomniacEngineHelp : Form
    {
        public InsomniacEngineHelp()
        {
            InitializeComponent();
            LoadText();

            Styling.SetTitleBarColor(Handle, Color.FromArgb(26, 26, 26));
            Styling.ApplyButtonStyle(this, FlatStyle.Flat, Color.FromArgb(80, 80, 80), Color.FromArgb(34, 34, 34), Color.FromArgb(42, 42, 42), 1);
        }


        private string Message = "Insomniac Engine is Insomniac Games’ proprietary video game making engine which they use to make all of their assets." +
            "It allows developers to make and compile assets from scratch to be used with their different projects.\n\n" +
            "This project is an unofficial release of Insomniac Engine, developed independently and with no affiliation with Insomniac Games or Sony. " +
            "Our only goal is to provide the SM2 modding community with increased flexibility and accessibility, using Insomniac Games' official tools to create SM2 assets from scratch." +
            "\r\n\r\nThis release is intended solely for private, non-commercial use within the SM2 modding community.";

        private string ToolsMessage = "Orbit Asset Editor - The Orbit Asset Editor is the most powerful tool in the entirety of Insomniac Engine," +
                                      "it allows users to edit and make almost any kind of asset.\n\n" +
                                      "Vault - The Vault is Insomniac's Asset Browser, it loads all files inside of the source folder and various " +
                                      "types of data such as the author, last modified, references to other assets, etc.\n\n" +
                                      "Asset Wizard - The Asset Wizard lets you create almost any kind of file from scratch. " +
                                      "Some asset types like .textures will need to be created manually.";
        private void LoadText()
        {
            richTextBox1.Text = Message;
            richTextBox4.Text = ToolsMessage;
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
