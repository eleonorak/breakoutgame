using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakOutGame
{
    public abstract class Shape
    {
        public float X { get; set; }
        public float Y { get; set; }
        public Color color { get; set; }

        public Shape(float X,float Y,Color color)
        {
            this.X = X;
            this.Y = Y;
            this.color = color;
        }

        public abstract void Draw (Graphics g);
    }
}
