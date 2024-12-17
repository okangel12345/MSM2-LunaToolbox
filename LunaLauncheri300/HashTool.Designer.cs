﻿namespace LunaLauncheri30
{
    partial class HashTool
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HashTool));
            textBox_Path1 = new TextBox();
            label1 = new Label();
            textBox_Hash1 = new TextBox();
            label2 = new Label();
            textBox_Hash2 = new TextBox();
            label3 = new Label();
            btn_Copy64 = new Button();
            btn_Copy32 = new Button();
            SuspendLayout();
            // 
            // textBox_Path1
            // 
            textBox_Path1.BackColor = Color.FromArgb(22, 22, 22);
            textBox_Path1.BorderStyle = BorderStyle.FixedSingle;
            textBox_Path1.ForeColor = SystemColors.Window;
            textBox_Path1.Location = new Point(12, 29);
            textBox_Path1.Name = "textBox_Path1";
            textBox_Path1.Size = new Size(640, 23);
            textBox_Path1.TabIndex = 0;
            textBox_Path1.KeyUp += textBox_Path1_KeyUp;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(10, 11);
            label1.Name = "label1";
            label1.Size = new Size(83, 15);
            label1.TabIndex = 1;
            label1.Text = "In-Game Path:";
            // 
            // textBox_Hash1
            // 
            textBox_Hash1.BackColor = Color.FromArgb(22, 22, 22);
            textBox_Hash1.BorderStyle = BorderStyle.FixedSingle;
            textBox_Hash1.ForeColor = SystemColors.Window;
            textBox_Hash1.Location = new Point(12, 78);
            textBox_Hash1.Name = "textBox_Hash1";
            textBox_Hash1.Size = new Size(281, 23);
            textBox_Hash1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(9, 60);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 3;
            label2.Text = "CRC64";
            // 
            // textBox_Hash2
            // 
            textBox_Hash2.BackColor = Color.FromArgb(22, 22, 22);
            textBox_Hash2.BorderStyle = BorderStyle.FixedSingle;
            textBox_Hash2.ForeColor = SystemColors.Window;
            textBox_Hash2.Location = new Point(368, 78);
            textBox_Hash2.Name = "textBox_Hash2";
            textBox_Hash2.Size = new Size(215, 23);
            textBox_Hash2.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(365, 60);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 5;
            label3.Text = "CRC32";
            // 
            // btn_Copy64
            // 
            btn_Copy64.Location = new Point(299, 78);
            btn_Copy64.Name = "btn_Copy64";
            btn_Copy64.Size = new Size(63, 23);
            btn_Copy64.TabIndex = 6;
            btn_Copy64.Text = "Copy";
            btn_Copy64.UseVisualStyleBackColor = true;
            btn_Copy64.Click += btn_Copy64_Click;
            // 
            // btn_Copy32
            // 
            btn_Copy32.Location = new Point(589, 78);
            btn_Copy32.Name = "btn_Copy32";
            btn_Copy32.Size = new Size(63, 23);
            btn_Copy32.TabIndex = 7;
            btn_Copy32.Text = "Copy";
            btn_Copy32.UseVisualStyleBackColor = true;
            btn_Copy32.Click += btn_Copy32_Click;
            // 
            // HashTool
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(12, 12, 12);
            ClientSize = new Size(664, 124);
            Controls.Add(btn_Copy32);
            Controls.Add(btn_Copy64);
            Controls.Add(label3);
            Controls.Add(textBox_Hash2);
            Controls.Add(label2);
            Controls.Add(textBox_Hash1);
            Controls.Add(label1);
            Controls.Add(textBox_Path1);
            ForeColor = SystemColors.Control;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "HashTool";
            Text = "Hash Tool";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_Path1;
        private Label label1;
        private TextBox textBox_Hash1;
        private Label label2;
        private TextBox textBox_Hash2;
        private Label label3;
        private Button btn_Copy64;
        private Button btn_Copy32;
    }
}