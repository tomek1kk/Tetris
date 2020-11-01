using System;
using System.Collections.Generic;
using System.Linq;

namespace Tetris
{
    public static class PreciseSquareSolver
    {
		static List<Board> results;
		static Dictionary<Types, List<Point>> potentiallyValid;
		public static List<Board> Solve(List<Polymino> polyminos)
		{
			int side = Solver.CalculateMinimalSquare(polyminos);
			potentiallyValid = Solver.PotentiallyValidPositions(polyminos, side, side);
			results = new List<Board>();
			while (true)
			{
				Solve(polyminos, new Board(side, side), 0);
				if (!results.Any())
				{
					side++;
					potentiallyValid = Solver.PotentiallyValidPositions(polyminos, side, side);
				}
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
				foreach (var point in potentiallyValid[polyminos[i].Type])
				{
					if (board.CanPolyminoBePlaced(point.X, point.Y, polyminos[i]))
					{
						board.PlacePolymino(point.X, point.Y, polyminos[i]);
						Solve(polyminos, board, depth + 1);
						board.RemovePolymino(point.X, point.Y, polyminos[i]);
					}
				}
			}
		}
	}
}