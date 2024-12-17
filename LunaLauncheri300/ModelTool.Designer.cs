namespace LunaLauncheri30
{
    partial class ModelTool
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_Ascii = new Button();
            textBox_Ascii = new TextBox();
            richTextBox1 = new RichTextBox();
            btn_Model = new Button();
            btn_Materials = new Button();
            textBox_Materials = new TextBox();
            textBox_Model = new TextBox();
            label1 = new Label();
            textBox_InGameModelPath = new TextBox();
            label2 = new Label();
            textBox_Hash = new TextBox();
            Check_Hash = new CheckBox();
            label3 = new Label();
            label4 = new Label();
            richTextBox2 = new RichTextBox();
            label5 = new Label();
            label6 = new Label();
            btn_ExtractModel = new Button();
            btn_InjectAscii = new Button();
            btn_HelpModel = new Button();
            SuspendLayout();
            // 
            // btn_Ascii
            // 
            btn_Ascii.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_Ascii.Location = new Point(957, 36);
            btn_Ascii.Name = "btn_Ascii";
            btn_Ascii.Size = new Size(133, 23);
            btn_Ascii.TabIndex = 22;
            btn_Ascii.Text = "Select .ascii";
            btn_Ascii.UseVisualStyleBackColor = true;
            btn_Ascii.Click += btn_Ascii_Click;
            // 
            // textBox_Ascii
            // 
            textBox_Ascii.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox_Ascii.BackColor = Color.FromArgb(22, 22, 22);
            textBox_Ascii.BorderStyle = BorderStyle.FixedSingle;
            textBox_Ascii.ForeColor = SystemColors.ScrollBar;
            textBox_Ascii.Location = new Point(12, 36);
            textBox_Ascii.Name = "textBox_Ascii";
            textBox_Ascii.Size = new Size(939, 23);
            textBox_Ascii.TabIndex = 20;
            // 
            // richTextBox1
            // 
            richTextBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            richTextBox1.BackColor = Color.FromArgb(22, 22, 22);
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.ForeColor = SystemColors.Window;
            richTextBox1.Location = new Point(12, 155);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(1078, 232);
            richTextBox1.TabIndex = 30;
            richTextBox1.Text = "";
            // 
            // btn_Model
            // 
            btn_Model.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_Model.Location = new Point(957, 67);
            btn_Model.Name = "btn_Model";
            btn_Model.Size = new Size(133, 23);
            btn_Model.TabIndex = 31;
            btn_Model.Text = "Select .model";
            btn_Model.UseVisualStyleBackColor = true;
            btn_Model.Click += btn_Model_Click;
            // 
            // btn_Materials
            // 
            btn_Materials.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_Materials.Location = new Point(957, 96);
            btn_Materials.Name = "btn_Materials";
            btn_Materials.Size = new Size(133, 23);
            btn_Materials.TabIndex = 32;
            btn_Materials.Text = "Select materials (txt)";
            btn_Materials.UseVisualStyleBackColor = true;
            btn_Materials.Click += btn_Materials_Click;
            // 
            // textBox_Materials
            // 
            textBox_Materials.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox_Materials.BackColor = Color.FromArgb(22, 22, 22);
            textBox_Materials.BorderStyle = BorderStyle.FixedSingle;
            textBox_Materials.ForeColor = SystemColors.ScrollBar;
            textBox_Materials.Location = new Point(12, 96);
            textBox_Materials.Name = "textBox_Materials";
            textBox_Materials.Size = new Size(939, 23);
            textBox_Materials.TabIndex = 33;
            // 
            // textBox_Model
            // 
            textBox_Model.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox_Model.BackColor = Color.FromArgb(22, 22, 22);
            textBox_Model.BorderStyle = BorderStyle.FixedSingle;
            textBox_Model.ForeColor = SystemColors.ScrollBar;
            textBox_Model.Location = new Point(12, 65);
            textBox_Model.Name = "textBox_Model";
            textBox_Model.Size = new Size(939, 23);
            textBox_Model.TabIndex = 34;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ButtonShadow;
            label1.Location = new Point(10, 134);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 35;
            label1.Text = "Log:";
            // 
            // textBox_InGameModelPath
            // 
            textBox_InGameModelPath.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox_InGameModelPath.BackColor = Color.FromArgb(22, 22, 22);
            textBox_InGameModelPath.BorderStyle = BorderStyle.FixedSingle;
            textBox_InGameModelPath.ForeColor = SystemColors.ScrollBar;
            textBox_InGameModelPath.Location = new Point(12, 442);
            textBox_InGameModelPath.Name = "textBox_InGameModelPath";
            textBox_InGameModelPath.Size = new Size(556, 23);
            textBox_InGameModelPath.TabIndex = 36;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ButtonShadow;
            label2.Location = new Point(10, 424);
            label2.Name = "label2";
            label2.Size = new Size(123, 15);
            label2.TabIndex = 37;
            label2.Text = "In-Game .model path:";
            // 
            // textBox_Hash
            // 
            textBox_Hash.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBox_Hash.BackColor = Color.FromArgb(32, 32, 32);
            textBox_Hash.BorderStyle = BorderStyle.FixedSingle;
            textBox_Hash.Enabled = false;
            textBox_Hash.ForeColor = SystemColors.ScrollBar;
            textBox_Hash.Location = new Point(646, 442);
            textBox_Hash.Name = "textBox_Hash";
            textBox_Hash.Size = new Size(305, 23);
            textBox_Hash.TabIndex = 38;
            // 
            // Check_Hash
            // 
            Check_Hash.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Check_Hash.AutoSize = true;
            Check_Hash.ForeColor = SystemColors.Control;
            Check_Hash.Location = new Point(573, 446);
            Check_Hash.Name = "Check_Hash";
            Check_Hash.Size = new Size(73, 19);
            Check_Hash.TabIndex = 40;
            Check_Hash.Text = "Use hash";
            Check_Hash.UseVisualStyleBackColor = true;
            Check_Hash.CheckedChanged += Check_Hash_CheckedChanged;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(120, 120, 120);
            label3.Location = new Point(644, 424);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 39;
            label3.Text = "Hash:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ButtonShadow;
            label4.Location = new Point(10, 473);
            label4.Name = "label4";
            label4.Size = new Size(30, 15);
            label4.TabIndex = 42;
            label4.Text = "Log:";
            // 
            // richTextBox2
            // 
            richTextBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            richTextBox2.BackColor = Color.FromArgb(22, 22, 22);
            richTextBox2.BorderStyle = BorderStyle.None;
            richTextBox2.ForeColor = SystemColors.Window;
            richTextBox2.Location = new Point(12, 491);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(1078, 137);
            richTextBox2.TabIndex = 41;
            richTextBox2.Text = "";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.ForeColor = Color.Gainsboro;
            label5.Location = new Point(8, 396);
            label5.Name = "label5";
            label5.Size = new Size(107, 21);
            label5.TabIndex = 43;
            label5.Text = "Extract .model";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.ForeColor = Color.Gainsboro;
            label6.Location = new Point(8, 6);
            label6.Name = "label6";
            label6.Size = new Size(160, 21);
            label6.TabIndex = 44;
            label6.Text = "Import ascii to .model";
            // 
            // btn_ExtractModel
            // 
            btn_ExtractModel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_ExtractModel.Location = new Point(957, 442);
            btn_ExtractModel.Name = "btn_ExtractModel";
            btn_ExtractModel.Size = new Size(133, 23);
            btn_ExtractModel.TabIndex = 45;
            btn_ExtractModel.Text = "Extract .model";
            btn_ExtractModel.UseVisualStyleBackColor = true;
            btn_ExtractModel.Click += btn_ExtractModel_Click;
            // 
            // btn_InjectAscii
            // 
            btn_InjectAscii.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_InjectAscii.Location = new Point(957, 126);
            btn_InjectAscii.Name = "btn_InjectAscii";
            btn_InjectAscii.Size = new Size(133, 23);
            btn_InjectAscii.TabIndex = 46;
            btn_InjectAscii.Text = "Import ascii to .model";
            btn_InjectAscii.UseVisualStyleBackColor = true;
            btn_InjectAscii.Click += btn_InjectAscii_Click;
            // 
            // btn_HelpModel
            // 
            btn_HelpModel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_HelpModel.Location = new Point(1073, 9);
            btn_HelpModel.Name = "btn_HelpModel";
            btn_HelpModel.Size = new Size(17, 19);
            btn_HelpModel.TabIndex = 47;
            btn_HelpModel.Text = "?";
            btn_HelpModel.UseVisualStyleBackColor = true;
            btn_HelpModel.Click += btn_HelpModel_Click;
            // 
            // ModelTool
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(12, 12, 12);
            ClientSize = new Size(1102, 640);
            Controls.Add(btn_HelpModel);
            Controls.Add(btn_InjectAscii);
            Controls.Add(btn_ExtractModel);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(richTextBox2);
            Controls.Add(Check_Hash);
            Controls.Add(label3);
            Controls.Add(textBox_Hash);
            Controls.Add(label2);
            Controls.Add(textBox_InGameModelPath);
            Controls.Add(label1);
            Controls.Add(textBox_Model);
            Controls.Add(textBox_Materials);
            Controls.Add(btn_Materials);
            Controls.Add(btn_Model);
            Controls.Add(richTextBox1);
            Controls.Add(btn_Ascii);
            Controls.Add(textBox_Ascii);
            Name = "ModelTool";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btn_Ascii;
        private TextBox textBox_Ascii;
        private RichTextBox richTextBox1;
        private Button btn_Model;
        private Button btn_Materials;
        private TextBox textBox_Materials;
        private TextBox textBox_Model;
        private Label label1;
        private TextBox textBox_InGameModelPath;
        private Label label2;
        private TextBox textBox_Hash;
        private CheckBox Check_Hash;
        private Label label3;
        private Label label4;
        private RichTextBox richTextBox2;
        private Label label5;
        private Label label6;
        private Button btn_ExtractModel;
        private Button btn_InjectAscii;
        private Button btn_HelpModel;
    }
}