using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using LunaLauncheri300;

namespace LunaLauncheri30
{
    public partial class CustomQuickLaunch : Form
    {
        private string saveFilePath = "CustomQuickLaunchSettings.json";
        public CustomQuickLaunch()
        {
            InitializeComponent();
            LoadSettings(); // Load the saved settings on startup

            Styling.SetTitleBarColor(this.Handle, Color.FromArgb(26, 26, 26));
            Styling.ApplyButtonStyle(this, FlatStyle.Flat, Color.FromArgb(80, 80, 80), Color.FromArgb(34, 34, 34), Color.FromArgb(45, 45, 45), 1);
        }

        public void LoadSettings()
        {
            if (File.Exists(saveFilePath))
            {
                string json = File.ReadAllText(saveFilePath);
                var settings = JsonSerializer.Deserialize<CustomQuickLaunchSettings>(json);

                // Restore values to the controls
                field_name_1.Text = settings.FieldName1_Text;
                field_name_2.Text = settings.FieldName2_Text;
                field_name_3.Text = settings.FieldName3_Text;
                field_name_4.Text = settings.FieldName4_Text;
                field_name_5.Text = settings.FieldName5_Text;
                field_name_6.Text = settings.FieldName6_Text;
                field_name_7.Text = settings.FieldName7_Text;
                field_name_8.Text = settings.FieldName8_Text;
                field_name_9.Text = settings.FieldName9_Text;
                field_name_10.Text = settings.FieldName10_Text;

                field_path_1.Text = settings.FieldPath1_Text;
                field_path_2.Text = settings.FieldPath2_Text;
                field_path_3.Text = settings.FieldPath3_Text;
                field_path_4.Text = settings.FieldPath4_Text;
                field_path_5.Text = settings.FieldPath5_Text;
                field_path_6.Text = settings.FieldPath6_Text;
                field_path_7.Text = settings.FieldPath7_Text;
                field_path_8.Text = settings.FieldPath8_Text;
                field_path_9.Text = settings.FieldPath9_Text;
                field_path_10.Text = settings.FieldPath10_Text;

                IconPath_1.Text = settings.IconPath_1;
                IconPath_2.Text = settings.IconPath_2;
                IconPath_3.Text = settings.IconPath_3;
                IconPath_4.Text = settings.IconPath_4;
                IconPath_5.Text = settings.IconPath_5;
                IconPath_6.Text = settings.IconPath_6;
                IconPath_7.Text = settings.IconPath_7;
                IconPath_8.Text = settings.IconPath_8;
                IconPath_9.Text = settings.IconPath_9;
                IconPath_10.Text = settings.IconPath_10;

                checkBox1.Checked = settings.CheckBox1;
                checkBox2.Checked = settings.CheckBox2;
                checkBox3.Checked = settings.CheckBox3;
                checkBox4.Checked = settings.CheckBox4;
                checkBox5.Checked = settings.CheckBox5;
                checkBox6.Checked = settings.CheckBox6;
                checkBox7.Checked = settings.CheckBox7;
                checkBox8.Checked = settings.CheckBox8;
                checkBox9.Checked = settings.CheckBox9;
                checkBox10.Checked = settings.CheckBox10;
            }
        }

