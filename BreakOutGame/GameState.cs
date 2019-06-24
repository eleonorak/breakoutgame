using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakOutGame
{
    public class GameState
    {
       

        public  Player player { get; set; }
        public Color ballColor { get; set; }
        public Color backgroundColor { get; set; }
        public Color blocksColor { get; set; }
        public Color playerColor { get; set; }
        public bool isMoreColor { get; set; }
        public int level { get; set; }


        public GameState() { }
    }
}
