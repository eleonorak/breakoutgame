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
    public partial class GameForm : Form
    {
        bool goRight;
        bool goLeft;
        int speed = 10;
        int ballx = 5;
        int bally = 5;
        int score = 0;

        public Ball b;
        public Block block;

        int blockWidth = 125;
        int blockHeight = 23;
        List<Block> blocks;

        private Random rnd = new Random();



        public GameForm(Player p)
        {
            InitializeComponent();
            

            this.DoubleBuffered = true;
            //foreach (Control c in this.Controls)
           // {
                //if (c is PictureBox && c.Tag == "block")
               // {
                   // Color randomColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
                   // c.BackColor = randomColor;
               // }
           // }

            Player gamePlayer = p;
            string nickNamePlayer = gamePlayer.nickName;
            player.Text = nickNamePlayer;

            this.blocks = new List<Block>();

            int x;
            int y = 73;
            for(int i = 0; i < 7; i++)
            {
                 x = 32;
                this.blocks.Add(new Block(x, y, Color.Red, blockWidth, blockHeight));
                for ( int j = 0; j < 5; j++ )
                {
                    x = x +  blockWidth + 15;
                    this.blocks.Add(new Block(x, y, Color.Red, blockWidth, blockHeight));
                }
                y = y + blockHeight + 15;
            }

            

        }

        private void GameForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }

            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }
        }

        private void GameForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left && player.Left > 0)
            {
                goLeft = true;
            }

            if (e.KeyCode == Keys.Right && player.Left + player.Width < 920)
            {
                goRight = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            
          if (null == b)
            {
                b = new Ball(418, 324, Color.White,15);
            }
            

            //Invalidate();
         
            
            b.X += ballx;
            b.Y += bally;


            Rectangle bRect = new Rectangle(new Point((int)b.X, (int)b.Y), new Size(30,30));
            


            label1.Text = "Score: " + score;
            if (goLeft) { player.Left -= speed; } // move left
            if (goRight) { player.Left += speed; } // move right
            if (player.Left < 1)
            {
                goLeft = false; // stop the car from going off screen
            }
            else if (player.Left + player.Width > 920)
            {
                goRight = false;
            }
            if (bRect.Left + bRect.Width > ClientSize.Width || bRect.Left < 0)
            {
                ballx = -ballx; // this will bounce the object from the left or right border
            }
            if (bRect.Top < 0 || bRect.IntersectsWith(player.Bounds))
            {
                //MessageBox.Show(player.Bounds.X.ToString());
                bally = -bally; // this will bounce the object from top and bottom border
            }
            if (bRect.Top + bRect .Height > ClientSize.Height)
            {
                gameOver();
                MessageBox.Show("You Lost");
                
            }
            foreach(Block bl in this.blocks)
            {
                if (bl.Show && bRect.IntersectsWith(bl.Rectangle))
                {
                   
                    bally = -bally;
                    score++;
                    bl.Show = false;
                }
            }
            
            if (score > 41)
            {
                gameOver();
                MessageBox.Show("You Win" + score);
            }

            this.Invalidate();
        }
        private void gameOver()
        {
            timer1.Stop();
        }

      

        private void GameForm_Paint(object sender, PaintEventArgs e)
        {
            if(b != null)
            {
                b.Draw(e.Graphics);
            }

           // if(block != null)
            //{
               // //foreach
               // block.Draw(e.Graphics);
           // }
            foreach(Block b in this.blocks)
            {
                b.Draw(e.Graphics);
            }
        }
    }
}
