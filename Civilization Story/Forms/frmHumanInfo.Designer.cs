namespace Civilization_Story.Forms
{
    partial class frmHumanInfo
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
            this.grbHumanInfo = new System.Windows.Forms.GroupBox();
            this.grbFamilyTree = new System.Windows.Forms.GroupBox();
            this.lblCivilName = new System.Windows.Forms.Label();
            this.txtCivilName = new System.Windows.Forms.TextBox();
            this.chkIsMale = new System.Windows.Forms.CheckBox();
            this.chkIsAlive = new System.Windows.Forms.CheckBox();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.txtDateOfBirth = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.lblFactionHome = new System.Windows.Forms.Label();
            this.lnkFaction = new System.Windows.Forms.LinkLabel();
            this.lblSettlement = new System.Windows.Forms.Label();
            this.lnkSettlement = new System.Windows.Forms.LinkLabel();
            this.lblFather = new System.Windows.Forms.Label();
            this.lblMother = new System.Windows.Forms.Label();
            this.lnkFather = new System.Windows.Forms.LinkLabel();
            this.lnkMother = new System.Windows.Forms.LinkLabel();
            this.chkActiveMarriage = new System.Windows.Forms.CheckBox();
            this.pnlFamilyInfo = new System.Windows.Forms.Panel();
            this.lblSpouse = new System.Windows.Forms.Label();
            this.lnkSpouse = new System.Windows.Forms.LinkLabel();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.txtStartDate = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.gridChilds = new System.Windows.Forms.DataGridView();
            this.grbChilds = new System.Windows.Forms.GroupBox();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.txtEndDate = new System.Windows.Forms.TextBox();
            this.colIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewLinkColumn();
            this.colDateOfBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.grbHumanInfo.SuspendLayout();
            this.grbFamilyTree.SuspendLayout();
            this.pnlFamilyInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridChilds)).BeginInit();
            this.grbChilds.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbHumanInfo
            // 
            this.grbHumanInfo.Controls.Add(this.lnkSettlement);
            this.grbHumanInfo.Controls.Add(this.lnkFaction);
            this.grbHumanInfo.Controls.Add(this.chkIsAlive);
            this.grbHumanInfo.Controls.Add(this.chkIsMale);
            this.grbHumanInfo.Controls.Add(this.txtDateOfBirth);
            this.grbHumanInfo.Controls.Add(this.lblDateOfBirth);
            this.grbHumanInfo.Controls.Add(this.lblSettlement);
            this.grbHumanInfo.Controls.Add(this.txtAge);
            this.grbHumanInfo.Controls.Add(this.lblFactionHome);
            this.grbHumanInfo.Controls.Add(this.label2);
            this.grbHumanInfo.Controls.Add(this.txtCivilName);
            this.grbHumanInfo.Controls.Add(this.lblCivilName);
            this.grbHumanInfo.Location = new System.Drawing.Point(13, 13);
            this.grbHumanInfo.Name = "grbHumanInfo";
            this.grbHumanInfo.Size = new System.Drawing.Size(552, 88);
            this.grbHumanInfo.TabIndex = 0;
            this.grbHumanInfo.TabStop = false;
            this.grbHumanInfo.Text = "Human Information";
            // 
            // grbFamilyTree
            // 
            this.grbFamilyTree.Controls.Add(this.pnlFamilyInfo);
            this.grbFamilyTree.Controls.Add(this.lblMother);
            this.grbFamilyTree.Controls.Add(this.lnkMother);
            this.grbFamilyTree.Controls.Add(this.lnkFather);
            this.grbFamilyTree.Controls.Add(this.lblFather);
            this.grbFamilyTree.Location = new System.Drawing.Point(13, 107);
            this.grbFamilyTree.Name = "grbFamilyTree";
            this.grbFamilyTree.Size = new System.Drawing.Size(552, 239);
            this.grbFamilyTree.TabIndex = 0;
            this.grbFamilyTree.TabStop = false;
            this.grbFamilyTree.Text = "Family Info";
            // 
            // lblCivilName
            // 
            this.lblCivilName.AutoSize = true;
            this.lblCivilName.Location = new System.Drawing.Point(7, 20);
            this.lblCivilName.Name = "lblCivilName";
            this.lblCivilName.Size = new System.Drawing.Size(41, 13);
            this.lblCivilName.TabIndex = 0;
            this.lblCivilName.Text = "Name :";
            // 
            // txtCivilName
            // 
            this.txtCivilName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtCivilName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCivilName.Location = new System.Drawing.Point(85, 19);
            this.txtCivilName.Name = "txtCivilName";
            this.txtCivilName.ReadOnly = true;
            this.txtCivilName.Size = new System.Drawing.Size(100, 14);
            this.txtCivilName.TabIndex = 1;
            // 
            // chkIsMale
            // 
            this.chkIsMale.AutoSize = true;
            this.chkIsMale.Location = new System.Drawing.Point(191, 18);
            this.chkIsMale.Name = "chkIsMale";
            this.chkIsMale.Size = new System.Drawing.Size(60, 17);
            this.chkIsMale.TabIndex = 2;
            this.chkIsMale.Text = "Is Male";
            this.chkIsMale.UseVisualStyleBackColor = true;
            // 
            // chkIsAlive
            // 
            this.chkIsAlive.AutoSize = true;
            this.chkIsAlive.Location = new System.Drawing.Point(257, 18);
            this.chkIsAlive.Name = "chkIsAlive";
            this.chkIsAlive.Size = new System.Drawing.Size(61, 17);
            this.chkIsAlive.TabIndex = 2;
            this.chkIsAlive.Text = "Is Alive";
            this.chkIsAlive.UseVisualStyleBackColor = true;
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.AutoSize = true;
            this.lblDateOfBirth.Location = new System.Drawing.Point(7, 40);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(75, 13);
            this.lblDateOfBirth.TabIndex = 0;
            this.lblDateOfBirth.Text = "Date of Birth :";
            // 
            // txtDateOfBirth
            // 
            this.txtDateOfBirth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtDateOfBirth.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDateOfBirth.Location = new System.Drawing.Point(88, 40);
            this.txtDateOfBirth.Name = "txtDateOfBirth";
            this.txtDateOfBirth.ReadOnly = true;
            this.txtDateOfBirth.Size = new System.Drawing.Size(225, 14);
            this.txtDateOfBirth.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(360, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Age :";
            // 
            // txtAge
            // 
            this.txtAge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtAge.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAge.Location = new System.Drawing.Point(401, 40);
            this.txtAge.Name = "txtAge";
            this.txtAge.ReadOnly = true;
            this.txtAge.Size = new System.Drawing.Size(100, 14);
            this.txtAge.TabIndex = 1;
            // 
            // lblFactionHome
            // 
            this.lblFactionHome.AutoSize = true;
            this.lblFactionHome.Location = new System.Drawing.Point(7, 65);
            this.lblFactionHome.Name = "lblFactionHome";
            this.lblFactionHome.Size = new System.Drawing.Size(49, 13);
            this.lblFactionHome.TabIndex = 0;
            this.lblFactionHome.Text = "Faction :";
            // 
            // lnkFaction
            // 
            this.lnkFaction.AutoSize = true;
            this.lnkFaction.Location = new System.Drawing.Point(82, 65);
            this.lnkFaction.Name = "lnkFaction";
            this.lnkFaction.Size = new System.Drawing.Size(42, 13);
            this.lnkFaction.TabIndex = 3;
            this.lnkFaction.TabStop = true;
            this.lnkFaction.Text = "Faction";
            // 
            // lblSettlement
            // 
            this.lblSettlement.AutoSize = true;
            this.lblSettlement.Location = new System.Drawing.Point(179, 65);
            this.lblSettlement.Name = "lblSettlement";
            this.lblSettlement.Size = new System.Drawing.Size(69, 13);
            this.lblSettlement.TabIndex = 0;
            this.lblSettlement.Text = "Settlement : ";
            // 
            // lnkSettlement
            // 
            this.lnkSettlement.AutoSize = true;
            this.lnkSettlement.Location = new System.Drawing.Point(254, 65);
            this.lnkSettlement.Name = "lnkSettlement";
            this.lnkSettlement.Size = new System.Drawing.Size(59, 13);
            this.lnkSettlement.TabIndex = 3;
            this.lnkSettlement.TabStop = true;
            this.lnkSettlement.Text = "Settlement";
            // 
            // lblFather
            // 
            this.lblFather.AutoSize = true;
            this.lblFather.Location = new System.Drawing.Point(8, 22);
            this.lblFather.Name = "lblFather";
            this.lblFather.Size = new System.Drawing.Size(49, 13);
            this.lblFather.TabIndex = 0;
            this.lblFather.Text = "Father : ";
            // 
            // lblMother
            // 
            this.lblMother.AutoSize = true;
            this.lblMother.Location = new System.Drawing.Point(135, 22);
            this.lblMother.Name = "lblMother";
            this.lblMother.Size = new System.Drawing.Size(51, 13);
            this.lblMother.TabIndex = 0;
            this.lblMother.Text = "Mother : ";
            // 
            // lnkFather
            // 
            this.lnkFather.AutoSize = true;
            this.lnkFather.Location = new System.Drawing.Point(55, 22);
            this.lnkFather.Name = "lnkFather";
            this.lnkFather.Size = new System.Drawing.Size(39, 13);
            this.lnkFather.TabIndex = 3;
            this.lnkFather.TabStop = true;
            this.lnkFather.Text = "Father";
            // 
            // lnkMother
            // 
            this.lnkMother.AutoSize = true;
            this.lnkMother.Location = new System.Drawing.Point(190, 22);
            this.lnkMother.Name = "lnkMother";
            this.lnkMother.Size = new System.Drawing.Size(41, 13);
            this.lnkMother.TabIndex = 3;
            this.lnkMother.TabStop = true;
            this.lnkMother.Text = "Mother";
            // 
            // chkActiveMarriage
            // 
            this.chkActiveMarriage.AutoSize = true;
            this.chkActiveMarriage.Location = new System.Drawing.Point(195, 9);
            this.chkActiveMarriage.Name = "chkActiveMarriage";
            this.chkActiveMarriage.Size = new System.Drawing.Size(101, 17);
            this.chkActiveMarriage.TabIndex = 4;
            this.chkActiveMarriage.Text = "Active Marriage";
            this.chkActiveMarriage.UseVisualStyleBackColor = true;
            // 
            // pnlFamilyInfo
            // 
            this.pnlFamilyInfo.Controls.Add(this.grbChilds);
            this.pnlFamilyInfo.Controls.Add(this.lnkSpouse);
            this.pnlFamilyInfo.Controls.Add(this.chkActiveMarriage);
            this.pnlFamilyInfo.Controls.Add(this.lblSpouse);
            this.pnlFamilyInfo.Controls.Add(this.txtEndDate);
            this.pnlFamilyInfo.Controls.Add(this.lblEndDate);
            this.pnlFamilyInfo.Controls.Add(this.txtStartDate);
            this.pnlFamilyInfo.Controls.Add(this.lblStartDate);
            this.pnlFamilyInfo.Location = new System.Drawing.Point(11, 39);
            this.pnlFamilyInfo.Name = "pnlFamilyInfo";
            this.pnlFamilyInfo.Size = new System.Drawing.Size(535, 194);
            this.pnlFamilyInfo.TabIndex = 5;
            // 
            // lblSpouse
            // 
            this.lblSpouse.AutoSize = true;
            this.lblSpouse.Location = new System.Drawing.Point(10, 10);
            this.lblSpouse.Name = "lblSpouse";
            this.lblSpouse.Size = new System.Drawing.Size(49, 13);
            this.lblSpouse.TabIndex = 0;
            this.lblSpouse.Text = "Spouse :";
            // 
            // lnkSpouse
            // 
            this.lnkSpouse.AutoSize = true;
            this.lnkSpouse.Location = new System.Drawing.Point(83, 10);
            this.lnkSpouse.Name = "lnkSpouse";
            this.lnkSpouse.Size = new System.Drawing.Size(42, 13);
            this.lnkSpouse.TabIndex = 3;
            this.lnkSpouse.TabStop = true;
            this.lnkSpouse.Text = "Spouse";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(8, 31);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(64, 13);
            this.lblStartDate.TabIndex = 0;
            this.lblStartDate.Text = "Start Date :";
            // 
            // txtStartDate
            // 
            this.txtStartDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtStartDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStartDate.Location = new System.Drawing.Point(86, 30);
            this.txtStartDate.Name = "txtStartDate";
            this.txtStartDate.ReadOnly = true;
            this.txtStartDate.Size = new System.Drawing.Size(177, 14);
            this.txtStartDate.TabIndex = 1;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(251, 352);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // gridChilds
            // 
            this.gridChilds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridChilds.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIndex,
            this.colName,
            this.colDateOfBirth,
            this.colAge});
            this.gridChilds.Location = new System.Drawing.Point(6, 20);
            this.gridChilds.Name = "gridChilds";
            this.gridChilds.Size = new System.Drawing.Size(504, 115);
            this.gridChilds.TabIndex = 5;
            // 
            // grbChilds
            // 
            this.grbChilds.Controls.Add(this.gridChilds);
            this.grbChilds.Location = new System.Drawing.Point(13, 50);
            this.grbChilds.Name = "grbChilds";
            this.grbChilds.Size = new System.Drawing.Size(516, 141);
            this.grbChilds.TabIndex = 6;
            this.grbChilds.TabStop = false;
            this.grbChilds.Text = "Childs";
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(274, 31);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(58, 13);
            this.lblEndDate.TabIndex = 0;
            this.lblEndDate.Text = "End Date :";
            // 
            // txtEndDate
            // 
            this.txtEndDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtEndDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEndDate.Location = new System.Drawing.Point(352, 30);
            this.txtEndDate.Name = "txtEndDate";
            this.txtEndDate.ReadOnly = true;
            this.txtEndDate.Size = new System.Drawing.Size(177, 14);
            this.txtEndDate.TabIndex = 1;
            // 
            // colIndex
            // 
            this.colIndex.HeaderText = "Number";
            this.colIndex.Name = "colIndex";
            this.colIndex.Width = 50;
            // 
            // colName
            // 
            this.colName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colName.HeaderText = "Name";
            this.colName.Name = "colName";
            this.colName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colDateOfBirth
            // 
            this.colDateOfBirth.HeaderText = "Date Of Birth";
            this.colDateOfBirth.Name = "colDateOfBirth";
            // 
            // colAge
            // 
            this.colAge.HeaderText = "Age";
            this.colAge.Name = "colAge";
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 1000;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // frmHumanInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 380);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.grbFamilyTree);
            this.Controls.Add(this.grbHumanInfo);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmHumanInfo";
            this.Text = "Civilization Story - Human Info";
            this.grbHumanInfo.ResumeLayout(false);
            this.grbHumanInfo.PerformLayout();
            this.grbFamilyTree.ResumeLayout(false);
            this.grbFamilyTree.PerformLayout();
            this.pnlFamilyInfo.ResumeLayout(false);
            this.pnlFamilyInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridChilds)).EndInit();
            this.grbChilds.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbHumanInfo;
        private System.Windows.Forms.GroupBox grbFamilyTree;
        private System.Windows.Forms.Label lblCivilName;
        private System.Windows.Forms.TextBox txtCivilName;
        private System.Windows.Forms.CheckBox chkIsMale;
        private System.Windows.Forms.CheckBox chkIsAlive;
        private System.Windows.Forms.TextBox txtDateOfBirth;
        private System.Windows.Forms.Label lblDateOfBirth;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel lnkSettlement;
        private System.Windows.Forms.LinkLabel lnkFaction;
        private System.Windows.Forms.Label lblSettlement;
        private System.Windows.Forms.Label lblFactionHome;
        private System.Windows.Forms.Label lblMother;
        private System.Windows.Forms.Label lblFather;
        private System.Windows.Forms.LinkLabel lnkMother;
        private System.Windows.Forms.LinkLabel lnkFather;
        private System.Windows.Forms.CheckBox chkActiveMarriage;
        private System.Windows.Forms.Panel pnlFamilyInfo;
        private System.Windows.Forms.LinkLabel lnkSpouse;
        private System.Windows.Forms.Label lblSpouse;
        private System.Windows.Forms.TextBox txtStartDate;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.GroupBox grbChilds;
        private System.Windows.Forms.DataGridView gridChilds;
        private System.Windows.Forms.TextBox txtEndDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIndex;
        private System.Windows.Forms.DataGridViewLinkColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDateOfBirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAge;
        private System.Windows.Forms.Timer gameTimer;
    }
}