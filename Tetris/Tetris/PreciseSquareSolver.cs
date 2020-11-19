using System.Collections.Generic;
using System.Linq;

namespace Tetris
{
    public static class PreciseSquareSolver
    {
        static bool stop = false;
        static List<Board> results;
        static Dictionary<Types, List<Polymino>> rotations;
        public static (List<Board>, int?) Solve(List<Polymino> polyminos, int solutionsLimit)
        {
            LoadRotations(polyminos);
            int side = Solver.CalculateMinimalSquare(polyminos);
            results = new List<Board>();
            while (results.Count == 0)
            {
                Solve(polyminos, new Board(side, side), 0, solutionsLimit);
                side++;
            }
            return (results, null);
        }

        private static void Solve(List<Polymino> polyminos, Board board, int depth, int solutionsLimit)
        {

            if (stop)
                return;

            if (depth == polyminos.Count) // wszystkie klocki włożone
            {
                if (results.Count > solutionsLimit)
                    stop = true;
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
                                Solve(polyminos, board, depth + 1, solutionsLimit);
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
