namespace LunaLauncheri30
{
    partial class LunaRocketPanel
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
            richTextBox1 = new RichTextBox();
            label1 = new Label();
            textBox_Input = new TextBox();
            textBox_Output = new TextBox();
            btn_InputAsset = new Button();
            btn_OpenFolder = new Button();
            checkBox_Header = new CheckBox();
            checkBox_Cleanup = new CheckBox();
            btn_Compile = new Button();
            checkBox_Stage = new CheckBox();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox_StageAuthor = new TextBox();
            textBox_StageName = new TextBox();
            label7 = new Label();
            textBox_StageGame = new TextBox();
            textBox_StagePath = new TextBox();
            label8 = new Label();
            Tree_SourceFiles = new TreeView();
            label9 = new Label();
            textBox_SearchTree = new TextBox();
            btn_SearchTree = new Button();
            btn_RefreshTree = new Button();
            btn_LogCopy = new Button();
            btn_ClearLog = new Button();
            pictureBox1 = new PictureBox();
            btn_HelpStage = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            richTextBox1.BackColor = Color.FromArgb(12, 12, 12);
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.ForeColor = SystemColors.ButtonFace;
            richTextBox1.Location = new Point(651, 27);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(444, 581);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(190, 190, 190);
            label1.Location = new Point(651, 9);
            label1.Name = "label1";
            label1.Size = new Size(27, 15);
            label1.TabIndex = 1;
            label1.Text = "Log";
            // 
            // textBox_Input
            // 
            textBox_Input.BackColor = Color.FromArgb(22, 22, 22);
            textBox_Input.BorderStyle = BorderStyle.FixedSingle;
            textBox_Input.ForeColor = SystemColors.ScrollBar;
            textBox_Input.Location = new Point(12, 27);
            textBox_Input.Name = "textBox_Input";
            textBox_Input.ReadOnly = true;
            textBox_Input.Size = new Size(588, 23);
            textBox_Input.TabIndex = 2;
            // 
            // textBox_Output
            // 
            textBox_Output.BackColor = Color.FromArgb(22, 22, 22);
            textBox_Output.BorderStyle = BorderStyle.FixedSingle;
            textBox_Output.ForeColor = SystemColors.ScrollBar;
            textBox_Output.Location = new Point(12, 73);
            textBox_Output.Name = "textBox_Output";
            textBox_Output.ReadOnly = true;
            textBox_Output.Size = new Size(537, 23);
            textBox_Output.TabIndex = 3;
            // 
            // btn_InputAsset
            // 
            btn_InputAsset.Location = new Point(606, 27);
            btn_InputAsset.Name = "btn_InputAsset";
            btn_InputAsset.Size = new Size(39, 23);
            btn_InputAsset.TabIndex = 4;
            btn_InputAsset.Text = "...";
            btn_InputAsset.UseVisualStyleBackColor = true;
            btn_InputAsset.Click += btn_InputAsset_Click;
            // 
            // btn_OpenFolder
            // 
            btn_OpenFolder.Location = new Point(555, 73);
            btn_OpenFolder.Name = "btn_OpenFolder";
            btn_OpenFolder.Size = new Size(90, 23);
            btn_OpenFolder.TabIndex = 5;
            btn_OpenFolder.Text = "Open folder";
            btn_OpenFolder.UseVisualStyleBackColor = true;
            btn_OpenFolder.Click += btn_OpenFolder_Click;
            // 
            // checkBox_Header
            // 
            checkBox_Header.AutoSize = true;
            checkBox_Header.ForeColor = Color.Gainsboro;
            checkBox_Header.Location = new Point(43, 118);
            checkBox_Header.Name = "checkBox_Header";
            checkBox_Header.Size = new Size(93, 19);
            checkBox_Header.TabIndex = 8;
            checkBox_Header.Text = "Swap header";
            checkBox_Header.UseVisualStyleBackColor = true;
            checkBox_Header.CheckedChanged += checkBox_Header_CheckedChanged;
            // 
            // checkBox_Cleanup
            // 
            checkBox_Cleanup.AutoSize = true;
            checkBox_Cleanup.ForeColor = Color.Gainsboro;
            checkBox_Cleanup.Location = new Point(147, 118);
            checkBox_Cleanup.Name = "checkBox_Cleanup";
            checkBox_Cleanup.Size = new Size(124, 19);
            checkBox_Cleanup.TabIndex = 10;
            checkBox_Cleanup.Text = "Cleanup .built files";
            checkBox_Cleanup.UseVisualStyleBackColor = true;
            checkBox_Cleanup.CheckedChanged += checkBox_Cleanup_CheckedChanged;
            // 
            // btn_Compile
            // 
            btn_Compile.Location = new Point(12, 253);
            btn_Compile.Name = "btn_Compile";
            btn_Compile.Size = new Size(633, 40);
            btn_Compile.TabIndex = 11;
            btn_Compile.Text = "Compile";
            btn_Compile.UseVisualStyleBackColor = true;
            btn_Compile.Click += btn_Compile_Click;
            // 
            // checkBox_Stage
            // 
            checkBox_Stage.AutoSize = true;
            checkBox_Stage.Enabled = false;
            checkBox_Stage.ForeColor = Color.Gainsboro;
            checkBox_Stage.Location = new Point(282, 118);
            checkBox_Stage.Name = "checkBox_Stage";
            checkBox_Stage.Size = new Size(96, 19);
            checkBox_Stage.TabIndex = 12;
            checkBox_Stage.Text = "Pack as stage";
            checkBox_Stage.UseVisualStyleBackColor = true;
            checkBox_Stage.CheckedChanged += checkBox_Stage_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(190, 190, 190);
            label2.Location = new Point(9, 9);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 18;
            label2.Text = "Input:";
            label2.TextAlign = ContentAlignment.BottomLeft;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(190, 190, 190);
            label3.Location = new Point(9, 56);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 19;
            label3.Text = "Output:";
            label3.TextAlign = ContentAlignment.BottomLeft;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.FromArgb(120, 120, 120);
            label5.Location = new Point(9, 197);
            label5.Name = "label5";
            label5.Size = new Size(47, 15);
            label5.TabIndex = 23;
            label5.Text = "Author:";
            label5.TextAlign = ContentAlignment.BottomLeft;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.FromArgb(120, 120, 120);
            label6.Location = new Point(9, 150);
            label6.Name = "label6";
            label6.Size = new Size(72, 15);
            label6.TabIndex = 22;
            label6.Text = "Stage name:";
            label6.TextAlign = ContentAlignment.BottomLeft;
            // 
            // textBox_StageAuthor
            // 
            textBox_StageAuthor.BackColor = Color.FromArgb(12, 12, 12);
            textBox_StageAuthor.BorderStyle = BorderStyle.None;
            textBox_StageAuthor.Enabled = false;
            textBox_StageAuthor.ForeColor = SystemColors.ScrollBar;
            textBox_StageAuthor.Location = new Point(12, 214);
            textBox_StageAuthor.Name = "textBox_StageAuthor";
            textBox_StageAuthor.Size = new Size(130, 16);
            textBox_StageAuthor.TabIndex = 21;
            // 
            // textBox_StageName
            // 
            textBox_StageName.BackColor = Color.FromArgb(12, 12, 12);
            textBox_StageName.BorderStyle = BorderStyle.None;
            textBox_StageName.Enabled = false;
            textBox_StageName.ForeColor = SystemColors.ScrollBar;
            textBox_StageName.Location = new Point(12, 168);
            textBox_StageName.Name = "textBox_StageName";
            textBox_StageName.Size = new Size(633, 16);
            textBox_StageName.TabIndex = 20;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.FromArgb(120, 120, 120);
            label7.Location = new Point(144, 197);
            label7.Name = "label7";
            label7.Size = new Size(41, 15);
            label7.TabIndex = 25;
            label7.Text = "Game:";
            label7.TextAlign = ContentAlignment.BottomLeft;
            // 
            // textBox_StageGame
            // 
            textBox_StageGame.BackColor = Color.FromArgb(12, 12, 12);
            textBox_StageGame.BorderStyle = BorderStyle.None;
            textBox_StageGame.Enabled = false;
            textBox_StageGame.ForeColor = SystemColors.ScrollBar;
            textBox_StageGame.Location = new Point(147, 214);
            textBox_StageGame.Name = "textBox_StageGame";
            textBox_StageGame.Size = new Size(100, 16);
            textBox_StageGame.TabIndex = 26;
            textBox_StageGame.Text = "i30";
            // 
            // textBox_StagePath
            // 
            textBox_StagePath.BackColor = Color.FromArgb(12, 12, 12);
            textBox_StagePath.BorderStyle = BorderStyle.None;
            textBox_StagePath.Enabled = false;
            textBox_StagePath.ForeColor = SystemColors.ScrollBar;
            textBox_StagePath.Location = new Point(253, 214);
            textBox_StagePath.Name = "textBox_StagePath";
            textBox_StagePath.Size = new Size(392, 16);
            textBox_StagePath.TabIndex = 27;
            textBox_StagePath.Text = "0/";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.FromArgb(120, 120, 120);
            label8.Location = new Point(250, 196);
            label8.Name = "label8";
            label8.Size = new Size(80, 15);
            label8.TabIndex = 28;
            label8.Text = "New file path:";
            label8.TextAlign = ContentAlignment.BottomLeft;
            // 
            // Tree_SourceFiles
            // 
            Tree_SourceFiles.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            Tree_SourceFiles.BackColor = Color.FromArgb(12, 12, 12);
            Tree_SourceFiles.BorderStyle = BorderStyle.None;
            Tree_SourceFiles.ForeColor = Color.FromArgb(210, 210, 210);
            Tree_SourceFiles.LineColor = Color.FromArgb(119, 204, 221);
            Tree_SourceFiles.Location = new Point(12, 349);
            Tree_SourceFiles.Name = "Tree_SourceFiles";
            Tree_SourceFiles.Size = new Size(633, 259);
            Tree_SourceFiles.TabIndex = 29;
            Tree_SourceFiles.DoubleClick += Tree_SourceFiles_DoubleClick;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.FromArgb(190, 190, 190);
            label9.Location = new Point(9, 302);
            label9.Name = "label9";
            label9.Size = new Size(185, 15);
            label9.TabIndex = 30;
            label9.Text = "File browser (double click to add):";
            label9.TextAlign = ContentAlignment.BottomLeft;
            // 
            // textBox_SearchTree
            // 
            textBox_SearchTree.BackColor = Color.FromArgb(22, 22, 22);
            textBox_SearchTree.BorderStyle = BorderStyle.FixedSingle;
            textBox_SearchTree.ForeColor = SystemColors.ScrollBar;
            textBox_SearchTree.Location = new Point(12, 320);
            textBox_SearchTree.Name = "textBox_SearchTree";
            textBox_SearchTree.Size = new Size(463, 23);
            textBox_SearchTree.TabIndex = 31;
            textBox_SearchTree.KeyDown += textBox_SearchTree_KeyDown;
            // 
            // btn_SearchTree
            // 
            btn_SearchTree.Location = new Point(481, 320);
            btn_SearchTree.Name = "btn_SearchTree";
            btn_SearchTree.Size = new Size(79, 23);
            btn_SearchTree.TabIndex = 32;
            btn_SearchTree.Text = "Search";
            btn_SearchTree.UseVisualStyleBackColor = true;
            btn_SearchTree.Click += btn_SearchTree_Click;
            // 
            // btn_RefreshTree
            // 
            btn_RefreshTree.Location = new Point(566, 320);
            btn_RefreshTree.Name = "btn_RefreshTree";
            btn_RefreshTree.Size = new Size(79, 23);
            btn_RefreshTree.TabIndex = 33;
            btn_RefreshTree.Text = "Refresh";
            btn_RefreshTree.UseVisualStyleBackColor = true;
            btn_RefreshTree.Click += btn_RefreshTree_Click;
            // 
            // btn_LogCopy
            // 
            btn_LogCopy.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_LogCopy.Font = new Font("Segoe UI", 7F);
            btn_LogCopy.Location = new Point(1026, 5);
            btn_LogCopy.Name = "btn_LogCopy";
            btn_LogCopy.Size = new Size(69, 16);
            btn_LogCopy.TabIndex = 34;
            btn_LogCopy.Text = "Copy";
            btn_LogCopy.UseVisualStyleBackColor = true;
            btn_LogCopy.Visible = false;
            btn_LogCopy.Click += btn_LogCopy_Click;
            // 
            // btn_ClearLog
            // 
            btn_ClearLog.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_ClearLog.Font = new Font("Segoe UI", 7F);
            btn_ClearLog.Location = new Point(951, 5);
            btn_ClearLog.Name = "btn_ClearLog";
            btn_ClearLog.Size = new Size(69, 16);
            btn_ClearLog.TabIndex = 35;
            btn_ClearLog.Text = "Clear";
            btn_ClearLog.UseVisualStyleBackColor = true;
            btn_ClearLog.Visible = false;
            btn_ClearLog.Click += btn_ClearLog_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.BackColor = Color.FromArgb(15, 15, 15);
            pictureBox1.BackgroundImage = Resources.EngineIcons.MainLuna;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(651, 517);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(444, 68);
            pictureBox1.TabIndex = 36;
            pictureBox1.TabStop = false;
            // 
            // btn_HelpStage
            // 
            btn_HelpStage.Location = new Point(12, 116);
            btn_HelpStage.Name = "btn_HelpStage";
            btn_HelpStage.Size = new Size(17, 19);
            btn_HelpStage.TabIndex = 37;
            btn_HelpStage.Text = "?";
            btn_HelpStage.UseVisualStyleBackColor = true;
            btn_HelpStage.Click += btn_HelpStage_Click;
            // 
            // LunaRocketPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(22, 22, 22);
            ClientSize = new Size(1107, 620);
            Controls.Add(btn_HelpStage);
            Controls.Add(pictureBox1);
            Controls.Add(btn_ClearLog);
            Controls.Add(btn_LogCopy);
            Controls.Add(btn_RefreshTree);
            Controls.Add(btn_SearchTree);
            Controls.Add(textBox_SearchTree);
            Controls.Add(label9);
            Controls.Add(Tree_SourceFiles);
            Controls.Add(label8);
            Controls.Add(textBox_StagePath);
            Controls.Add(textBox_StageGame);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(textBox_StageAuthor);
            Controls.Add(textBox_StageName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(checkBox_Stage);
            Controls.Add(btn_Compile);
            Controls.Add(checkBox_Cleanup);
            Controls.Add(checkBox_Header);
            Controls.Add(btn_OpenFolder);
            Controls.Add(btn_InputAsset);
            Controls.Add(textBox_Output);
            Controls.Add(textBox_Input);
            Controls.Add(label1);
            Controls.Add(richTextBox1);
            Name = "LunaRocketPanel";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private Label label1;
        private TextBox textBox_Input;
        private TextBox textBox_Output;
        private Button btn_InputAsset;
        private Button btn_OpenFolder;
        private CheckBox checkBox_Header;
        private CheckBox checkBox_Cleanup;
        private Button btn_Compile;
        private CheckBox checkBox_Stage;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label6;
        private TextBox textBox_StageAuthor;
        private TextBox textBox_StageName;
        private Label label7;
        private TextBox textBox_StageGame;
        private TextBox textBox_StagePath;
        private Label label8;
        private TreeView Tree_SourceFiles;
        private Label label9;
        private TextBox textBox_SearchTree;
        private Button btn_SearchTree;
        private Button btn_RefreshTree;
        private Button btn_LogCopy;
        private Button btn_ClearLog;
        private PictureBox pictureBox1;
        private Button btn_HelpStage;
    }
}