using System;
using System.Collections.Generic;
using System.Linq;

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
        public const int PolyminoSize = 5;
        private const int SortingMagicNumber = 1_000_000;
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
            return (int)Math.Ceiling(Math.Sqrt(PolyminoSize * pentominos.Count));
        }

        public static (int width, int height) CalculateMinimalRectangle(List<Polymino> pentominos)
        {
            int rectangleArea = PolyminoSize * pentominos.Count;
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
                                   new Polymino(Types.U, new List<Point>() { new Point(0, 0), new Point(1, 0), new Point(2, 0), new Point(2, 1) })));
                    result[1].Add((new Polymino(Types.U, new List<Point>() { new Point(0, 0) }),
                                   new Polymino(Types.U, new List<Point>() { new Point(0, 0), new Point(1, 0), new Point(2, 0), new Point(0, 1) })));
                    continue;
                }
                //CutPolymino(polymino, result, i);
                var points1 = polymino.Points.Where(p => p.X < i).ToList();
                var points2 = polymino.Points.Where(p => p.X >= i).ToList();
                int cutLength = points1.Count(p => p.X == i - 1 && points2.Any(p2 => p2.X == i && p2.Y == p.Y));
                result[cutLength].Add(points1.Count > points2.Count ?
                    (GetPolyminoFromPoints(points1, polymino.Type), GetPolyminoFromPoints(points2, polymino.Type)) :
                    (GetPolyminoFromPoints(points2, polymino.Type), GetPolyminoFromPoints(points1, polymino.Type)));
            }
            for (int i = 1; i < polyminoRect.y; i++)
            {
                //CutPolymino(polymino, result, i);
                var points1 = polymino.Points.Where(p => p.Y < i).ToList();
                var points2 = polymino.Points.Where(p => p.Y >= i).ToList();
                int cutLength = points1.Count(p => p.Y == i - 1 && points2.Any(p2 => p2.Y == i && p2.X == p.X));
                result[cutLength].Add(points1.Count > points2.Count ?
                    (GetPolyminoFromPoints(points1, polymino.Type), GetPolyminoFromPoints(points2, polymino.Type)) :
                    (GetPolyminoFromPoints(points2, polymino.Type), GetPolyminoFromPoints(points1, polymino.Type)));
            }

            return result;
        }

        public static List<(int sumCutLength, List<Polymino> pieces)> GetAllCuts(Polymino polymino)
        {
            var result = new List<(int sumCutLength, List<Polymino> pieces)>();

            Dictionary<int, List<(Polymino part1, Polymino part2)>> singleCutPolymino = CutPolymino(polymino);

            foreach (var cutLength in singleCutPolymino.Keys)
            {
                foreach (var parts in singleCutPolymino[cutLength])
                {
                    PerformRecurreceCuttingAndMergingPolyminosParts(result, cutLength, parts);
                }
            }

            result = GetDistinctCutsCombinations(result);

            return result;
        }

        private static void PerformRecurreceCuttingAndMergingPolyminosParts(
            List<(int sumCutLength, List<Polymino> pieces)> result,
            int currentCutLength,
            (Polymino part1, Polymino part2) parts)
        {
            result.Add((currentCutLength, new List<Polymino> { parts.part1, parts.part2 }));

            var part1Cuts = GetAllCuts(parts.part1);
            var part2Cuts = GetAllCuts(parts.part2);

            if (parts.part1.Points.Count > 1)
            {
                foreach (var part1Cut in part1Cuts)
                {
                    var toAppend = new List<Polymino> { parts.part2 };
                    toAppend.AddRange(part1Cut.pieces);
                    result.Add((currentCutLength + part1Cut.sumCutLength, toAppend));

                    if (parts.part2.Points.Count <= 1) continue;

                    foreach (var part2Cut in part2Cuts)
                    {
                        var toAppend2 = new List<Polymino>();
                        toAppend2.AddRange(part1Cut.pieces);
                        toAppend2.AddRange(part2Cut.pieces);
                        result.Add((currentCutLength + part1Cut.sumCutLength + part2Cut.sumCutLength, toAppend2));
                    }
                }
            }

            if (parts.part2.Points.Count <= 1) return;

            foreach (var part2Cut in part2Cuts)
            {
                var toAppend = new List<Polymino> { parts.part1 };
                toAppend.AddRange(part2Cut.pieces);
                result.Add((currentCutLength + part2Cut.sumCutLength, toAppend));
            }
        }

        private static List<(int sumCutLength, List<Polymino> pieces)> GetDistinctCutsCombinations(List<(int sumCutLength, List<Polymino> pieces)> cuts)
        {
            var result = new List<(int sumCutLength, List<Polymino> pieces)>();
            cuts = cuts.OrderBy(c => c.sumCutLength).ToList();
            int currentSum = 1;

            while (cuts.Any(c => c.sumCutLength == currentSum))
            {
                List<(int sumCutLength, List<Polymino> pieces)> currentCuts = cuts.Where(c => c.sumCutLength == currentSum).ToList();
                SortPolyminosAndPoints(currentCuts);
                result.AddRange(GetUniqueCombinationsForGivenCutLength(currentCuts));
                ++currentSum;
            }

            return result;
        }

        private static List<(int sumCutLength, List<Polymino> pieces)> GetUniqueCombinationsForGivenCutLength(List<(int sumCutLength, List<Polymino> pieces)> currentCuts)
        {
            var result = new List<(int sumCutLength, List<Polymino> pieces)>();

            currentCuts.ForEach(c =>
            {
                if (!result.Any(r => CutCombinationsAreEqual(c, r)))
                {
                    result.Add(c);
                }
            });

            return result;
        }

        private static bool CutCombinationsAreEqual((int sumCutLength, List<Polymino> pieces) c1,
            (int sumCutLength, List<Polymino> pieces) c2)
        {
            if (c1.pieces.Count != c2.pieces.Count)
                return false;

            return !c1.pieces.Where((t, i) =>
            {
                Polymino standarizedOrientationPolymino1 = StandarizeOrientation(t);
                Polymino standarizedOrientationPolymino2 = StandarizeOrientation(c2.pieces[i]);
                return GetOrderScore(standarizedOrientationPolymino1) != GetOrderScore(standarizedOrientationPolymino2);
            }).Any();
        }

        private static Polymino StandarizeOrientation(Polymino polymino) =>
            polymino.Rotations().OrderBy(GetOrderScore).Last();

        private static void SortPolyminosAndPoints(List<(int sumCutLength, List<Polymino> pieces)> cuts)
        {
            for (int i = 0; i < cuts.Count; ++i)
            {
                foreach (var piece in cuts[i].pieces)
                {
                    piece.SortPoints();
                }

                cuts[i] = (cuts[i].sumCutLength, cuts[i].pieces.OrderBy(GetOrderScore).ToList());
            }
        }

        private static int GetOrderScore(Polymino polymino) =>
            polymino.Points.Count * SortingMagicNumber + polymino.Points.Sum(p => 2 ^ (p.X + p.Y * PolyminoSize));

        public static void AdjustPolyminoPoints(List<Point> points)
        {
            int minX = points.Min(p => p.X);
            int minY = points.Min(p => p.Y);

            for (int i = 0; i < points.Count; i++)
            {
                var point = new Point(points[i].Y - minY, points[i].X - minX);
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