using System;
using System.Collections.Generic;
using System.Linq;

namespace Tetris
{
    public class Polymino : ICloneable
    {
        const double rotationAngle = Math.PI / 2;
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

        //public List<Polymino> getRotations => Rotations();
        private List<Point> points;

        public List<Point> Points
        {
            get => points == null || !points.Any() ? Pentominos.pentominos[Type] : points;
            set => points = new List<Point>(value);
        }

        public int MaxX
        {
            get
            {
                if (!maxX.HasValue)
                    maxX = Points.Max(p => p.X) + 1;
                return maxX.Value;
            }
        }
        public int MaxY
        {
            get
            {
                if (!maxY.HasValue)
                    maxY = Points.Max(p => p.Y) + 1;
                return maxY.Value;
            }
        }

        private int? maxX;
        private int? maxY;

        public List<Point> CanPlaceInEmptyRectangle(int width, int height)
        {
            Board board = new Board(width, height);
            List<Point> result = new List<Point>();
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if (board.CanPolyminoBePlacedInEmpty(j, i, this))
                    {
                        result.Add(new Point(j, i));
                    }
                }
            }
            return result;
        }


        public Polymino Rotate(double angle)
        {
            int cos = (int)Math.Cos(angle);
            int sin = (int)Math.Sin(angle);
            var rotatedPoints = Points.Select(p => new Point(p.X * sin+ p.Y * cos, p.X * cos - p.Y * sin)).ToList();
            Solver.AdjustPolyminoPoints(rotatedPoints);

            return new Polymino(this.Type, rotatedPoints);
        }

        public List<Polymino> Rotations()
        {
            List<Polymino> rotatedPolyminos = new List<Polymino>();
            for (double angle = rotationAngle; angle <= 4*rotationAngle; angle += rotationAngle)
            {
                rotatedPolyminos.Add(Rotate(angle));
            }

            //TODO: Tomek sprawdz

            return GetDistinctRotations(rotatedPolyminos);
        }

        private static List<Polymino> GetDistinctRotations(List<Polymino> polyminos)
        {
            var result = new List<Polymino>();
            foreach (var p in polyminos)
            {
                p.SortPoints();
            }

            polyminos.ForEach(p =>
            {
                if (!result.Any(r => PointsAreEqual(p, r)))
                {
                    result.Add(p);
                }
            });

            return result;
        }

        public void SortPoints()
        {
            Points.Sort((p1, p2) =>
            {
                if (p1.X < p2.X)
                    return -1;
                if (p1.X == p2.X && p1.Y < p2.Y)
                    return -1;
                return 1;
            });
        }

        private static bool PointsAreEqual(Polymino p1, Polymino p2)
        {
            return p1.points.Count == p2.points.Count
                   && !p1.points.Where((t, i) => t.X != p2.points[i].X || t.Y != p2.points[i].Y).Any();
        }

        public object Clone() =>
            new Polymino(Type, Points.Select(p => new Point(p.Y, p.X)).ToList());
    }
}
