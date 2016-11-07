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
            this.btnOk = new System.Windows.Forms.Button();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDateOfBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFertile = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridPopulations)).BeginInit();
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
            this.colSex,
            this.colFertile});
            this.gridPopulations.Location = new System.Drawing.Point(16, 30);
            this.gridPopulations.Name = "gridPopulations";
            this.gridPopulations.Size = new System.Drawing.Size(554, 287);
            this.gridPopulations.TabIndex = 2;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(254, 323);
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
            // colName
            // 
            this.colName.HeaderText = "Name";
            this.colName.Name = "colName";
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
            // frmFactionPopulations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 350);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.gridPopulations);
            this.Controls.Add(this.lnkFactionName);
            this.Controls.Add(this.lblFactionName);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmFactionPopulations";
            this.Text = "Civilization Story - Faction Populations";
            ((System.ComponentModel.ISupportInitialize)(this.gridPopulations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFactionName;
        private System.Windows.Forms.LinkLabel lnkFactionName;
        private System.Windows.Forms.DataGridView gridPopulations;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDateOfBirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAge;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSex;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colFertile;
    }
}