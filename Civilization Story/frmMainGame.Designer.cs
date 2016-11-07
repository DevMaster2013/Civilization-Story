namespace Civilization_Story
{
    partial class frmMainGame
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
            this.components = new System.ComponentModel.Container();
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.loadGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveGameAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.gameSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.exitGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.grbPlayerSummary = new System.Windows.Forms.GroupBox();
            this.lnkSettlementsCount = new System.Windows.Forms.LinkLabel();
            this.lblSettlementsCount = new System.Windows.Forms.Label();
            this.lnkPopulation = new System.Windows.Forms.LinkLabel();
            this.lblPopulation = new System.Windows.Forms.Label();
            this.lnkFactionName = new System.Windows.Forms.LinkLabel();
            this.lnkPlayerName = new System.Windows.Forms.LinkLabel();
            this.lblFactionName = new System.Windows.Forms.Label();
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.gameStatus = new System.Windows.Forms.StatusStrip();
            this.toolStripCurrentTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.grbWorldSummary = new System.Windows.Forms.GroupBox();
            this.lnkFactionsCount = new System.Windows.Forms.LinkLabel();
            this.lblFactionsCount = new System.Windows.Forms.Label();
            this.menuMain.SuspendLayout();
            this.grbPlayerSummary.SuspendLayout();
            this.gameStatus.SuspendLayout();
            this.grbWorldSummary.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuMain
            // 
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameToolStripMenuItem});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Size = new System.Drawing.Size(346, 24);
            this.menuMain.TabIndex = 0;
            this.menuMain.Text = "menuStrip1";
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createGameToolStripMenuItem,
            this.toolStripMenuItem1,
            this.loadGameToolStripMenuItem,
            this.saveGameToolStripMenuItem,
            this.saveGameAsToolStripMenuItem,
            this.toolStripMenuItem2,
            this.gameSettingsToolStripMenuItem,
            this.toolStripMenuItem3,
            this.exitGameToolStripMenuItem});
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.gameToolStripMenuItem.Text = "Game";
            // 
            // createGameToolStripMenuItem
            // 
            this.createGameToolStripMenuItem.Name = "createGameToolStripMenuItem";
            this.createGameToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.createGameToolStripMenuItem.Text = "Create Game";
            this.createGameToolStripMenuItem.Click += new System.EventHandler(this.createGameToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(147, 6);
            // 
            // loadGameToolStripMenuItem
            // 
            this.loadGameToolStripMenuItem.Name = "loadGameToolStripMenuItem";
            this.loadGameToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.loadGameToolStripMenuItem.Text = "Load Game";
            // 
            // saveGameToolStripMenuItem
            // 
            this.saveGameToolStripMenuItem.Name = "saveGameToolStripMenuItem";
            this.saveGameToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.saveGameToolStripMenuItem.Text = "Save Game";
            // 
            // saveGameAsToolStripMenuItem
            // 
            this.saveGameAsToolStripMenuItem.Name = "saveGameAsToolStripMenuItem";
            this.saveGameAsToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.saveGameAsToolStripMenuItem.Text = "Save Game As";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(147, 6);
            // 
            // gameSettingsToolStripMenuItem
            // 
            this.gameSettingsToolStripMenuItem.Name = "gameSettingsToolStripMenuItem";
            this.gameSettingsToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.gameSettingsToolStripMenuItem.Text = "Game Settings";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(147, 6);
            // 
            // exitGameToolStripMenuItem
            // 
            this.exitGameToolStripMenuItem.Name = "exitGameToolStripMenuItem";
            this.exitGameToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.exitGameToolStripMenuItem.Text = "Exit Game";
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 1000;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // grbPlayerSummary
            // 
            this.grbPlayerSummary.Controls.Add(this.lnkSettlementsCount);
            this.grbPlayerSummary.Controls.Add(this.lblSettlementsCount);
            this.grbPlayerSummary.Controls.Add(this.lnkPopulation);
            this.grbPlayerSummary.Controls.Add(this.lblPopulation);
            this.grbPlayerSummary.Controls.Add(this.lnkFactionName);
            this.grbPlayerSummary.Controls.Add(this.lnkPlayerName);
            this.grbPlayerSummary.Controls.Add(this.lblFactionName);
            this.grbPlayerSummary.Controls.Add(this.lblPlayerName);
            this.grbPlayerSummary.Location = new System.Drawing.Point(12, 80);
            this.grbPlayerSummary.Name = "grbPlayerSummary";
            this.grbPlayerSummary.Size = new System.Drawing.Size(322, 116);
            this.grbPlayerSummary.TabIndex = 2;
            this.grbPlayerSummary.TabStop = false;
            this.grbPlayerSummary.Text = "Player Faction Summary";
            // 
            // lnkSettlementsCount
            // 
            this.lnkSettlementsCount.AutoSize = true;
            this.lnkSettlementsCount.Location = new System.Drawing.Point(122, 88);
            this.lnkSettlementsCount.Name = "lnkSettlementsCount";
            this.lnkSettlementsCount.Size = new System.Drawing.Size(53, 13);
            this.lnkSettlementsCount.TabIndex = 5;
            this.lnkSettlementsCount.TabStop = true;
            this.lnkSettlementsCount.Text = "linkLabel3";
            // 
            // lblSettlementsCount
            // 
            this.lblSettlementsCount.AutoSize = true;
            this.lblSettlementsCount.Location = new System.Drawing.Point(13, 88);
            this.lblSettlementsCount.Name = "lblSettlementsCount";
            this.lblSettlementsCount.Size = new System.Drawing.Size(103, 13);
            this.lblSettlementsCount.TabIndex = 4;
            this.lblSettlementsCount.Text = "Settlements Count :";
            // 
            // lnkPopulation
            // 
            this.lnkPopulation.AutoSize = true;
            this.lnkPopulation.Location = new System.Drawing.Point(122, 66);
            this.lnkPopulation.Name = "lnkPopulation";
            this.lnkPopulation.Size = new System.Drawing.Size(53, 13);
            this.lnkPopulation.TabIndex = 5;
            this.lnkPopulation.TabStop = true;
            this.lnkPopulation.Text = "linkLabel3";
            this.lnkPopulation.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkPopulation_LinkClicked);
            // 
            // lblPopulation
            // 
            this.lblPopulation.AutoSize = true;
            this.lblPopulation.Location = new System.Drawing.Point(13, 66);
            this.lblPopulation.Name = "lblPopulation";
            this.lblPopulation.Size = new System.Drawing.Size(64, 13);
            this.lblPopulation.TabIndex = 4;
            this.lblPopulation.Text = "Population :";
            // 
            // lnkFactionName
            // 
            this.lnkFactionName.AutoSize = true;
            this.lnkFactionName.Location = new System.Drawing.Point(122, 43);
            this.lnkFactionName.Name = "lnkFactionName";
            this.lnkFactionName.Size = new System.Drawing.Size(53, 13);
            this.lnkFactionName.TabIndex = 3;
            this.lnkFactionName.TabStop = true;
            this.lnkFactionName.Text = "linkLabel2";
            // 
            // lnkPlayerName
            // 
            this.lnkPlayerName.AutoSize = true;
            this.lnkPlayerName.Location = new System.Drawing.Point(122, 21);
            this.lnkPlayerName.Name = "lnkPlayerName";
            this.lnkPlayerName.Size = new System.Drawing.Size(53, 13);
            this.lnkPlayerName.TabIndex = 2;
            this.lnkPlayerName.TabStop = true;
            this.lnkPlayerName.Text = "linkLabel1";
            // 
            // lblFactionName
            // 
            this.lblFactionName.AutoSize = true;
            this.lblFactionName.Location = new System.Drawing.Point(13, 43);
            this.lblFactionName.Name = "lblFactionName";
            this.lblFactionName.Size = new System.Drawing.Size(79, 13);
            this.lblFactionName.TabIndex = 1;
            this.lblFactionName.Text = "Faction Name :";
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.AutoSize = true;
            this.lblPlayerName.Location = new System.Drawing.Point(13, 21);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(74, 13);
            this.lblPlayerName.TabIndex = 0;
            this.lblPlayerName.Text = "Player Name :";
            // 
            // gameStatus
            // 
            this.gameStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripCurrentTime});
            this.gameStatus.Location = new System.Drawing.Point(0, 207);
            this.gameStatus.Name = "gameStatus";
            this.gameStatus.Size = new System.Drawing.Size(346, 22);
            this.gameStatus.TabIndex = 3;
            this.gameStatus.Text = "Game Status";
            // 
            // toolStripCurrentTime
            // 
            this.toolStripCurrentTime.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripCurrentTime.Name = "toolStripCurrentTime";
            this.toolStripCurrentTime.Size = new System.Drawing.Size(75, 17);
            this.toolStripCurrentTime.Text = "Current Time";
            // 
            // grbWorldSummary
            // 
            this.grbWorldSummary.Controls.Add(this.lnkFactionsCount);
            this.grbWorldSummary.Controls.Add(this.lblFactionsCount);
            this.grbWorldSummary.Location = new System.Drawing.Point(12, 27);
            this.grbWorldSummary.Name = "grbWorldSummary";
            this.grbWorldSummary.Size = new System.Drawing.Size(321, 47);
            this.grbWorldSummary.TabIndex = 4;
            this.grbWorldSummary.TabStop = false;
            this.grbWorldSummary.Text = "World Summary";
            // 
            // lnkFactionsCount
            // 
            this.lnkFactionsCount.AutoSize = true;
            this.lnkFactionsCount.Location = new System.Drawing.Point(121, 19);
            this.lnkFactionsCount.Name = "lnkFactionsCount";
            this.lnkFactionsCount.Size = new System.Drawing.Size(53, 13);
            this.lnkFactionsCount.TabIndex = 2;
            this.lnkFactionsCount.TabStop = true;
            this.lnkFactionsCount.Text = "linkLabel1";
            // 
            // lblFactionsCount
            // 
            this.lblFactionsCount.AutoSize = true;
            this.lblFactionsCount.Location = new System.Drawing.Point(12, 19);
            this.lblFactionsCount.Name = "lblFactionsCount";
            this.lblFactionsCount.Size = new System.Drawing.Size(86, 13);
            this.lblFactionsCount.TabIndex = 0;
            this.lblFactionsCount.Text = "Factions Count :";
            // 
            // frmMainGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(346, 229);
            this.Controls.Add(this.grbWorldSummary);
            this.Controls.Add(this.gameStatus);
            this.Controls.Add(this.grbPlayerSummary);
            this.Controls.Add(this.menuMain);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuMain;
            this.Name = "frmMainGame";
            this.Text = "Civilization Story";
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.grbPlayerSummary.ResumeLayout(false);
            this.grbPlayerSummary.PerformLayout();
            this.gameStatus.ResumeLayout(false);
            this.gameStatus.PerformLayout();
            this.grbWorldSummary.ResumeLayout(false);
            this.grbWorldSummary.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem loadGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveGameAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem gameSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem exitGameToolStripMenuItem;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.GroupBox grbPlayerSummary;
        private System.Windows.Forms.Label lblFactionName;
        private System.Windows.Forms.Label lblPlayerName;
        private System.Windows.Forms.LinkLabel lnkFactionName;
        private System.Windows.Forms.LinkLabel lnkPlayerName;
        private System.Windows.Forms.LinkLabel lnkSettlementsCount;
        private System.Windows.Forms.Label lblSettlementsCount;
        private System.Windows.Forms.LinkLabel lnkPopulation;
        private System.Windows.Forms.Label lblPopulation;
        private System.Windows.Forms.StatusStrip gameStatus;
        private System.Windows.Forms.ToolStripStatusLabel toolStripCurrentTime;
        private System.Windows.Forms.GroupBox grbWorldSummary;
        private System.Windows.Forms.LinkLabel lnkFactionsCount;
        private System.Windows.Forms.Label lblFactionsCount;
    }
}

