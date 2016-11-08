using Engine.Modules.Humans;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Civilization_Story.Forms
{
    public partial class frmHumanInfo : Form
    {
        public Human human = null;

        public frmHumanInfo()
        {
            InitializeComponent();
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            updateForm();
        }

        private void updateForm()
        {
            txtCivilName.Text = human.name;
            chkIsMale.Checked = human.isMale;
            chkIsAlive.Checked = human.isAlive;
            txtDateOfBirth.Text = human.dateOfBirth.ToLongDateString();
            txtAge.Text = ((int)Math.Round(human.age.TotalDays / 356.0)).ToString() + " years";
            lnkFaction.Text = human.faction.name;
            if (human.settlement != null)
            {
                lnkSettlement.Visible = lblSettlement.Visible = true;
                lnkSettlement.Text = human.settlement.name;
            }
            else
            {
                lnkSettlement.Visible = lblSettlement.Visible = false;
            }

            if (human.parentFamily != null)
            {
                lnkFather.Enabled = lnkMother.Enabled = true;
                lnkFather.Text = human.parentFamily.husband.name;
                lnkMother.Text = human.parentFamily.wife.name;
            }
            else
            {
                lnkFather.Enabled = lnkMother.Enabled = false;
                lnkFather.Text = "None";
                lnkMother.Text = "None";
            }

            if (human.family != null)
            {
                pnlFamilyInfo.Visible = true;
                if (human.isMale)
                {
                    lblSpouse.Text = "Wife : ";
                    lnkSpouse.Text = human.family.wife.name;
                }
                else
                {
                    lblSpouse.Text = "Husband : ";
                    lnkSpouse.Text = human.family.husband.name;
                }

                txtStartDate.Text = human.family.startDate.ToLongDateString();
                chkActiveMarriage.Checked = !human.family.isDivorced;
                if (human.family.isDivorced)
                    txtEndDate.Text = human.family.endDate.Value.ToLongDateString();

                if (human.family.childs.Count > 0)
                {
                    grbChilds.Visible = true;

                    int rowIndex = -1;
                    int colIndex = -1;
                    if (gridChilds.CurrentCell != null)
                    {
                        rowIndex = gridChilds.CurrentCell.RowIndex;
                        colIndex = gridChilds.CurrentCell.ColumnIndex;
                    }

                    gridChilds.Rows.Clear();

                    List<Human> childs = human.family.childs.ToList();
                    int index = 0;
                    foreach (Human h in childs)
                    {
                        int years = (int)Math.Round(h.age.TotalDays / 356.0);
                        int maxAge = (int)Math.Round(h.maxAge.TotalDays / 356.0);
                        DataGridViewRow row = (DataGridViewRow)gridChilds.Rows[0].Clone();
                        row.SetValues(index++, h.name, h.dateOfBirth.ToShortDateString(), years.ToString());
                        row.Tag = h;
                        gridChilds.Rows.Add(row);
                    }
                    if (rowIndex != -1 && colIndex != -1)
                        gridChilds.CurrentCell = gridChilds.Rows[rowIndex].Cells[colIndex];
                }
                else
                    grbChilds.Visible = false;
            }
            else
            {
                pnlFamilyInfo.Visible = false;
            }                     
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
