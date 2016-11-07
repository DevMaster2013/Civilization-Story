using Civilization_Story.Engine;
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
            gridPopulations.Rows.Clear();
            lnkFactionName.Text = faction.name;
            foreach (Human h in faction.humans.ToArray())
            {
                int years = (int)Math.Round((GameClock.currentTime - h.dateOfBirth).TotalDays / 356.0);               
                gridPopulations.Rows.Add(h.name, h.dateOfBirth.ToShortDateString(), years.ToString(), h.isMale ? "Male" : "Female", h.canHasChilds);                
            }
        }
    }
}
