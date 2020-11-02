using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    public class Polymino
    {
        const int rotationAngle = 90;
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

        private List<Point> points;

        public List<Point> Points
        {
            get => points == null || !points.Any() ? Pentominos.pentominos[Type] : points;
            set => points = new List<Point>(value);
        }

        public List<Point> CanPlaceInEmptyRectangle(int width, int height)
        {
            Board board = new Board(width, height);
            List<Point> result = new List<Point>();
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if (board.CanPolyminoBePlacedInEmpty(i, j, this))
                    {
                        result.Add(new Point(i, j));
                    }
                }
            }
            return result;
        }

        public Polymino Rotate(int angle)
        {
            double cos = Math.Cos(angle);
            double sin = Math.Sin(angle);
            var rotatedPoints = Points.Select(p => new Point((int)(p.X * cos - p.Y * sin), (int)(p.X * sin+ p.Y * cos))).ToList();

            return new Polymino(this.Type, rotatedPoints);
        }

        public List<Polymino> Rotations()
        {

            List<Polymino> rotatedPolyminos = new List<Polymino>(); 
            for (int angle = 0; angle <= 270; angle += rotationAngle)
            {
                rotatedPolyminos.Add(Rotate(angle));
            }
            return rotatedPolyminos;

            //return new List<Polymino> { this };
        }

    }
}
