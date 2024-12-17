namespace LunaLauncheri30
{
    partial class AtmosphereTool
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
            label1 = new Label();
            label3 = new Label();
            label2 = new Label();
            btn_OpenFolder = new Button();
            btn_InputAsset = new Button();
            textBox_Output = new TextBox();
            textBox_Input = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 95F);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(189, 199);
            label1.Name = "label1";
            label1.Size = new Size(724, 168);
            label1.TabIndex = 0;
            label1.Text = "Placeholder";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(190, 190, 190);
            label3.Location = new Point(12, 56);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 25;
            label3.Text = "Output:";
            label3.TextAlign = ContentAlignment.BottomLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(190, 190, 190);
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 24;
            label2.Text = "Input:";
            label2.TextAlign = ContentAlignment.BottomLeft;
            // 
            // btn_OpenFolder
            // 
            btn_OpenFolder.Location = new Point(1011, 73);
            btn_OpenFolder.Name = "btn_OpenFolder";
            btn_OpenFolder.Size = new Size(90, 23);
            btn_OpenFolder.TabIndex = 23;
            btn_OpenFolder.Text = "Open folder";
            btn_OpenFolder.UseVisualStyleBackColor = true;
            // 
            // btn_InputAsset
            // 
            btn_InputAsset.Location = new Point(1062, 27);
            btn_InputAsset.Name = "btn_InputAsset";
            btn_InputAsset.Size = new Size(39, 23);
            btn_InputAsset.TabIndex = 22;
            btn_InputAsset.Text = "...";
            btn_InputAsset.UseVisualStyleBackColor = true;
            // 
            // textBox_Output
            // 
            textBox_Output.BackColor = Color.FromArgb(22, 22, 22);
            textBox_Output.BorderStyle = BorderStyle.FixedSingle;
            textBox_Output.ForeColor = SystemColors.ScrollBar;
            textBox_Output.Location = new Point(15, 73);
            textBox_Output.Name = "textBox_Output";
            textBox_Output.ReadOnly = true;
            textBox_Output.Size = new Size(990, 23);
            textBox_Output.TabIndex = 21;
            // 
            // textBox_Input
            // 
            textBox_Input.BackColor = Color.FromArgb(22, 22, 22);
            textBox_Input.BorderStyle = BorderStyle.FixedSingle;
            textBox_Input.ForeColor = SystemColors.ScrollBar;
            textBox_Input.Location = new Point(15, 27);
            textBox_Input.Name = "textBox_Input";
            textBox_Input.ReadOnly = true;
            textBox_Input.Size = new Size(1041, 23);
            textBox_Input.TabIndex = 20;
            // 
            // AtmosphereTool
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(12, 12, 12);
            ClientSize = new Size(1113, 606);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btn_OpenFolder);
            Controls.Add(btn_InputAsset);
            Controls.Add(textBox_Output);
            Controls.Add(textBox_Input);
            Controls.Add(label1);
            Name = "AtmosphereTool";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private Label label2;
        private Button btn_OpenFolder;
        private Button btn_InputAsset;
        private TextBox textBox_Output;
        private TextBox textBox_Input;
    }
}