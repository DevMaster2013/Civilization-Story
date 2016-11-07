namespace Civilization_Story.Forms
{
    partial class frmCreateGame
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
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.lblPlayerFactionName = new System.Windows.Forms.Label();
            this.txtPlayerName = new System.Windows.Forms.TextBox();
            this.txtFactionName = new System.Windows.Forms.TextBox();
            this.grbPlayerSettings = new System.Windows.Forms.GroupBox();
            this.lblWifeName = new System.Windows.Forms.Label();
            this.txtWifeName = new System.Windows.Forms.TextBox();
            this.btnCreateGame = new System.Windows.Forms.Button();
            this.grbPlayerSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.AutoSize = true;
            this.lblPlayerName.Location = new System.Drawing.Point(7, 20);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(77, 13);
            this.lblPlayerName.TabIndex = 0;
            this.lblPlayerName.Text = "Player Name : ";
            // 
            // lblPlayerFactionName
            // 
            this.lblPlayerFactionName.AutoSize = true;
            this.lblPlayerFactionName.Location = new System.Drawing.Point(7, 74);
            this.lblPlayerFactionName.Name = "lblPlayerFactionName";
            this.lblPlayerFactionName.Size = new System.Drawing.Size(109, 13);
            this.lblPlayerFactionName.TabIndex = 1;
            this.lblPlayerFactionName.Text = "Player Faction Name:";
            // 
            // txtPlayerName
            // 
            this.txtPlayerName.Location = new System.Drawing.Point(122, 17);
            this.txtPlayerName.Name = "txtPlayerName";
            this.txtPlayerName.Size = new System.Drawing.Size(188, 21);
            this.txtPlayerName.TabIndex = 3;
            this.txtPlayerName.Text = "Player";
            // 
            // txtFactionName
            // 
            this.txtFactionName.Location = new System.Drawing.Point(122, 71);
            this.txtFactionName.Name = "txtFactionName";
            this.txtFactionName.Size = new System.Drawing.Size(188, 21);
            this.txtFactionName.TabIndex = 3;
            this.txtFactionName.Text = "Faction";
            // 
            // grbPlayerSettings
            // 
            this.grbPlayerSettings.Controls.Add(this.txtFactionName);
            this.grbPlayerSettings.Controls.Add(this.lblWifeName);
            this.grbPlayerSettings.Controls.Add(this.lblPlayerName);
            this.grbPlayerSettings.Controls.Add(this.txtWifeName);
            this.grbPlayerSettings.Controls.Add(this.txtPlayerName);
            this.grbPlayerSettings.Controls.Add(this.lblPlayerFactionName);
            this.grbPlayerSettings.Location = new System.Drawing.Point(12, 12);
            this.grbPlayerSettings.Name = "grbPlayerSettings";
            this.grbPlayerSettings.Size = new System.Drawing.Size(315, 98);
            this.grbPlayerSettings.TabIndex = 4;
            this.grbPlayerSettings.TabStop = false;
            this.grbPlayerSettings.Text = "Player Settings :";
            // 
            // lblWifeName
            // 
            this.lblWifeName.AutoSize = true;
            this.lblWifeName.Location = new System.Drawing.Point(7, 47);
            this.lblWifeName.Name = "lblWifeName";
            this.lblWifeName.Size = new System.Drawing.Size(66, 13);
            this.lblWifeName.TabIndex = 0;
            this.lblWifeName.Text = "Wife Name :";
            // 
            // txtWifeName
            // 
            this.txtWifeName.Location = new System.Drawing.Point(122, 44);
            this.txtWifeName.Name = "txtWifeName";
            this.txtWifeName.Size = new System.Drawing.Size(188, 21);
            this.txtWifeName.TabIndex = 3;
            this.txtWifeName.Text = "Player Wife";
            // 
            // btnCreateGame
            // 
            this.btnCreateGame.Location = new System.Drawing.Point(102, 116);
            this.btnCreateGame.Name = "btnCreateGame";
            this.btnCreateGame.Size = new System.Drawing.Size(135, 23);
            this.btnCreateGame.TabIndex = 5;
            this.btnCreateGame.Text = "Create Game";
            this.btnCreateGame.UseVisualStyleBackColor = true;
            this.btnCreateGame.Click += new System.EventHandler(this.btnCreateGame_Click);
            // 
            // frmCreateGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 151);
            this.Controls.Add(this.btnCreateGame);
            this.Controls.Add(this.grbPlayerSettings);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmCreateGame";
            this.Text = "Civilization Story - Create Game";
            this.grbPlayerSettings.ResumeLayout(false);
            this.grbPlayerSettings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblPlayerName;
        private System.Windows.Forms.Label lblPlayerFactionName;
        private System.Windows.Forms.TextBox txtPlayerName;
        private System.Windows.Forms.TextBox txtFactionName;
        private System.Windows.Forms.GroupBox grbPlayerSettings;
        private System.Windows.Forms.Button btnCreateGame;
        private System.Windows.Forms.Label lblWifeName;
        private System.Windows.Forms.TextBox txtWifeName;
    }
}