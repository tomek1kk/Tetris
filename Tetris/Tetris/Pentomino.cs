using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    public class Pentomino
    {
        public Types Type { get; set; }
        public Pentomino(Types type)
        {
            Type = type;
        }

    }
}
