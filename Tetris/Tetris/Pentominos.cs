using System.Collections.Generic;
using System.Drawing;

namespace Tetris
{
    public static class Pentominos
    {
        public static Dictionary<Types, List<Point>> pentominos = new Dictionary<Types, List<Point>>()
        {
            {Types.F, new List<Point> {new Point(1, 0), new Point(0, 1) , new Point(1, 1) , new Point(2, 1) , new Point(0, 2) } },
            {Types.I, new List<Point> {new Point(0, 0), new Point(1, 0) , new Point(2, 0) , new Point(3, 0) , new Point(4, 0) } },
            {Types.L, new List<Point> {new Point(0, 0), new Point(1, 0) , new Point(2, 0) , new Point(3, 0) , new Point(3, 1) } },
            {Types.N, new List<Point> {new Point(2, 0), new Point(3, 0) , new Point(0, 1) , new Point(1, 1) , new Point(2, 1) } },
            {Types.P, new List<Point> {new Point(0, 0), new Point(1, 0) , new Point(2, 0) , new Point(0, 1) , new Point(1, 1) } },
            {Types.T, new List<Point> {new Point(0, 0), new Point(0, 1) , new Point(0, 2) , new Point(1, 1) , new Point(2, 1) } },
            {Types.U, new List<Point> {new Point(0, 0), new Point(0, 2) , new Point(1, 0) , new Point(1, 1) , new Point(1, 2) } },
            {Types.V, new List<Point> {new Point(0, 0), new Point(1, 0) , new Point(2, 0) , new Point(0, 1) , new Point(0, 2) } },
            {Types.W, new List<Point> {new Point(0, 0), new Point(1, 0) , new Point(1, 1) , new Point(2, 1) , new Point(2, 2) } },
            {Types.X, new List<Point> {new Point(1, 0), new Point(0, 1) , new Point(1, 1) , new Point(2, 1) , new Point(1, 2) } },
            {Types.Y, new List<Point> {new Point(1, 0), new Point(0, 1) , new Point(1, 1) , new Point(2, 1) , new Point(3, 1) } },
            {Types.Z, new List<Point> {new Point(0, 0), new Point(0, 1) , new Point(1, 1) , new Point(2, 1) , new Point(2, 2) } }
        };

        public static Dictionary<Types, Color> colors = new Dictionary<Types, Color>()
        {
            {Types.F, Color.FromArgb(100, 100, 100) }
        };


    }
}
