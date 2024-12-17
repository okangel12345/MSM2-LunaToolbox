namespace LunaLauncheri300
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            MenuMain = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            openAssetToolStripMenuItem = new ToolStripMenuItem();
            newAssetToolStripMenuItem = new ToolStripMenuItem();
            assetWizardToolStripMenuItem = new ToolStripMenuItem();
            importFromFileToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            saveProjectToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem1 = new ToolStripMenuItem();
            lunaServerToolStripMenuItem = new ToolStripMenuItem();
            statusCheckingToolStripMenuItem = new ToolStripMenuItem();
            launchLunaServerToolStripMenuItem = new ToolStripMenuItem();
            closeLunaServerToolStripMenuItem = new ToolStripMenuItem();
            engineToolsToolStripMenuItem = new ToolStripMenuItem();
            vaultToolStripMenuItem = new ToolStripMenuItem();
            orbitAssetEditorToolStripMenuItem = new ToolStripMenuItem();
            bulkAssetEditorToolStripMenuItem = new ToolStripMenuItem();
            insomniacPromptToolStripMenuItem = new ToolStripMenuItem();
            toolsHubToolStripMenuItem = new ToolStripMenuItem();
            levelEditorToolStripMenuItem = new ToolStripMenuItem();
            assetWizardToolStripMenuItem1 = new ToolStripMenuItem();
            moddingToolsToolStripMenuItem = new ToolStripMenuItem();
            moddingToolToolStripMenuItem = new ToolStripMenuItem();
            overstrikeToolStripMenuItem = new ToolStripMenuItem();
            spideyTextureScalerToolStripMenuItem = new ToolStripMenuItem();
            hashToolToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            homeToolStripMenuItem = new ToolStripMenuItem();
            lunaRocketCompilerToolStripMenuItem = new ToolStripMenuItem();
            quickLaunchToolStripMenuItem = new ToolStripMenuItem();
            customizeToolStripMenuItem = new ToolStripMenuItem();
            refreshToolStripMenuItem = new ToolStripMenuItem();
            item1ToolStripMenuItem = new ToolStripMenuItem();
            item2ToolStripMenuItem = new ToolStripMenuItem();
            item3ToolStripMenuItem = new ToolStripMenuItem();
            item4ToolStripMenuItem = new ToolStripMenuItem();
            item5ToolStripMenuItem = new ToolStripMenuItem();
            item6ToolStripMenuItem = new ToolStripMenuItem();
            item7ToolStripMenuItem = new ToolStripMenuItem();
            item8ToolStripMenuItem = new ToolStripMenuItem();
            item9ToolStripMenuItem = new ToolStripMenuItem();
            item10ToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            Main_Panel = new Panel();
            btn_LoadLunaRocketPanel = new Button();
            btn_ModdingToolPanel = new Button();
            btn_OverstrikePanel = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            btn_Home = new Button();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            btn_AtmospherePanel = new Button();
            pictureBox6 = new PictureBox();
            btn_ModelToolPanel = new Button();
            pictureBox7 = new PictureBox();
            btn_LoadGameIntegrationPanel = new Button();
            checkBox_Experiments = new CheckBox();
            MenuMain.SuspendLayout();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            SuspendLayout();
            // 
            // MenuMain
            // 
            MenuMain.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, lunaServerToolStripMenuItem, engineToolsToolStripMenuItem, moddingToolsToolStripMenuItem, helpToolStripMenuItem, quickLaunchToolStripMenuItem });
            MenuMain.Location = new Point(0, 0);
            MenuMain.Name = "MenuMain";
            MenuMain.Size = new Size(1145, 24);
            MenuMain.TabIndex = 0;
            MenuMain.Text = "Main Menu";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openAssetToolStripMenuItem, newAssetToolStripMenuItem, exitToolStripMenuItem, saveProjectToolStripMenuItem, exitToolStripMenuItem1 });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            fileToolStripMenuItem.Visible = false;
            // 
            // openAssetToolStripMenuItem
            // 
            openAssetToolStripMenuItem.Name = "openAssetToolStripMenuItem";
            openAssetToolStripMenuItem.Size = new Size(143, 22);
            openAssetToolStripMenuItem.Text = "Open Asset";
            // 
            // newAssetToolStripMenuItem
            // 
            newAssetToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { assetWizardToolStripMenuItem, importFromFileToolStripMenuItem });
            newAssetToolStripMenuItem.Name = "newAssetToolStripMenuItem";
            newAssetToolStripMenuItem.Size = new Size(143, 22);
            newAssetToolStripMenuItem.Text = "New Asset";
            // 
            // assetWizardToolStripMenuItem
            // 
            assetWizardToolStripMenuItem.Image = LunaLauncheri30.Resources.EngineIcons.AssetWizard;
            assetWizardToolStripMenuItem.Name = "assetWizardToolStripMenuItem";
            assetWizardToolStripMenuItem.Size = new Size(158, 22);
            assetWizardToolStripMenuItem.Text = "Asset Wizard";
            // 
            // importFromFileToolStripMenuItem
            // 
            importFromFileToolStripMenuItem.Name = "importFromFileToolStripMenuItem";
            importFromFileToolStripMenuItem.Size = new Size(158, 22);
            importFromFileToolStripMenuItem.Text = "Import from file";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(143, 22);
            exitToolStripMenuItem.Text = "Open Project";
            // 
            // saveProjectToolStripMenuItem
            // 
            saveProjectToolStripMenuItem.Name = "saveProjectToolStripMenuItem";
            saveProjectToolStripMenuItem.Size = new Size(143, 22);
            saveProjectToolStripMenuItem.Text = "Save Project";
            // 
            // exitToolStripMenuItem1
            // 
            exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            exitToolStripMenuItem1.Size = new Size(143, 22);
            exitToolStripMenuItem1.Text = "Exit";
            // 
            // lunaServerToolStripMenuItem
            // 
            lunaServerToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { statusCheckingToolStripMenuItem, launchLunaServerToolStripMenuItem, closeLunaServerToolStripMenuItem });
            lunaServerToolStripMenuItem.Name = "lunaServerToolStripMenuItem";
            lunaServerToolStripMenuItem.Size = new Size(80, 20);
            lunaServerToolStripMenuItem.Text = "Luna Server";
            // 
            // statusCheckingToolStripMenuItem
            // 
            statusCheckingToolStripMenuItem.Image = LunaLauncheri30.Resources.EngineIcons.InsomLogo2;
            statusCheckingToolStripMenuItem.Name = "statusCheckingToolStripMenuItem";
            statusCheckingToolStripMenuItem.Size = new Size(251, 22);
            statusCheckingToolStripMenuItem.Text = "Status: Checking...";
            // 
            // launchLunaServerToolStripMenuItem
            // 
            launchLunaServerToolStripMenuItem.Name = "launchLunaServerToolStripMenuItem";
            launchLunaServerToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Enter;
            launchLunaServerToolStripMenuItem.Size = new Size(251, 22);
            launchLunaServerToolStripMenuItem.Text = "Launch Luna Server";
            launchLunaServerToolStripMenuItem.Visible = false;
            launchLunaServerToolStripMenuItem.Click += launchLunaServerToolStripMenuItem_Click;
            // 
            // closeLunaServerToolStripMenuItem
            // 
            closeLunaServerToolStripMenuItem.Name = "closeLunaServerToolStripMenuItem";
            closeLunaServerToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Alt | Keys.Enter;
            closeLunaServerToolStripMenuItem.Size = new Size(251, 22);
            closeLunaServerToolStripMenuItem.Text = "Close Luna Server";
            closeLunaServerToolStripMenuItem.Visible = false;
            closeLunaServerToolStripMenuItem.Click += closeLunaServerToolStripMenuItem_Click;
            // 
            // engineToolsToolStripMenuItem
            // 
            engineToolsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { vaultToolStripMenuItem, orbitAssetEditorToolStripMenuItem, bulkAssetEditorToolStripMenuItem, insomniacPromptToolStripMenuItem, toolsHubToolStripMenuItem, levelEditorToolStripMenuItem, assetWizardToolStripMenuItem1 });
            engineToolsToolStripMenuItem.Name = "engineToolsToolStripMenuItem";
            engineToolsToolStripMenuItem.Size = new Size(85, 20);
            engineToolsToolStripMenuItem.Text = "Engine Tools";
            // 
            // vaultToolStripMenuItem
            // 
            vaultToolStripMenuItem.Image = LunaLauncheri30.Resources.EngineIcons.Vault;
            vaultToolStripMenuItem.Name = "vaultToolStripMenuItem";
            vaultToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.D1;
            vaultToolStripMenuItem.Size = new Size(212, 22);
            vaultToolStripMenuItem.Text = "Vault";
            vaultToolStripMenuItem.Click += vaultToolStripMenuItem_Click;
            // 
            // orbitAssetEditorToolStripMenuItem
            // 
            orbitAssetEditorToolStripMenuItem.Image = LunaLauncheri30.Resources.EngineIcons.AssetEditor;
            orbitAssetEditorToolStripMenuItem.Name = "orbitAssetEditorToolStripMenuItem";
            orbitAssetEditorToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.D2;
            orbitAssetEditorToolStripMenuItem.Size = new Size(212, 22);
            orbitAssetEditorToolStripMenuItem.Text = "Orbit Asset Editor";
            orbitAssetEditorToolStripMenuItem.Click += orbitAssetEditorToolStripMenuItem_Click;
            // 
            // bulkAssetEditorToolStripMenuItem
            // 
            bulkAssetEditorToolStripMenuItem.Image = LunaLauncheri30.Resources.EngineIcons.Bulk;
            bulkAssetEditorToolStripMenuItem.Name = "bulkAssetEditorToolStripMenuItem";
            bulkAssetEditorToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.D3;
            bulkAssetEditorToolStripMenuItem.Size = new Size(212, 22);
            bulkAssetEditorToolStripMenuItem.Text = "Bulk Asset Editor";
            bulkAssetEditorToolStripMenuItem.Click += bulkAssetEditorToolStripMenuItem_Click;
            // 
            // insomniacPromptToolStripMenuItem
            // 
            insomniacPromptToolStripMenuItem.Image = LunaLauncheri30.Resources.EngineIcons.Prompt;
            insomniacPromptToolStripMenuItem.Name = "insomniacPromptToolStripMenuItem";
            insomniacPromptToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.D4;
            insomniacPromptToolStripMenuItem.Size = new Size(212, 22);
            insomniacPromptToolStripMenuItem.Text = "Insomniac Prompt";
            insomniacPromptToolStripMenuItem.Click += insomniacPromptToolStripMenuItem_Click;
            // 
            // toolsHubToolStripMenuItem
            // 
            toolsHubToolStripMenuItem.Image = LunaLauncheri30.Resources.EngineIcons.ToolsHub;
            toolsHubToolStripMenuItem.Name = "toolsHubToolStripMenuItem";
            toolsHubToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.D5;
            toolsHubToolStripMenuItem.Size = new Size(212, 22);
            toolsHubToolStripMenuItem.Text = "Tools Hub";
            toolsHubToolStripMenuItem.Click += toolsHubToolStripMenuItem_Click;
            // 
            // levelEditorToolStripMenuItem
            // 
            levelEditorToolStripMenuItem.Image = LunaLauncheri30.Resources.EngineIcons.LevelEditor;
            levelEditorToolStripMenuItem.Name = "levelEditorToolStripMenuItem";
            levelEditorToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.D6;
            levelEditorToolStripMenuItem.Size = new Size(212, 22);
            levelEditorToolStripMenuItem.Text = "Level Editor";
            levelEditorToolStripMenuItem.Click += levelEditorToolStripMenuItem_Click;
            // 
            // assetWizardToolStripMenuItem1
            // 
            assetWizardToolStripMenuItem1.Image = LunaLauncheri30.Resources.EngineIcons.AssetWizard;
            assetWizardToolStripMenuItem1.Name = "assetWizardToolStripMenuItem1";
            assetWizardToolStripMenuItem1.ShortcutKeys = Keys.Control | Keys.D0;
            assetWizardToolStripMenuItem1.Size = new Size(212, 22);
            assetWizardToolStripMenuItem1.Text = "Asset Wizard";
            assetWizardToolStripMenuItem1.Click += assetWizardToolStripMenuItem1_Click;
            // 
            // moddingToolsToolStripMenuItem
            // 
            moddingToolsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { moddingToolToolStripMenuItem, overstrikeToolStripMenuItem, spideyTextureScalerToolStripMenuItem, hashToolToolStripMenuItem });
            moddingToolsToolStripMenuItem.Name = "moddingToolsToolStripMenuItem";
            moddingToolsToolStripMenuItem.Size = new Size(58, 20);
            moddingToolsToolStripMenuItem.Text = "Utilities";
            // 
            // moddingToolToolStripMenuItem
            // 
            moddingToolToolStripMenuItem.Image = LunaLauncheri30.Resources.EngineIcons.ModdingTool;
            moddingToolToolStripMenuItem.Name = "moddingToolToolStripMenuItem";
            moddingToolToolStripMenuItem.Size = new Size(184, 22);
            moddingToolToolStripMenuItem.Text = "Modding Tool";
            moddingToolToolStripMenuItem.Visible = false;
            moddingToolToolStripMenuItem.Click += moddingToolToolStripMenuItem_Click;
            // 
            // overstrikeToolStripMenuItem
            // 
            overstrikeToolStripMenuItem.Image = LunaLauncheri30.Resources.EngineIcons.Overstrike;
            overstrikeToolStripMenuItem.Name = "overstrikeToolStripMenuItem";
            overstrikeToolStripMenuItem.Size = new Size(184, 22);
            overstrikeToolStripMenuItem.Text = "Overstrike";
            overstrikeToolStripMenuItem.Visible = false;
            overstrikeToolStripMenuItem.Click += overstrikeToolStripMenuItem_Click;
            // 
            // spideyTextureScalerToolStripMenuItem
            // 
            spideyTextureScalerToolStripMenuItem.Image = LunaLauncheri30.Resources.EngineIcons.Spidey2;
            spideyTextureScalerToolStripMenuItem.Name = "spideyTextureScalerToolStripMenuItem";
            spideyTextureScalerToolStripMenuItem.Size = new Size(184, 22);
            spideyTextureScalerToolStripMenuItem.Text = "Spidey Texture Scaler";
            spideyTextureScalerToolStripMenuItem.Click += spideyTextureScalerToolStripMenuItem_Click;
            // 
            // hashToolToolStripMenuItem
            // 
            hashToolToolStripMenuItem.Image = LunaLauncheri30.Resources.EngineIcons.HashNew2;
            hashToolToolStripMenuItem.Name = "hashToolToolStripMenuItem";
            hashToolToolStripMenuItem.Size = new Size(184, 22);
            hashToolToolStripMenuItem.Text = "Hash Tool";
            hashToolToolStripMenuItem.Click += hashToolToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { homeToolStripMenuItem, lunaRocketCompilerToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(44, 20);
            helpToolStripMenuItem.Text = "Help";
            // 
            // homeToolStripMenuItem
            // 
            homeToolStripMenuItem.Image = LunaLauncheri30.Resources.EngineIcons.InsomLogo2;
            homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            homeToolStripMenuItem.ShortcutKeys = Keys.F1;
            homeToolStripMenuItem.Size = new Size(210, 22);
            homeToolStripMenuItem.Text = "Insomniac Engine";
            homeToolStripMenuItem.Click += homeToolStripMenuItem_Click;
            // 
            // lunaRocketCompilerToolStripMenuItem
            // 
            lunaRocketCompilerToolStripMenuItem.Image = LunaLauncheri30.Resources.EngineIcons.RocketBw;
            lunaRocketCompilerToolStripMenuItem.Name = "lunaRocketCompilerToolStripMenuItem";
            lunaRocketCompilerToolStripMenuItem.ShortcutKeys = Keys.F2;
            lunaRocketCompilerToolStripMenuItem.Size = new Size(210, 22);
            lunaRocketCompilerToolStripMenuItem.Text = "Luna Rocket Compiler";
            lunaRocketCompilerToolStripMenuItem.Click += lunaRocketCompilerToolStripMenuItem_Click;
            // 
            // quickLaunchToolStripMenuItem
            // 
            quickLaunchToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { customizeToolStripMenuItem, refreshToolStripMenuItem, item1ToolStripMenuItem, item2ToolStripMenuItem, item3ToolStripMenuItem, item4ToolStripMenuItem, item5ToolStripMenuItem, item6ToolStripMenuItem, item7ToolStripMenuItem, item8ToolStripMenuItem, item9ToolStripMenuItem, item10ToolStripMenuItem });
            quickLaunchToolStripMenuItem.Image = LunaLauncheri30.Resources.EngineIcons.LinkDark;
            quickLaunchToolStripMenuItem.Name = "quickLaunchToolStripMenuItem";
            quickLaunchToolStripMenuItem.Size = new Size(108, 20);
            quickLaunchToolStripMenuItem.Text = "Quick Launch";
            // 
            // customizeToolStripMenuItem
            // 
            customizeToolStripMenuItem.Image = LunaLauncheri30.Resources.EngineIcons.Banner2;
            customizeToolStripMenuItem.Name = "customizeToolStripMenuItem";
            customizeToolStripMenuItem.Size = new Size(185, 22);
            customizeToolStripMenuItem.Text = "Customize items";
            customizeToolStripMenuItem.Click += customizeToolStripMenuItem_Click;
            // 
            // refreshToolStripMenuItem
            // 
            refreshToolStripMenuItem.Image = LunaLauncheri30.Resources.EngineIcons.Refresh;
            refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            refreshToolStripMenuItem.ShortcutKeys = Keys.F5;
            refreshToolStripMenuItem.Size = new Size(185, 22);
            refreshToolStripMenuItem.Text = "Refresh";
            refreshToolStripMenuItem.Click += refreshToolStripMenuItem_Click;
            // 
            // item1ToolStripMenuItem
            // 
            item1ToolStripMenuItem.Name = "item1ToolStripMenuItem";
            item1ToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.D1;
            item1ToolStripMenuItem.Size = new Size(185, 22);
            item1ToolStripMenuItem.Text = "Item 1";
            item1ToolStripMenuItem.Click += item1ToolStripMenuItem_Click;
            // 
            // item2ToolStripMenuItem
            // 
            item2ToolStripMenuItem.Name = "item2ToolStripMenuItem";
            item2ToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.D2;
            item2ToolStripMenuItem.Size = new Size(185, 22);
            item2ToolStripMenuItem.Text = "Item 2";
            item2ToolStripMenuItem.Click += item2ToolStripMenuItem_Click;
            // 
            // item3ToolStripMenuItem
            // 
            item3ToolStripMenuItem.Name = "item3ToolStripMenuItem";
            item3ToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.D3;
            item3ToolStripMenuItem.Size = new Size(185, 22);
            item3ToolStripMenuItem.Text = "Item 3";
            item3ToolStripMenuItem.Click += item3ToolStripMenuItem_Click;
            // 
            // item4ToolStripMenuItem
            // 
            item4ToolStripMenuItem.Name = "item4ToolStripMenuItem";
            item4ToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.D4;
            item4ToolStripMenuItem.Size = new Size(185, 22);
            item4ToolStripMenuItem.Text = "Item 4";
            item4ToolStripMenuItem.Click += item4ToolStripMenuItem_Click;
            // 
            // item5ToolStripMenuItem
            // 
            item5ToolStripMenuItem.Name = "item5ToolStripMenuItem";
            item5ToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.D5;
            item5ToolStripMenuItem.Size = new Size(185, 22);
            item5ToolStripMenuItem.Text = "Item 5";
            item5ToolStripMenuItem.Click += item5ToolStripMenuItem_Click;
            // 
            // item6ToolStripMenuItem
            // 
            item6ToolStripMenuItem.Name = "item6ToolStripMenuItem";
            item6ToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.D6;
            item6ToolStripMenuItem.Size = new Size(185, 22);
            item6ToolStripMenuItem.Text = "Item 6";
            item6ToolStripMenuItem.Click += item6ToolStripMenuItem_Click;
            // 
            // item7ToolStripMenuItem
            // 
            item7ToolStripMenuItem.Name = "item7ToolStripMenuItem";
            item7ToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.D7;
            item7ToolStripMenuItem.Size = new Size(185, 22);
            item7ToolStripMenuItem.Text = "Item 7";
            item7ToolStripMenuItem.Click += item7ToolStripMenuItem_Click;
            // 
            // item8ToolStripMenuItem
            // 
            item8ToolStripMenuItem.Name = "item8ToolStripMenuItem";
            item8ToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.D8;
            item8ToolStripMenuItem.Size = new Size(185, 22);
            item8ToolStripMenuItem.Text = "Item 8";
            item8ToolStripMenuItem.Click += item8ToolStripMenuItem_Click;
            // 
            // item9ToolStripMenuItem
            // 
            item9ToolStripMenuItem.Name = "item9ToolStripMenuItem";
            item9ToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.D9;
            item9ToolStripMenuItem.Size = new Size(185, 22);
            item9ToolStripMenuItem.Text = "Item 9";
            item9ToolStripMenuItem.Click += item9ToolStripMenuItem_Click;
            // 
            // item10ToolStripMenuItem
            // 
            item10ToolStripMenuItem.Name = "item10ToolStripMenuItem";
            item10ToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.D0;
            item10ToolStripMenuItem.Size = new Size(185, 22);
            item10ToolStripMenuItem.Text = "Item 10";
            item10ToolStripMenuItem.Click += item10ToolStripMenuItem_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.BackColor = Color.Black;
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 617);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1145, 22);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.ForeColor = Color.FromArgb(170, 170, 170);
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(168, 17);
            toolStripStatusLabel1.Text = "Luna Server Status: Checking...";
            // 
            // Main_Panel
            // 
            Main_Panel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Main_Panel.BackColor = Color.Black;
            Main_Panel.Location = new Point(0, 56);
            Main_Panel.Name = "Main_Panel";
            Main_Panel.Size = new Size(1145, 558);
            Main_Panel.TabIndex = 3;
            // 
            // btn_LoadLunaRocketPanel
            // 
            btn_LoadLunaRocketPanel.BackColor = Color.FromArgb(22, 22, 22);
            btn_LoadLunaRocketPanel.Location = new Point(148, 27);
            btn_LoadLunaRocketPanel.Name = "btn_LoadLunaRocketPanel";
            btn_LoadLunaRocketPanel.Size = new Size(139, 23);
            btn_LoadLunaRocketPanel.TabIndex = 4;
            btn_LoadLunaRocketPanel.Text = "Luna Rocket Compiler";
            btn_LoadLunaRocketPanel.UseVisualStyleBackColor = false;
            btn_LoadLunaRocketPanel.Click += btn_LoadLunaRocketPanel_Click;
            // 
            // btn_ModdingToolPanel
            // 
            btn_ModdingToolPanel.BackColor = Color.FromArgb(22, 22, 22);
            btn_ModdingToolPanel.Location = new Point(318, 27);
            btn_ModdingToolPanel.Name = "btn_ModdingToolPanel";
            btn_ModdingToolPanel.Size = new Size(89, 23);
            btn_ModdingToolPanel.TabIndex = 5;
            btn_ModdingToolPanel.Text = "Modding Tool";
            btn_ModdingToolPanel.UseVisualStyleBackColor = false;
            btn_ModdingToolPanel.Click += btn_ModdingToolPanel_Click;
            // 
            // btn_OverstrikePanel
            // 
            btn_OverstrikePanel.BackColor = Color.FromArgb(22, 22, 22);
            btn_OverstrikePanel.Location = new Point(438, 27);
            btn_OverstrikePanel.Name = "btn_OverstrikePanel";
            btn_OverstrikePanel.Size = new Size(79, 23);
            btn_OverstrikePanel.TabIndex = 6;
            btn_OverstrikePanel.Text = "Overstrike";
            btn_OverstrikePanel.UseVisualStyleBackColor = false;
            btn_OverstrikePanel.Click += btn_OverstrikePanel_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = LunaLauncheri30.Resources.EngineIcons.ModdingToolBw;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(293, 29);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(19, 19);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = LunaLauncheri30.Resources.EngineIcons.OverstrikeBw;
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(413, 29);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(19, 19);
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // btn_Home
            // 
            btn_Home.BackColor = Color.FromArgb(22, 22, 22);
            btn_Home.Location = new Point(38, 27);
            btn_Home.Name = "btn_Home";
            btn_Home.Size = new Size(79, 23);
            btn_Home.TabIndex = 9;
            btn_Home.Text = "Home";
            btn_Home.UseVisualStyleBackColor = false;
            btn_Home.Click += btn_Home_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = LunaLauncheri30.Resources.EngineIcons.RocketBw;
            pictureBox3.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox3.Location = new Point(123, 29);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(19, 19);
            pictureBox3.TabIndex = 10;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImage = LunaLauncheri30.Resources.EngineIcons.Home;
            pictureBox4.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox4.Location = new Point(9, 26);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(23, 23);
            pictureBox4.TabIndex = 11;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.BackgroundImage = LunaLauncheri30.Resources.EngineIcons.OverstrikeBw;
            pictureBox5.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox5.Location = new Point(876, 31);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(19, 19);
            pictureBox5.TabIndex = 13;
            pictureBox5.TabStop = false;
            pictureBox5.Visible = false;
            // 
            // btn_AtmospherePanel
            // 
            btn_AtmospherePanel.BackColor = Color.FromArgb(22, 22, 22);
            btn_AtmospherePanel.Location = new Point(901, 29);
            btn_AtmospherePanel.Name = "btn_AtmospherePanel";
            btn_AtmospherePanel.Size = new Size(120, 23);
            btn_AtmospherePanel.TabIndex = 12;
            btn_AtmospherePanel.Text = "Atmosphere Tool";
            btn_AtmospherePanel.UseVisualStyleBackColor = false;
            btn_AtmospherePanel.Visible = false;
            btn_AtmospherePanel.Click += btn_AtmospherePanel_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.BackgroundImage = LunaLauncheri30.Resources.EngineIcons.Model;
            pictureBox6.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox6.Location = new Point(523, 29);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(19, 19);
            pictureBox6.TabIndex = 15;
            pictureBox6.TabStop = false;
            // 
            // btn_ModelToolPanel
            // 
            btn_ModelToolPanel.BackColor = Color.FromArgb(22, 22, 22);
            btn_ModelToolPanel.Location = new Point(548, 27);
            btn_ModelToolPanel.Name = "btn_ModelToolPanel";
            btn_ModelToolPanel.Size = new Size(79, 23);
            btn_ModelToolPanel.TabIndex = 14;
            btn_ModelToolPanel.Text = "Model Tool";
            btn_ModelToolPanel.UseVisualStyleBackColor = false;
            btn_ModelToolPanel.Click += btn_ModelToolPanel_Click;
            // 
            // pictureBox7
            // 
            pictureBox7.BackgroundImage = LunaLauncheri30.Resources.EngineIcons.Controller;
            pictureBox7.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox7.Location = new Point(633, 29);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(19, 19);
            pictureBox7.TabIndex = 17;
            pictureBox7.TabStop = false;
            pictureBox7.Visible = false;
            // 
            // btn_LoadGameIntegrationPanel
            // 
            btn_LoadGameIntegrationPanel.BackColor = Color.FromArgb(22, 22, 22);
            btn_LoadGameIntegrationPanel.Location = new Point(658, 27);
            btn_LoadGameIntegrationPanel.Name = "btn_LoadGameIntegrationPanel";
            btn_LoadGameIntegrationPanel.Size = new Size(76, 23);
            btn_LoadGameIntegrationPanel.TabIndex = 16;
            btn_LoadGameIntegrationPanel.Text = "Run game";
            btn_LoadGameIntegrationPanel.UseVisualStyleBackColor = false;
            btn_LoadGameIntegrationPanel.Visible = false;
            btn_LoadGameIntegrationPanel.Click += btn_LoadGameIntegrationPanel_Click;
            // 
            // checkBox_Experiments
            // 
            checkBox_Experiments.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            checkBox_Experiments.AutoSize = true;
            checkBox_Experiments.ForeColor = Color.FromArgb(190, 190, 190);
            checkBox_Experiments.Location = new Point(1050, 32);
            checkBox_Experiments.Name = "checkBox_Experiments";
            checkBox_Experiments.Size = new Size(91, 19);
            checkBox_Experiments.TabIndex = 18;
            checkBox_Experiments.Text = "Experiments";
            checkBox_Experiments.UseVisualStyleBackColor = true;
            checkBox_Experiments.CheckedChanged += checkBox_Experiments_CheckedChanged;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(22, 22, 22);
            ClientSize = new Size(1145, 639);
            Controls.Add(checkBox_Experiments);
            Controls.Add(pictureBox7);
            Controls.Add(btn_LoadGameIntegrationPanel);
            Controls.Add(pictureBox6);
            Controls.Add(btn_ModelToolPanel);
            Controls.Add(pictureBox5);
            Controls.Add(btn_AtmospherePanel);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(btn_Home);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(btn_OverstrikePanel);
            Controls.Add(btn_ModdingToolPanel);
            Controls.Add(btn_LoadLunaRocketPanel);
            Controls.Add(Main_Panel);
            Controls.Add(statusStrip1);
            Controls.Add(MenuMain);
            ForeColor = SystemColors.Control;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = MenuMain;
            MinimumSize = new Size(750, 380);
            Name = "MainWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Luna Toolbox";
            FormClosing += MainWindow_FormClosing;
            MenuMain.ResumeLayout(false);
            MenuMain.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip MenuMain;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newAssetToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem lunaServerToolStripMenuItem;
        private ToolStripMenuItem statusCheckingToolStripMenuItem;
        private ToolStripMenuItem launchLunaServerToolStripMenuItem;
        private ToolStripMenuItem closeLunaServerToolStripMenuItem;
        private ToolStripMenuItem engineToolsToolStripMenuItem;
        private ToolStripMenuItem vaultToolStripMenuItem;
        private ToolStripMenuItem orbitAssetEditorToolStripMenuItem;
        private ToolStripMenuItem bulkAssetEditorToolStripMenuItem;
        private ToolStripMenuItem insomniacPromptToolStripMenuItem;
        private ToolStripMenuItem toolsHubToolStripMenuItem;
        private ToolStripMenuItem levelEditorToolStripMenuItem;
        private ToolStripMenuItem saveProjectToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem1;
        private ToolStripMenuItem moddingToolsToolStripMenuItem;
        private ToolStripMenuItem moddingToolToolStripMenuItem;
        private ToolStripMenuItem overstrikeToolStripMenuItem;
        private ToolStripMenuItem spideyTextureScalerToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem openAssetToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private Panel Main_Panel;
        private ToolStripMenuItem assetWizardToolStripMenuItem;
        private ToolStripMenuItem importFromFileToolStripMenuItem;
        private Button btn_LoadLunaRocketPanel;
        private Button btn_ModdingToolPanel;
        private Button btn_OverstrikePanel;
        private System.Windows.Forms.Timer timer1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button btn_Home;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private ToolStripMenuItem homeToolStripMenuItem;
        private ToolStripMenuItem lunaRocketCompilerToolStripMenuItem;
        private PictureBox pictureBox5;
        private Button btn_AtmospherePanel;
        private PictureBox pictureBox6;
        private Button btn_ModelToolPanel;
        private ToolStripMenuItem hashToolToolStripMenuItem;
        private ToolStripMenuItem assetWizardToolStripMenuItem1;
        private ToolStripMenuItem quickLaunchToolStripMenuItem;
        private ToolStripMenuItem customizeToolStripMenuItem;
        private ToolStripMenuItem item1ToolStripMenuItem;
        private ToolStripMenuItem item2ToolStripMenuItem;
        private ToolStripMenuItem item3ToolStripMenuItem;
        private ToolStripMenuItem item4ToolStripMenuItem;
        private ToolStripMenuItem item5ToolStripMenuItem;
        private ToolStripMenuItem item6ToolStripMenuItem;
        private ToolStripMenuItem item7ToolStripMenuItem;
        private ToolStripMenuItem item8ToolStripMenuItem;
        private ToolStripMenuItem item9ToolStripMenuItem;
        private ToolStripMenuItem item10ToolStripMenuItem;
        private ToolStripMenuItem refreshToolStripMenuItem;
        private PictureBox pictureBox7;
        private Button btn_LoadGameIntegrationPanel;
        private CheckBox checkBox_Experiments;
    }
}
