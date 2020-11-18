using System.Collections.Generic;
using System.Linq;

namespace Tetris
{
    public static class PreciseSquareSolver
    {
        static bool stop = false;
        static List<Board> results;
        static List<Point> potentiallyValid;
        static Dictionary<Types, List<Polymino>> rotations;
        public static (List<Board>, int?) Solve(List<Polymino> polyminos, int solutionsLimit)
        {
            //int side = Solver.CalculateMinimalSquare(polyminos);
            //results = new List<Board>();
            //while (true)
            //{
            //    potentiallyValid = Solver.PotentiallyValidPositionsWithRotations(polyminos, side, side);
            //    Solve(polyminos, new Board(side, side), 0);
            //    if (!results.Any())
            //        side++;
            //    else
            //        break;
            //}
            //return (results, null);
            LoadRotations(polyminos);
            int side = Solver.CalculateMinimalSquare(polyminos);
            results = new List<Board>();
            while (results.Count == 0)
            {
                Solve(polyminos, new Board(side, side), 0);
                side++;
            }
            return (results, null);
        }

        private static void Solve(List<Polymino> polyminos, Board board, int depth)
        {

            //if (depth == polyminos.Count) // wszystkie klocki włożone
            //{
            //    results.Add(new Board(board));
            //    return;
            //}
            //for (int d = depth; d < polyminos.Count; d++)
            //{
            //    for (int i = 0; i < board.Height; i++)
            //    {
            //        for (int j = 0; j < board.Width; j++)
            //        {
            //            var curPoly = polyminos[d];
            //            foreach (var poly in curPoly.Rotations())
            //            {
            //                if (board.CanPolyminoBePlacedInFields(i, j, curPoly) && board.CanPolyminoBePlacedInEmpty(j, i, curPoly))
            //                {
            //                    board.PlacePolymino(i, j, poly);
            //                    Solve(polyminos, board, depth + 1);
            //                    board.RemovePolymino(i, j, poly);
            //                }
            //            }
            //        }
            //    }
            //}

            //if (depth == polyminos.Count) // wszystkie klocki włożone
            //{
            //    results.Add(new Board(board));
            //    return;
            //}
            //for (int i = depth; i < polyminos.Count; i++)
            //{
            //    foreach (var point in potentiallyValid)
            //    {
            //        foreach (var poly in polyminos[i].Rotations())
            //        {
            //            if (board.CanPolyminoBePlacedInFields(point.Y, point.X, poly))
            //            {
            //                board.PlacePolymino(point.Y, point.X, poly);
            //                Solve(polyminos, board, depth + 1);
            //                board.RemovePolymino(point.Y, point.X, poly);
            //            }
            //        }
            //    }
            //}

            if (stop == true)
                return;

            if (depth == polyminos.Count) // wszystkie klocki włożone
            {
                //if (results.Count > 1000)
                //    stop = true;
                results.Add(new Board(board));
                return;
            }
            for (int d = depth; d < polyminos.Count; d++)
            {
                var curPolymino = polyminos[d];
                foreach (var poly in rotations[curPolymino.Type])
                {
                    for (int j = 0; j < board.Width - poly.MaxY; j++)
                    {
                        for (int i = 0; i < board.Height - poly.MaxX; i++)
                        {
                            if (board.CanPolyminoBePlacedInFields(j, i, poly))
                            {
                                board.PlacePolymino(j, i, poly);
                                Solve(polyminos, board, depth + 1);
                                board.RemovePolymino(j, i, poly);
                            }
                        }
                    }
                }
            }
        }

        private static void LoadRotations(List<Polymino> polyminos)
        {
            rotations = new Dictionary<Types, List<Polymino>>();
            var types = polyminos.Select(p => p.Type).Distinct();
            foreach (var type in types)
            {
                var poly = polyminos.First(p => p.Type == type);
                rotations[type] = poly.Rotations();
            }
        }
    }
}
