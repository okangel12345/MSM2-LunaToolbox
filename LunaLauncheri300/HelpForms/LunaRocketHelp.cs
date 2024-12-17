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
    public partial class LunaRocketHelp : Form
    {
        public LunaRocketHelp()
        {
            InitializeComponent();

            Styling.SetTitleBarColor(Handle, Color.FromArgb(26, 26, 26));
            Styling.ApplyButtonStyle(this, FlatStyle.Flat, Color.FromArgb(80, 80, 80), Color.FromArgb(34, 34, 34), Color.FromArgb(42, 42, 42), 1);
        }

        private void LunaRocketHelp_Load(object sender, EventArgs e)
        {
            MakeTextBold(richTextBox1, "- Input:");
            MakeTextBold(richTextBox1, "- Output:");

            MakeTextBold(richTextBox1, "- Swap Header:");
            MakeTextBold(richTextBox1, "- Cleanup:");
            MakeTextBold(richTextBox1, "- Pack as Stage:");
        }

        private void MakeTextBold(RichTextBox richTextBox, string textToBold)
        {
            int startIndex = richTextBox.Text.IndexOf(textToBold); // Find the starting index of the text
            if (startIndex >= 0)
            {
                richTextBox.Select(startIndex, textToBold.Length); // Select the text to modify
                richTextBox.SelectionFont = new Font(richTextBox.Font, FontStyle.Bold); // Apply bold style
                richTextBox.DeselectAll(); // Deselect the text after styling
            }
        }
    }
}
