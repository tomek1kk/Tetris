using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Tetris {
	public enum ProblemType
	{
		Square,
		Rectangle
	}

	public enum AlgorithmType
	{
		Precise,
		Heuristic
	}

	public static class Solver
	{
        const int polyminoSize = 5;
        public static List<Board> Solve(ProblemType problemType, AlgorithmType algorithmType, List<Polymino> polyminos)
        {

            if (problemType == ProblemType.Square)
            {
                if (algorithmType == AlgorithmType.Precise)
                {
					return PreciseSquareSolver.Solve(polyminos);
                }
                else
                {
                    return HeuristicSquareSolver.Solve(polyminos);
                }
            }
            else
            {
                if (algorithmType == AlgorithmType.Precise)
                {
					return PreciseRectangleSolver.Solve(polyminos);
                }
                else
                {
                    return HeuristicRectangleSolver.Solve(polyminos).Item1;
                }
            }
        }

        public static int CalculateMinimalSquare(List<Polymino> pentominos)
        {
            return (int)Math.Ceiling(Math.Sqrt(polyminoSize * pentominos.Count));
        }

        public static (int width, int height) CalculateMinimalRectangle(List<Polymino> pentominos)
        {
            int rectangleArea = polyminoSize * pentominos.Count;
            int potentialSide = (int)Math.Sqrt(rectangleArea);
            while (rectangleArea % potentialSide != 0 && potentialSide > 0)
            {
                potentialSide--;
            }
            if (potentialSide == 0)
                throw new ArgumentException("cannot fit pentominos");

            return (rectangleArea / potentialSide, potentialSide);
        }

        // Ta funkcja działa tylko dla pentomino
        public static Dictionary<Types, List<Point>> PotentiallyValidPositions(List<Polymino> polyminos, int width, int height)
        {
            var result = new Dictionary<Types, List<Point>>();
            foreach (var polymino in polyminos)
            {
                if (!result.ContainsKey(polymino.Type))
                    result[polymino.Type] = polymino.CanPlaceInEmptyRectangle(width, height);
            }
            return result;
        }

        // Ta funkcja działa dla każdego polymino
        public static Dictionary<Polymino, List<Point>> PotentiallyValidPositionsPolymino(List<Polymino> polyminos, int width, int height)
        {
            var result = new Dictionary<Polymino, List<Point>>();
            foreach (var polymino in polyminos)
            {
                 result[polymino] = polymino.CanPlaceInEmptyRectangle(width, height);
            }
            return result;
        }

        public static Dictionary<int, List<(Polymino part1, Polymino part2)>> CutPolymino(Polymino polymino)
        {
            var result = new Dictionary<int, List<(Polymino part1, Polymino part2)>>();
            result[1] = new List<(Polymino part1, Polymino part2)>();
            result[2] = new List<(Polymino part1, Polymino part2)>();

            (int x, int y) polyminoRect = (polymino.Points.Max(point => point.X) + 1, polymino.Points.Max(point => point.Y) + 1);
            for (int i = 1; i < polyminoRect.x; i++)
            {
                if (polymino.Type == Types.U && polymino.Points.Count == 5) // przypadek który zwróciłby błędnie
                {
                    result[1].Add((new Polymino(Types.U, new List<Point>() { new Point(0, 0) }),
                                   new Polymino(Types.U, new List<Point>() { new Point(0, 0), new Point(0, 1), new Point(0, 2), new Point(1, 2) })));
                    result[1].Add((new Polymino(Types.U, new List<Point>() { new Point(0, 0) }),
                                   new Polymino(Types.U, new List<Point>() { new Point(0, 0), new Point(0, 1), new Point(0, 2), new Point(1, 0) })));
                    continue;
                }
                var points1 = polymino.Points.Where(p => p.X < i).ToList();
                var points2 = polymino.Points.Where(p => p.X >= i).ToList();
                int cutLength = points1.Count(p => p.X == i - 1 && points2.Any(p2 => p2.X == i && p2.Y == p.Y));
                result[cutLength].Add(points1.Count > points2.Count ?
                    (GetPolyminoFromPoints(points1, polymino.Type), GetPolyminoFromPoints(points2, polymino.Type)) :
                    (GetPolyminoFromPoints(points2, polymino.Type), GetPolyminoFromPoints(points1, polymino.Type)));
            }
            for (int i = 1; i < polyminoRect.y; i++)
            {
                var points1 = polymino.Points.Where(p => p.Y < i).ToList();
                var points2 = polymino.Points.Where(p => p.Y >= i).ToList();
                int cutLength = points1.Count(p => p.Y == i - 1 && points2.Any(p2 => p2.Y == i && p2.X == p.X));
                result[cutLength].Add(points1.Count > points2.Count ? 
                    (GetPolyminoFromPoints(points1, polymino.Type), GetPolyminoFromPoints(points2, polymino.Type)) :
                    (GetPolyminoFromPoints(points2, polymino.Type), GetPolyminoFromPoints(points1, polymino.Type)));
            }

            return result;
        }

        private static void AdjustPolyminoPoints(List<Point> points)
        {
            int minX = points.Min(p => p.X);
            int minY = points.Min(p => p.Y);
            
            for (int i = 0; i < points.Count; i++)
            {
                var point = new Point(points[i].X - minX, points[i].Y - minY);
                points[i] = point;
            }
        }

        private static Polymino GetPolyminoFromPoints(List<Point> points, Types type)
        {
            AdjustPolyminoPoints(points);
            return new Polymino(type, points);
        }


        public static (Polymino polymino, Point position)? FindBestRating(Dictionary<(Polymino, Point), int> rating)
        {
            if (rating.Count == 0)
            {
                return null;
            }

            return rating.FirstOrDefault(x => x.Value == rating.Values.Max()).Key;
        }
    }
}