        public void LoadProgramIntoText(TextBox pathTextBox, bool IsIcon)
        {
            if (!IsIcon)
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Title = "Select a Program File";
                openFileDialog.Filter = "Executable Files (*.exe)|*.exe|All Files (*.*)|*.*"; // You can adjust the filter to your needs

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pathTextBox.Text = openFileDialog.FileName;
                }
            }
            else
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Title = "Select an Icon file";
                openFileDialog.Filter = "PNG Files (*.png)|*.png|All Files (*.*)|*.*"; // You can adjust the filter to your needs

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pathTextBox.Text = openFileDialog.FileName;
                }
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            var settings = new CustomQuickLaunchSettings
            {
                FieldName1_Text = field_name_1.Text,
                FieldName2_Text = field_name_2.Text,
                FieldName3_Text = field_name_3.Text,
                FieldName4_Text = field_name_4.Text,
                FieldName5_Text = field_name_5.Text,
                FieldName6_Text = field_name_6.Text,
                FieldName7_Text = field_name_7.Text,
                FieldName8_Text = field_name_8.Text,
                FieldName9_Text = field_name_9.Text,
                FieldName10_Text = field_name_10.Text,

                FieldPath1_Text = field_path_1.Text,
                FieldPath2_Text = field_path_2.Text,
                FieldPath3_Text = field_path_3.Text,
                FieldPath4_Text = field_path_4.Text,
                FieldPath5_Text = field_path_5.Text,
                FieldPath6_Text = field_path_6.Text,
                FieldPath7_Text = field_path_7.Text,
                FieldPath8_Text = field_path_8.Text,
                FieldPath9_Text = field_path_9.Text,
                FieldPath10_Text = field_path_10.Text,

                IconPath_1 = IconPath_1.Text,
                IconPath_2 = IconPath_2.Text,
                IconPath_3 = IconPath_3.Text,
                IconPath_4 = IconPath_4.Text,
                IconPath_5 = IconPath_5.Text,
                IconPath_6 = IconPath_6.Text,
                IconPath_7 = IconPath_7.Text,
                IconPath_8 = IconPath_8.Text,
                IconPath_9 = IconPath_9.Text,
                IconPath_10 = IconPath_10.Text,


                CheckBox1 = checkBox1.Checked,
                CheckBox2 = checkBox2.Checked,
                CheckBox3 = checkBox3.Checked,
                CheckBox4 = checkBox4.Checked,
                CheckBox5 = checkBox5.Checked,
                CheckBox6 = checkBox6.Checked,
                CheckBox7 = checkBox7.Checked,
                CheckBox8 = checkBox8.Checked,
                CheckBox9 = checkBox9.Checked,
                CheckBox10 = checkBox10.Checked
            };

            string json = JsonSerializer.Serialize(settings);
            File.WriteAllText(saveFilePath, json);

            MessageBox.Show("Settings saved!");
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadProgramIntoText(field_path_1, false);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadProgramIntoText(field_path_2, false);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoadProgramIntoText(field_path_3, false);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LoadProgramIntoText(field_path_4, false);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            LoadProgramIntoText(field_path_5, false);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            LoadProgramIntoText(field_path_6, false);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            LoadProgramIntoText(field_path_7, false);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            LoadProgramIntoText(field_path_8, false);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            LoadProgramIntoText(field_path_9, false);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            LoadProgramIntoText(field_path_10, false);
        }

        private void buttonIcon_1_Click(object sender, EventArgs e)
        {
            LoadProgramIntoText(IconPath_1, true);
        }

        private void buttonIcon_2_Click(object sender, EventArgs e)
        {
            LoadProgramIntoText(IconPath_2, true);
        }

        private void buttonIcon_3_Click(object sender, EventArgs e)
        {
            LoadProgramIntoText(IconPath_3, true);
        }

        private void buttonIcon_4_Click(object sender, EventArgs e)
        {
            LoadProgramIntoText(IconPath_4, true);
        }

        private void buttonIcon_5_Click(object sender, EventArgs e)
        {
            LoadProgramIntoText(IconPath_5, true);
        }

        private void buttonIcon_6_Click(object sender, EventArgs e)
        {
            LoadProgramIntoText(IconPath_6, true);
        }

        private void buttonIcon_7_Click(object sender, EventArgs e)
        {
            LoadProgramIntoText(IconPath_7, true);
        }

        private void buttonIcon_8_Click(object sender, EventArgs e)
        {
            LoadProgramIntoText(IconPath_8, true);
        }

        private void buttonIcon_9_Click(object sender, EventArgs e)
        {
            LoadProgramIntoText(IconPath_9, true);
        }

        private void buttonIcon_10_Click(object sender, EventArgs e)
        {
            LoadProgramIntoText(IconPath_10, true);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            IconPath_1.Text = "";
            IconPath_2.Text = "";
            IconPath_3.Text = "";
            IconPath_4.Text = "";
            IconPath_5.Text = "";
            IconPath_6.Text = "";
            IconPath_7.Text = "";
            IconPath_8.Text = "";
            IconPath_9.Text = "";
            IconPath_10.Text = "";
        }

        // Name fields
        public string FieldName1Text => field_name_1.Text;
        public string FieldName2Text => field_name_2.Text;
        public string FieldName3Text => field_name_3.Text;
        public string FieldName4Text => field_name_4.Text;
        public string FieldName5Text => field_name_5.Text;
        public string FieldName6Text => field_name_6.Text;
        public string FieldName7Text => field_name_7.Text;
        public string FieldName8Text => field_name_8.Text;
        public string FieldName9Text => field_name_9.Text;
        public string FieldName10Text => field_name_10.Text;

        // Paths
        public string FieldPath1Text => field_path_1.Text;
        public string FieldPath2Text => field_path_2.Text;
        public string FieldPath3Text => field_path_3.Text;
        public string FieldPath4Text => field_path_4.Text;
        public string FieldPath5Text => field_path_5.Text;
        public string FieldPath6Text => field_path_6.Text;
        public string FieldPath7Text => field_path_7.Text;
        public string FieldPath8Text => field_path_8.Text;
        public string FieldPath9Text => field_path_9.Text;
        public string FieldPath10Text => field_path_10.Text;

        // Icons
        public string IconPath1 => IconPath_1.Text;
        public string IconPath2 => IconPath_2.Text;
        public string IconPath3 => IconPath_3.Text;
        public string IconPath4 => IconPath_4.Text;
        public string IconPath5 => IconPath_5.Text;
        public string IconPath6 => IconPath_6.Text;
        public string IconPath7 => IconPath_7.Text;
        public string IconPath8 => IconPath_8.Text;
        public string IconPath9 => IconPath_9.Text;
        public string IconPath10 => IconPath_10.Text;

        // Checks
        public bool Enabled1 => checkBox1.Checked;
        public bool Enabled2 => checkBox2.Checked;
        public bool Enabled3 => checkBox3.Checked;
        public bool Enabled4 => checkBox4.Checked;
        public bool Enabled5 => checkBox5.Checked;
        public bool Enabled6 => checkBox6.Checked;
        public bool Enabled7 => checkBox7.Checked;
        public bool Enabled8 => checkBox8.Checked;
        public bool Enabled9 => checkBox9.Checked;
        public bool Enabled10 => checkBox10.Checked;

    }

    public class CustomQuickLaunchSettings
    {
        public string FieldName1_Text { get; set; }
        public string FieldName2_Text { get; set; }
        public string FieldName3_Text { get; set; }
        public string FieldName4_Text { get; set; }
        public string FieldName5_Text { get; set; }
        public string FieldName6_Text { get; set; }
        public string FieldName7_Text { get; set; }
        public string FieldName8_Text { get; set; }
        public string FieldName9_Text { get; set; }
        public string FieldName10_Text { get; set; }

        public string FieldPath1_Text { get; set; }
        public string FieldPath2_Text { get; set; }
        public string FieldPath3_Text { get; set; }
        public string FieldPath4_Text { get; set; }
        public string FieldPath5_Text { get; set; }
        public string FieldPath6_Text { get; set; }
        public string FieldPath7_Text { get; set; }
        public string FieldPath8_Text { get; set; }
        public string FieldPath9_Text { get; set; }
        public string FieldPath10_Text { get; set; }

        public string IconPath_1 { get; set; }
        public string IconPath_2 { get; set; }
        public string IconPath_3 { get; set; }
        public string IconPath_4 { get; set; }
        public string IconPath_5 { get; set; }
        public string IconPath_6 { get; set; }
        public string IconPath_7 { get; set; }
        public string IconPath_8 { get; set; }
        public string IconPath_9 { get; set; }
        public string IconPath_10 { get; set; }


        public bool CheckBox1 { get; set; }
        public bool CheckBox2 { get; set; }
        public bool CheckBox3 { get; set; }
        public bool CheckBox4 { get; set; }
        public bool CheckBox5 { get; set; }
        public bool CheckBox6 { get; set; }
        public bool CheckBox7 { get; set; }
        public bool CheckBox8 { get; set; }
        public bool CheckBox9 { get; set; }
        public bool CheckBox10 { get; set; }
    }
}
