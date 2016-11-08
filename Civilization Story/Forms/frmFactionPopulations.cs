using Engine.Core;
using Engine.Modules.Humans;
using Engine.Modules.Regional;
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
    public partial class frmFactionPopulations : Form
    {
        public Game game;
        public Faction faction;

        public frmFactionPopulations()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            updateForm();
        }

        private void updateForm()
        {
            lnkFamiliesCount.Text = faction.families.Count.ToString() + " Family";
            int rowIndex = -1;
            int colIndex = -1;
            if (gridPopulations.CurrentCell != null)
            {
                rowIndex = gridPopulations.CurrentCell.RowIndex;
                colIndex = gridPopulations.CurrentCell.ColumnIndex;
            }

            gridPopulations.Rows.Clear();
            lnkFactionName.Text = faction.name;

            List<Human> liveHumans = faction.humanManagement.getLiveHumans();
            if (liveHumans.Count >= 0)
            {
                foreach (Human h in liveHumans)
                {
                    int years = (int)Math.Round(h.age.TotalDays / 356.0);
                    int maxAge = (int)Math.Round(h.maxAge.TotalDays / 356.0);
                    DataGridViewRow row = (DataGridViewRow)gridPopulations.Rows[0].Clone();
                    row.SetValues(h.name, h.dateOfBirth.ToShortDateString(), years.ToString(), maxAge, h.isMale ? "Male" : "Female", h.canHasChilds);
                    row.Tag = h;
                    gridPopulations.Rows.Add(row);
                }
                if (rowIndex != -1 && colIndex != -1)
                    gridPopulations.CurrentCell = gridPopulations.Rows[rowIndex].Cells[colIndex];
            }
        }

        private void gridPopulations_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                Human h = gridPopulations.Rows[e.RowIndex].Tag as Human;
                frmHumanInfo frm = new frmHumanInfo();
                frm.human = h;
                frm.Show();
            }
        }
    }
}
