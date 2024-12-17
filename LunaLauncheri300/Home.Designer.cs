namespace LunaLauncheri30
{
    partial class Home
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
            pictureBox2 = new PictureBox();
            btn_OpenAsset = new Button();
            btn_RefreshTree = new Button();
            label2 = new Label();
            richTextBox1 = new RichTextBox();
            label1 = new Label();
            treeView1 = new TreeView();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(12, 12, 12);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(btn_OpenAsset);
            panel1.Controls.Add(btn_RefreshTree);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(richTextBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(treeView1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1102, 671);
            panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox2.BackColor = Color.FromArgb(12, 12, 12, 0);
            pictureBox2.BackgroundImage = Resources.EngineIcons.AssetEditor;
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(913, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(23, 23);
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // btn_OpenAsset
            // 
            btn_OpenAsset.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_OpenAsset.BackgroundImageLayout = ImageLayout.Zoom;
            btn_OpenAsset.ImageAlign = ContentAlignment.MiddleLeft;
            btn_OpenAsset.Location = new Point(941, 4);
            btn_OpenAsset.Name = "btn_OpenAsset";
            btn_OpenAsset.Size = new Size(158, 23);
            btn_OpenAsset.TabIndex = 6;
            btn_OpenAsset.Text = "Open in Orbit Asset Editor";
            btn_OpenAsset.UseVisualStyleBackColor = true;
            btn_OpenAsset.Click += btn_OpenAsset_Click;
            // 
            // btn_RefreshTree
            // 
            btn_RefreshTree.Location = new Point(442, 4);
            btn_RefreshTree.Name = "btn_RefreshTree";
            btn_RefreshTree.Size = new Size(75, 23);
            btn_RefreshTree.TabIndex = 5;
            btn_RefreshTree.Text = "Refresh";
            btn_RefreshTree.UseVisualStyleBackColor = true;
            btn_RefreshTree.Click += btn_RefreshTree_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(190, 190, 190);
            label2.Location = new Point(524, -3);
            label2.Name = "label2";
            label2.Size = new Size(25, 15);
            label2.TabIndex = 4;
            label2.Text = "File";
            // 
            // richTextBox1
            // 
            richTextBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            richTextBox1.BackColor = Color.FromArgb(12, 12, 12);
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.ForeColor = SystemColors.Window;
            richTextBox1.Location = new Point(524, 33);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(575, 635);
            richTextBox1.TabIndex = 3;
            richTextBox1.Text = "";
            richTextBox1.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(190, 190, 190);
            label1.Location = new Point(0, -3);
            label1.Name = "label1";
            label1.Size = new Size(244, 15);
            label1.TabIndex = 2;
            label1.Text = "Source folder (double click an asset to open):";
            // 
            // treeView1
            // 
            treeView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            treeView1.BackColor = Color.FromArgb(12, 12, 12);
            treeView1.BorderStyle = BorderStyle.None;
            treeView1.ForeColor = SystemColors.Window;
            treeView1.LineColor = Color.FromArgb(119, 204, 221);
            treeView1.Location = new Point(0, 23);
            treeView1.Name = "treeView1";
            treeView1.Size = new Size(518, 645);
            treeView1.TabIndex = 1;
            treeView1.AfterSelect += treeView1_AfterSelect;
            treeView1.Click += treeView1_Click;
            treeView1.DoubleClick += treeView1_DoubleClick;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.BackColor = Color.FromArgb(12, 12, 12);
            pictureBox1.BackgroundImage = Resources.EngineIcons.MainLuna;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(524, 189);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(575, 200);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(12, 12, 12);
            ClientSize = new Size(1126, 695);
            Controls.Add(panel1);
            Name = "Home";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private TreeView treeView1;
        private Label label1;
        private RichTextBox richTextBox1;
        private Label label2;
        private Button btn_RefreshTree;
        private Button btn_OpenAsset;
        private PictureBox pictureBox2;
    }
}