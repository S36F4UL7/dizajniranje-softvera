using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SloziSliku_80_2018
{
    class Game
    {
        public int ID;
        public string username;
        public int col;
        public int row;
        public int moveCount;
        public string time;

        public override string ToString()
        {
            return username + " - " + moveCount + " poteza";
        }
    }
}
