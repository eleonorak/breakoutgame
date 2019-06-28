using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BreakOutGame
{
    public partial class GameEndedForm : Form
    {

        GameState state { get; set; }
        public GameEndedForm(GameState gameState)
        {
            InitializeComponent();
            this.state = gameState;

            labelScore.Text = labelScore.Text + state.gameScore;
            if (state.isWon == true)
            {
                labelStatus.Text = "Победивте";
            }
            else if (state.isWon == false)
            {
                labelStatus.Text = "Изгубивте";

            }
        }

        private void btnGoToMainForm_Click(object sender, EventArgs e)
        {
            Form1 mainForm = new Form1(state);
            this.Hide();
            mainForm.ShowDialog();
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            GameForm gameForm = new GameForm(state);
            this.Hide();
            gameForm.ShowDialog();
        }
    }
}
