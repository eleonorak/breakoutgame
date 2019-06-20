using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakOutGame
{
    public class Ball : Shape
    {
        
        public float radius { get; set; }
        

        public Ball(float X,float Y, Color color, float radius) : base(X,Y,color)
        {

            this.radius = radius;

        }


      

        public bool IntersectsWith(float x, float y)
        {
            double d = Math.Sqrt((X - x) * (X - x) + (Y - y) * (Y - y));
            return d <= radius;
        }

        public override void Draw(Graphics g)
        {
            Brush b = new SolidBrush(color);
            g.FillEllipse(b, X - radius, Y - radius, 2 * radius, 2 * radius);

            b.Dispose();
        }
    }
}
