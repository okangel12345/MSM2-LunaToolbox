namespace LunaLauncheri30
{
    partial class OverstrikePanel
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
            panel1 = new Panel();
            panel2 = new Panel();
            btn_ReloadOS = new Button();
            panel3 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(btn_ReloadOS);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1111, 638);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(12, 12, 12);
            panel2.Location = new Point(-22, -6);
            panel2.Name = "panel2";
            panel2.Size = new Size(1141, 10);
            panel2.TabIndex = 1;
            // 
            // btn_ReloadOS
            // 
            btn_ReloadOS.Location = new Point(12, 12);
            btn_ReloadOS.Name = "btn_ReloadOS";
            btn_ReloadOS.Size = new Size(75, 23);
            btn_ReloadOS.TabIndex = 0;
            btn_ReloadOS.Text = "Reload";
            btn_ReloadOS.UseVisualStyleBackColor = true;
            btn_ReloadOS.Click += btn_ReloadOS_Click;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.FromArgb(12, 12, 12);
            panel3.Location = new Point(-7, -17);
            panel3.Name = "panel3";
            panel3.Size = new Size(1138, 19);
            panel3.TabIndex = 1;
            // 
            // OverstrikePanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(22, 22, 22);
            ClientSize = new Size(1111, 638);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "OverstrikePanel";
            Text = "Form1";
            FormClosing += OverstrikePanel_FormClosing;
            Load += OverstrikePanel_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btn_ReloadOS;
        private Panel panel2;
        private Panel panel3;
    }
}