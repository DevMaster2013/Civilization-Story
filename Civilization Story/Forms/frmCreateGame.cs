using Engine.Core;
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
    public partial class frmCreateGame : Form
    {
        public Game game;

        public frmCreateGame()
        {
            InitializeComponent();
        }

        private void btnCreateGame_Click(object sender, EventArgs e)
        {
            game.createWorld();
            game.createPlayer(txtPlayerName.Text, txtWifeName.Text, txtFactionName.Text);

            Close();
        }
    }
}
