using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    public class Polymino
    {
        public Polymino(Types type)
        {
            Type = type;
        }

        public Polymino(Types type, List<Point> points)
        {
            Type = type;
            Points = points;
        }

        public Types Type { get; set; }

        public List<Point> Points
        {
            get
            {
                if (Points == null || !Points.Any())
                    return Pentominos.pentominos[Type];
                else
                    return Points;
            }
            set
            {
                Points = new List<Point>(value);
            }
        }

    }
}
