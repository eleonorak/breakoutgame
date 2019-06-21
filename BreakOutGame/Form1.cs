﻿using System;
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
        public bool isMoreColor = true;
 

        
        



        public Form1()
        {
            InitializeComponent();
            this.ActiveControl = txtNickName;
            cbLanguage.SelectedIndex = 0;

            OneColorToolStripMenuItem.Checked = false;
            MoreColorToolStripMenuItem.Checked = true;

        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            
            string nickNamePlayer = txtNickName.Text;
            player = new Player(nickNamePlayer);
            this.Hide();

            state = new GameState();
            state.player = this.player;
            state.ballColor = this.ballColor;
            state.backgroundColor = this.gameBackgroundColor;
            state.blocksColor = this.blocksColor;
            state.isMoreColor = this.isMoreColor;

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
                ballColor = colorDialog.Color;
            }
        }

        private void ChangeBackgroundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            DialogResult result = colorDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                gameBackgroundColor = colorDialog.Color;
            }
        }

        private void OneColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
              
                OneColorToolStripMenuItem.Checked = true;
                MoreColorToolStripMenuItem.Checked = false;
                isMoreColor = false;

                ColorDialog colorDialog = new ColorDialog();
                DialogResult result = colorDialog.ShowDialog();

                if (result == DialogResult.OK)
                {
                    blocksColor = colorDialog.Color;
                }
        }

        private void MoreColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OneColorToolStripMenuItem.Checked = false;
            MoreColorToolStripMenuItem.Checked = true;
            isMoreColor = true;
        }
    }
}


