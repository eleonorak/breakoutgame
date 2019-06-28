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
    public partial class Form1 : Form
    {
       

        public GameState state { get; set; }
        public Player player { get; set; }
        public Color ballColor = Color.Yellow;
        public Color gameBackgroundColor = Color.Black;
        public Color blocksColor = Color.Red;
        public Color playerColor = Color.White;
        public bool isMoreColor = true;
        public int gameLevel = 0;



        public Form1(GameState gamestate)
        {
            InitializeComponent();

            this.state = gamestate;
            if (state != null)
            {
                if (state.player == null)
                {
                    
                    cbLevel.SelectedIndex = 0;

                    OneColorToolStripMenuItem.Checked = false;
                    MoreColorToolStripMenuItem.Checked = true;
                    return;
                }
                else
                {
                    txtNickName.Text = state.player.nickName;
                    cbLevel.SelectedIndex = state.level;
                    
                    ballColor = state.ballColor;
                    gameBackgroundColor = state.backgroundColor;
                    blocksColor = state.blocksColor;
                    playerColor = state.playerColor;
                    isMoreColor = state.isMoreColor;
                    gameLevel = state.level;

                    if (isMoreColor == true)
                    {
                        OneColorToolStripMenuItem.Checked = false;
                        MoreColorToolStripMenuItem.Checked = true;
                    }
                    else
                    {
                        OneColorToolStripMenuItem.Checked = true;
                        MoreColorToolStripMenuItem.Checked = false;
                    }
                }

            }

        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            
            string nickNamePlayer = txtNickName.Text;
            if (nickNamePlayer.Trim().Length == 0)
            {
                MessageBox.Show("Полето за прекар е задолжително");
                return;
            }
            player = new Player(nickNamePlayer);
            this.Hide();

            state = new GameState();
            state.player = this.player;
            state.ballColor = this.ballColor;
            state.backgroundColor = this.gameBackgroundColor;
            state.blocksColor = this.blocksColor;
            state.playerColor = this.playerColor;
            state.isMoreColor = this.isMoreColor;
            state.level = this.gameLevel;

            GameForm gameForm = new GameForm(state);
            gameForm.ShowDialog();
          
        }

        private void txtNickName_Validating(object sender, CancelEventArgs e)
        {
          
          
            if(txtNickName.Text.Trim().Length  == 0)
            {
                errorProvider.SetError(txtNickName, "За да започнете со игра потребо е да внесете Прекар.");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtNickName, null);
                e.Cancel = false;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ChangeBallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            DialogResult result = colorDialog.ShowDialog();

            if(result == DialogResult.OK)
            {
                this.ballColor = colorDialog.Color;
            }
        }

        private void ChangeBackgroundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            DialogResult result = colorDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                this.gameBackgroundColor = colorDialog.Color;
            }
        }

        private void OneColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
              
                OneColorToolStripMenuItem.Checked = true;
                MoreColorToolStripMenuItem.Checked = false;
                 this.isMoreColor = false;

                ColorDialog colorDialog = new ColorDialog();
                DialogResult result = colorDialog.ShowDialog();

                if (result == DialogResult.OK)
                {
                   this.blocksColor = colorDialog.Color;
                }
        }

        private void MoreColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OneColorToolStripMenuItem.Checked = false;
            MoreColorToolStripMenuItem.Checked = true;
            this.isMoreColor = true;
        }

        private void ChangePlayerColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            DialogResult result = colorDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                this.playerColor = colorDialog.Color;
            }
        }

        private void cbLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            gameLevel = cbLevel.SelectedIndex;
        }
    }
}


