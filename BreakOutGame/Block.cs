using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakOutGame
{
    public class Block : Shape
    {
        public bool Show { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        public Rectangle Rectangle { get; set; }

        public Block(float X,float Y, Color color, int Width,int Height) : base(X,Y,color)
        {
            this.Width = Width;
            this.Height = Height;
            this.Rectangle = new Rectangle(new Point((int)X, (int)Y), new Size(Width, Height));
            this.Show = true;
        }

        public void setPosition(float X, float Y)
        {
            this.X = X;
            this.Y = Y;
            this.Rectangle = new Rectangle(new Point((int)X, (int)Y), new Size(Width, Height));
        }
        public override void Draw(Graphics g)
        {
            if(Show)
            {
            Brush b = new SolidBrush(color);
            
            g.FillRectangle(b, X, Y, Width, Height);


            b.Dispose();
            }

        }
    }
}
