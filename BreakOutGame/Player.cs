using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakOutGame
{
   public  class Player
    {
        public string nickName { get; set; }
        public int points { get; set; }

        public Player(string nickName)
        {
            this.nickName = nickName;
            this.points = 0;
        }
    }
}
