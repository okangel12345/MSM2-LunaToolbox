using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LunaLauncheri30.DAT1;

namespace LunaLauncheri30
{
    public partial class HashTool : Form
    {
        public HashTool()
        {
            InitializeComponent();

            textBox_Path1.Text = "";
            Hash(textBox_Path1.Text);

            DataContext = this;

            Styling.SetTitleBarColor(this.Handle, Color.FromArgb(26, 26, 26));
            Styling.ApplyButtonStyle(this, FlatStyle.Flat, Color.FromArgb(80, 80, 80), Color.FromArgb(34, 34, 34), Color.FromArgb(42, 42, 42), 1);
        }

        protected bool _normalizeInput = true;
        public bool NormalizeInput
        {
            get => _normalizeInput;
            set
            {
                _normalizeInput = value;

                // Hash all boxes
                Hash(textBox_Path1.Text);
            }
        }
        private void Hash(string input)
        {
            var crc64 = CRC64.Hash(input, true);
            var crc32 = CRC32.Hash(input, true);
            textBox_Hash1.Text = $"{crc64:X016}";
            textBox_Hash2.Text = $"{crc32:X08}";
        }

        private void textBox_Path1_KeyUp(object sender, KeyEventArgs e)
        {
            Hash(textBox_Path1.Text);
        }

        private void CopyToClipboard(TextBox TextBox)
        {
            if (!string.IsNullOrEmpty(TextBox.Text))
            {
                Clipboard.SetText(TextBox.Text);
                SystemSounds.Hand.Play();
            }
            
        }
        private void btn_Copy64_Click(object sender, EventArgs e)
        {
            CopyToClipboard(textBox_Hash1);
        }

        private void btn_Copy32_Click(object sender, EventArgs e)
        {
            CopyToClipboard(textBox_Hash2);
        }
    }
}
