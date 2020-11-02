using System;
using System.Collections.Generic;
using System.Linq;

namespace Tetris
{
	public static class HeuristicSquareSolver
	{
		public static List<Board> Solve(List<Polymino> polyminos)
		{
			int side = Solver.CalculateMinimalSquare(polyminos);
			List<Board> solution = null;
			while (solution == null)
			{
				solution = Solve(polyminos, new Board(side, side));
				side++;
			}
			return solution;
		}

		private static List<Board> Solve(List<Polymino> polyminos, Board board)
		{
			var positions = Solver.PotentiallyValidPositions(polyminos, board.Width, board.Height);
			foreach (var t in polyminos)
			{
				foreach(var p in positions[t.Type])
				{
					var rating = new Dictionary<int, (Polymino, Point)>();
					foreach (var rotated_polymino in t.Rotations())
					{
						rating.Add(board.RatePosition(p.X, p.Y, rotated_polymino), (rotated_polymino, p));
					}
					(Polymino polymino, Point position)? best_position = FindBestRating(rating);
					if (best_position == null)
					{
						return null; //no solution found, no place to put all pentominos in current board
					}
					else
					{
						board.PlacePolymino(best_position.Value.position.X, best_position.Value.position.Y, best_position.Value.polymino);
					}
				}
			}
			return null;
		}


		public static (Polymino polymino, Point position)? FindBestRating(Dictionary<int, (Polymino, Point)> rating)
		{
			if (rating.Keys == null)
			{
				return null;
			}
			return rating[rating.Keys.Max()];
		}
	}
}