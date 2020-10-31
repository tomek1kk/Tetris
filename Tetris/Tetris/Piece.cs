using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    public class Piece
    {
        public Types Type { get; set; }
        public Piece(Types type)
        {
            Type = type;
        }

    }
}
