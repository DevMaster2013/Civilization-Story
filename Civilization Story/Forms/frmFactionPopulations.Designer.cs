namespace Civilization_Story.Forms
{
    partial class frmFactionPopulations
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
            this.lblFactionName = new System.Windows.Forms.Label();
            this.lnkFactionName = new System.Windows.Forms.LinkLabel();
            this.gridPopulations = new System.Windows.Forms.DataGridView();
            this.colName = new System.Windows.Forms.DataGridViewLinkColumn();
            this.colDateOfBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaxAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFertile = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnOk = new System.Windows.Forms.Button();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.pnlCommands = new System.Windows.Forms.Panel();
            this.lnkFamiliesCount = new System.Windows.Forms.LinkLabel();
            this.lblFamiliesCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridPopulations)).BeginInit();
            this.pnlCommands.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFactionName
            // 
            this.lblFactionName.AutoSize = true;
            this.lblFactionName.Location = new System.Drawing.Point(13, 13);
            this.lblFactionName.Name = "lblFactionName";
            this.lblFactionName.Size = new System.Drawing.Size(82, 13);
            this.lblFactionName.TabIndex = 0;
            this.lblFactionName.Text = "Faction Name : ";
            // 
            // lnkFactionName
            // 
            this.lnkFactionName.AutoSize = true;
            this.lnkFactionName.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkFactionName.Location = new System.Drawing.Point(101, 13);
            this.lnkFactionName.Name = "lnkFactionName";
            this.lnkFactionName.Size = new System.Drawing.Size(72, 13);
            this.lnkFactionName.TabIndex = 1;
            this.lnkFactionName.TabStop = true;
            this.lnkFactionName.Text = "Faction Name";
            // 
            // gridPopulations
            // 
            this.gridPopulations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPopulations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colName,
            this.colDateOfBirth,
            this.colAge,
            this.colMaxAge,
            this.colSex,
            this.colFertile});
            this.gridPopulations.Location = new System.Drawing.Point(16, 30);
            this.gridPopulations.Name = "gridPopulations";
            this.gridPopulations.Size = new System.Drawing.Size(643, 287);
            this.gridPopulations.TabIndex = 2;
            this.gridPopulations.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridPopulations_CellClick);
            // 
            // colName
            // 
            this.colName.HeaderText = "Name";
            this.colName.Name = "colName";
            this.colName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colDateOfBirth
            // 
            this.colDateOfBirth.HeaderText = "DOB";
            this.colDateOfBirth.Name = "colDateOfBirth";
            // 
            // colAge
            // 
            this.colAge.HeaderText = "Age";
            this.colAge.Name = "colAge";
            // 
            // colMaxAge
            // 
            this.colMaxAge.HeaderText = "Mag Age";
            this.colMaxAge.Name = "colMaxAge";
            // 
            // colSex
            // 
            this.colSex.HeaderText = "Sex";
            this.colSex.Name = "colSex";
            // 
            // colFertile
            // 
            this.colFertile.HeaderText = "Is Fertile";
            this.colFertile.Name = "colFertile";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(411, 323);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 3;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 1000;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // pnlCommands
            // 
            this.pnlCommands.Controls.Add(this.lnkFamiliesCount);
            this.pnlCommands.Controls.Add(this.lblFamiliesCount);
            this.pnlCommands.Location = new System.Drawing.Point(665, 30);
            this.pnlCommands.Name = "pnlCommands";
            this.pnlCommands.Size = new System.Drawing.Size(220, 287);
            this.pnlCommands.TabIndex = 4;
            // 
            // lnkFamiliesCount
            // 
            this.lnkFamiliesCount.AutoSize = true;
            this.lnkFamiliesCount.Location = new System.Drawing.Point(93, 4);
            this.lnkFamiliesCount.Name = "lnkFamiliesCount";
            this.lnkFamiliesCount.Size = new System.Drawing.Size(44, 13);
            this.lnkFamiliesCount.TabIndex = 1;
            this.lnkFamiliesCount.TabStop = true;
            this.lnkFamiliesCount.Text = "Families";
            // 
            // lblFamiliesCount
            // 
            this.lblFamiliesCount.AutoSize = true;
            this.lblFamiliesCount.Location = new System.Drawing.Point(4, 4);
            this.lblFamiliesCount.Name = "lblFamiliesCount";
            this.lblFamiliesCount.Size = new System.Drawing.Size(83, 13);
            this.lblFamiliesCount.TabIndex = 0;
            this.lblFamiliesCount.Text = "Families Count :";
            // 
            // frmFactionPopulations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 350);
            this.Controls.Add(this.pnlCommands);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.gridPopulations);
            this.Controls.Add(this.lnkFactionName);
            this.Controls.Add(this.lblFactionName);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmFactionPopulations";
            this.Text = "Civilization Story - Faction Populations";
            ((System.ComponentModel.ISupportInitialize)(this.gridPopulations)).EndInit();
            this.pnlCommands.ResumeLayout(false);
            this.pnlCommands.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFactionName;
        private System.Windows.Forms.LinkLabel lnkFactionName;
        private System.Windows.Forms.DataGridView gridPopulations;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.DataGridViewLinkColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDateOfBirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAge;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaxAge;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSex;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colFertile;
        private System.Windows.Forms.Panel pnlCommands;
        private System.Windows.Forms.LinkLabel lnkFamiliesCount;
        private System.Windows.Forms.Label lblFamiliesCount;
    }
}