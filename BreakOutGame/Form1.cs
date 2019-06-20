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
        public Player player { get; set; }
        public Form1()
        {
            InitializeComponent();
            this.ActiveControl = txtNickName;
            cbLanguage.SelectedIndex = 0;
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            
            string nickNamePlayer = txtNickName.Text;
            player = new Player(nickNamePlayer);
            this.Hide();

            GameForm gameForm = new GameForm(player);
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
    }
}
