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
        int score = 0;
        int winScore;
        bool goRight;
        bool goLeft;
        int speed;
        int ballx;
        int bally;
        int blockWidth;
        int blockHeight;
        int rows; //i
        int columns; //j
        int moveLeft;
        int moveRight;


        GameState state { get; set; }

        public bool gameIsPaused = false;
        public Ball b;

        public  Player gamePlayer { get; set; }
        public Color gameBallColor = Color.White;
        public Color gameBackgroundColor = Color.Black;
        public Color gameBlocksColor { get; set; }
        public Color gamePlayerColor { get; set; }
        public bool blocksIsMoreColor { get; set; }
        public int gameLevel { get; set; }

        public Block block;

        

       
        List<Block> blocks;

        private Random rnd = new Random();



        public GameForm(GameState state)
        {
            InitializeComponent();


            this.DoubleBuffered = true;
            this.state = state;

            this.gamePlayer = state.player;
            this.gameBallColor = state.ballColor;
            this.gameBackgroundColor = state.backgroundColor;
            this.gameBlocksColor = state.blocksColor;
            this.gamePlayerColor = state.playerColor;
            this.blocksIsMoreColor = state.isMoreColor;
            this.gameLevel = state.level;

            this.BackColor = gameBackgroundColor;


            //foreach (Control c in this.Controls)
            // {
            //if (c is PictureBox && c.Tag == "block")
            // {
            // Color randomColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
            // c.BackColor = randomColor;
            // }
            // }

            if (gameLevel == 0)
            {
                speed = 10;
                ballx = 5;
                bally = 5;
                blockWidth = 125;
                blockHeight = 23;
                rows = 7; //i
                columns = 5; //j
                winScore = rows * (columns + 1);
                moveLeft = speed;
                moveRight = speed;
            }
            else
            {
                
                speed = 15;
                ballx = 10;
                bally = 10;
                blockWidth = 63;
                blockHeight = 23;
                rows = 7; //i
                columns = 10; //j
                winScore = rows * (columns + 1);
                moveLeft = speed + 10;
                moveRight = speed + 10;
            }


            string nickNamePlayer = gamePlayer.nickName;
            player.Text = nickNamePlayer;

            this.blocks = new List<Block>();

            int x;
            int y = 73;
            for(int i = 0; i < rows; i++)
            {
                 x = 32;
                this.blocks.Add(new Block(x, y, gameBlocksColor, blockWidth, blockHeight));
                for ( int j = 0; j < columns; j++ )
                {
                    x = x +  blockWidth + 15;
                    this.blocks.Add(new Block(x, y, gameBlocksColor, blockWidth, blockHeight));
                }
                y = y + blockHeight + 15;
            }

            //set random color for blocks
            if(blocksIsMoreColor == true)
            {
                foreach (Block bl in this.blocks)
                {

                    Color randomColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
                    bl.color = randomColor;

                }
            }
            //set one color for blocks
            else
            {
                foreach (Block bl in this.blocks)
                {


                    bl.color = gameBlocksColor ;

                }
            }

            player.BackColor = gamePlayerColor;
         
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

            //pause

            if(gameIsPaused == false)
            {
                if (e.KeyCode == Keys.P)
                {
                    timer1.Stop();
                    gameIsPaused = true;

                }
            }
            else
            {
                if (e.KeyCode == Keys.P)
                {
                    timer1.Start();
                    gameIsPaused = false;
                }
            }
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            
          if (null == b)
            {
                b = new Ball(418, 324, gameBallColor, 15);
            }
            

            //Invalidate();
         
            
            b.X += ballx;
            b.Y += bally;


            Rectangle bRect = new Rectangle(new Point((int)b.X, (int)b.Y), new Size(30,30));
            


            label1.Text = "Score: " + score;
            if (goLeft) { player.Left -= moveLeft; } // move left
            if (goRight) { player.Left += moveRight; } // move right
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
            
            if (score >= winScore)
            {
                Form1 mainForm = new Form1(state);
                gameOver();
                MessageBox.Show("You Win" + score);
                this.Hide();
                mainForm.ShowDialog();
                

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

            foreach(Block b in this.blocks)
            {
                b.Draw(e.Graphics);
            }
        }

        private void GameForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
