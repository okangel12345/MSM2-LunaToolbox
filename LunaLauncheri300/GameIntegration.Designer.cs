namespace LunaLauncheri30
{
    partial class GameIntegration
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
            pictureBox1 = new PictureBox();
            btn_StartGame = new Button();
            textBox_GamePath = new TextBox();
            button1 = new Button();
            textBox_Args = new TextBox();
            textBox_Process = new TextBox();
            btn_BrowseGame = new Button();
            btn_Reload = new Button();
            btn_Info = new Button();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(5, 5, 5);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 41);
            panel1.Name = "panel1";
            panel1.Size = new Size(1110, 608);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.BackColor = Color.FromArgb(5, 5, 5);
            pictureBox1.BackgroundImage = Resources.EngineIcons.ScreenSpidey;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(12, 34);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1086, 511);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btn_StartGame
            // 
            btn_StartGame.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_StartGame.Location = new Point(753, 12);
            btn_StartGame.Name = "btn_StartGame";
            btn_StartGame.Size = new Size(122, 23);
            btn_StartGame.TabIndex = 1;
            btn_StartGame.Text = "Start game";
            btn_StartGame.UseVisualStyleBackColor = true;
            btn_StartGame.Click += btn_StartGame_Click;
            // 
            // textBox_GamePath
            // 
            textBox_GamePath.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox_GamePath.BackColor = Color.FromArgb(22, 22, 22);
            textBox_GamePath.BorderStyle = BorderStyle.FixedSingle;
            textBox_GamePath.ForeColor = SystemColors.Window;
            textBox_GamePath.Location = new Point(58, 12);
            textBox_GamePath.Name = "textBox_GamePath";
            textBox_GamePath.Size = new Size(293, 23);
            textBox_GamePath.TabIndex = 2;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.Location = new Point(974, 13);
            button1.Name = "button1";
            button1.Size = new Size(52, 23);
            button1.TabIndex = 3;
            button1.Text = "Exit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox_Args
            // 
            textBox_Args.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBox_Args.BackColor = Color.FromArgb(22, 22, 22);
            textBox_Args.BorderStyle = BorderStyle.FixedSingle;
            textBox_Args.ForeColor = SystemColors.Window;
            textBox_Args.Location = new Point(449, 13);
            textBox_Args.Name = "textBox_Args";
            textBox_Args.Size = new Size(124, 23);
            textBox_Args.TabIndex = 4;
            textBox_Args.Text = "-nolauncher";
            // 
            // textBox_Process
            // 
            textBox_Process.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBox_Process.BackColor = Color.FromArgb(22, 22, 22);
            textBox_Process.BorderStyle = BorderStyle.FixedSingle;
            textBox_Process.ForeColor = SystemColors.Window;
            textBox_Process.Location = new Point(579, 13);
            textBox_Process.Name = "textBox_Process";
            textBox_Process.Size = new Size(168, 23);
            textBox_Process.TabIndex = 5;
            textBox_Process.Text = "Process Name";
            // 
            // btn_BrowseGame
            // 
            btn_BrowseGame.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_BrowseGame.Location = new Point(357, 13);
            btn_BrowseGame.Name = "btn_BrowseGame";
            btn_BrowseGame.Size = new Size(86, 23);
            btn_BrowseGame.TabIndex = 2;
            btn_BrowseGame.Text = "Browse...";
            btn_BrowseGame.UseVisualStyleBackColor = true;
            btn_BrowseGame.Click += btn_BrowseGame_Click;
            // 
            // btn_Reload
            // 
            btn_Reload.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_Reload.Location = new Point(881, 13);
            btn_Reload.Name = "btn_Reload";
            btn_Reload.Size = new Size(87, 23);
            btn_Reload.TabIndex = 6;
            btn_Reload.Text = "Reload game";
            btn_Reload.UseVisualStyleBackColor = true;
            btn_Reload.Click += btn_Reload_Click;
            // 
            // btn_Info
            // 
            btn_Info.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_Info.Location = new Point(1032, 13);
            btn_Info.Name = "btn_Info";
            btn_Info.Size = new Size(69, 23);
            btn_Info.TabIndex = 2;
            btn_Info.Text = "Warning!";
            btn_Info.UseVisualStyleBackColor = true;
            btn_Info.Click += btn_Info_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(11, 16);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 0;
            label1.Text = "Game:";
            // 
            // GameIntegration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(12, 12, 12);
            ClientSize = new Size(1110, 649);
            Controls.Add(label1);
            Controls.Add(btn_Info);
            Controls.Add(btn_Reload);
            Controls.Add(btn_BrowseGame);
            Controls.Add(textBox_Process);
            Controls.Add(textBox_Args);
            Controls.Add(button1);
            Controls.Add(textBox_GamePath);
            Controls.Add(btn_StartGame);
            Controls.Add(panel1);
            Name = "GameIntegration";
            Text = "GameIntegration";
            Load += GameIntegration_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btn_StartGame;
        private TextBox textBox_GamePath;
        private Button button1;
        private TextBox textBox_Args;
        private TextBox textBox_Process;
        private Button btn_BrowseGame;
        private Button btn_Reload;
        private Button btn_Info;
        private Label label1;
        private PictureBox pictureBox1;
    }
}