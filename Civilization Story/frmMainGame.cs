using Civilization_Story.Forms;
using Engine.Core;
using Engine.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Civilization_Story
{
    public partial class frmMainGame : Form
    {
        Game game = new Game();

        public frmMainGame()
        {
            InitializeComponent();
        }

        private void createGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gameTimer.Stop();

            frmCreateGame frm = new frmCreateGame();
            frm.game = game;
            frm.ShowDialog();

            gameTimer.Enabled = true;
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            game.update(1.0);
            updateForm();
        }

        private void updateForm()
        {
            toolStripCurrentTime.Text = GameClock.currentTime.ToLongDateString() + " " + GameClock.currentTime.ToLongTimeString();

            lnkFactionsCount.Text = game.world.factions.Count.ToString() + " Faction";
            lnkPlayerName.Text = game.player.name;
            lnkFactionName.Text = game.player.faction.name;
            lnkPopulation.Text = game.player.faction.humans.Count.ToString() + " Civil";
            lnkSettlementsCount.Text = game.player.faction.settlements.Count.ToString() + " Settlement";
        }

        private void lnkPopulation_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmFactionPopulations frm = new frmFactionPopulations();
            frm.faction = game.player.faction;
            frm.game = game;
            frm.Show();
        }
    }
}
