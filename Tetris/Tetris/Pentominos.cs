using System.Collections.Generic;

namespace Tetris
{
    public static class Pentominos
    {
        public static Dictionary<Types, Point[]> pentominos = new Dictionary<Types, Point[]>()
        {
            {Types.F, new Point[] {new Point(1, 0), new Point(0, 1) , new Point(1, 1) , new Point(2, 1) , new Point(0, 2) } },
            {Types.I, new Point[] {new Point(0, 0), new Point(1, 0) , new Point(2, 0) , new Point(3, 0) , new Point(4, 0) } },
            {Types.L, new Point[] {new Point(0, 0), new Point(1, 0) , new Point(2, 0) , new Point(3, 0) , new Point(3, 1) } },
            {Types.N, new Point[] {new Point(2, 0), new Point(3, 0) , new Point(0, 1) , new Point(1, 1) , new Point(2, 1) } },
            {Types.P, new Point[] {new Point(0, 0), new Point(1, 0) , new Point(2, 0) , new Point(0, 1) , new Point(1, 1) } },
            {Types.T, new Point[] {new Point(0, 0), new Point(0, 1) , new Point(0, 2) , new Point(1, 1) , new Point(2, 1) } },
            {Types.U, new Point[] {new Point(0, 0), new Point(0, 2) , new Point(1, 0) , new Point(1, 1) , new Point(1, 2) } },
            {Types.V, new Point[] {new Point(0, 0), new Point(1, 0) , new Point(2, 0) , new Point(0, 1) , new Point(0, 2) } },
            {Types.W, new Point[] {new Point(0, 0), new Point(1, 0) , new Point(1, 1) , new Point(2, 1) , new Point(2, 2) } },
            {Types.X, new Point[] {new Point(1, 0), new Point(0, 1) , new Point(1, 1) , new Point(2, 1) , new Point(1, 2) } },
            {Types.Y, new Point[] {new Point(1, 0), new Point(0, 1) , new Point(1, 1) , new Point(2, 1) , new Point(3, 1) } },
            {Types.Z, new Point[] {new Point(0, 0), new Point(0, 1) , new Point(1, 1) , new Point(2, 1) , new Point(2, 2) } }
        };
    }
}
