using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InertiaUI
{
    internal class Player
    {
        public int lives { get; internal set; }
        public int x { get; internal set; }
        public int y { get; internal set; }


        public Player(int lives = 3)
        {
            this.lives = lives;
        }

    }
}
