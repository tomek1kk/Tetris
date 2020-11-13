using System.Collections.Generic;
using System.Linq;

namespace Tetris
{
    public static class PreciseSquareSolver
    {
        static List<Board> results;
        static List<Point> potentiallyValid;
        public static List<Board> Solve(List<Polymino> polyminos)
        {
            int side = Solver.CalculateMinimalSquare(polyminos);
            results = new List<Board>();
            while (true)
            {
                potentiallyValid = Solver.PotentiallyValidPositionsWithRotations(polyminos, side, side);
                Solve(polyminos, new Board(side, side), 0);
                if (!results.Any())
                    side++;
                else
                    break;
            }
            return results;
        }

        private static void Solve(List<Polymino> polyminos, Board board, int depth)
        {
            if (depth == polyminos.Count) // wszystkie klocki włożone
            {
                results.Add(new Board(board));
                return;
            }
            for (int i = depth; i < polyminos.Count; i++)
            {
                foreach (var point in potentiallyValid)
                {
                    foreach (var poly in polyminos[i].Rotations())
                    {
                        if (board.CanPolyminoBePlacedInFields(point.Y, point.X, poly))
                        {
                            board.PlacePolymino(point.Y, point.X, poly);
                            Solve(polyminos, board, depth + 1);
                            board.RemovePolymino(point.Y, point.X, poly);
                        }
                    }
                }
            }
        }
    }
}