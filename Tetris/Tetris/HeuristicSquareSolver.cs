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
				var rating = new Dictionary<(Polymino, Point), int>();
				foreach (var p in positions[t.Type])
				{
					foreach (var rotated_polymino in t.Rotations())
					{
						if (board.CanPolyminoBePlaced(p.X, p.Y, rotated_polymino))
						{
							rating.Add((rotated_polymino, p), board.RatePosition(p.X, p.Y, rotated_polymino));
						}
					}
				}
				(Polymino polymino, Point position)? best_position = Solver.FindBestRating(rating);
				if (best_position.Value.polymino == null)
				{
					return null; //no solution found, no place to put all pentominos in current board
				}
				else
				{
					board.PlacePolymino(best_position.Value.position.X, best_position.Value.position.Y, best_position.Value.polymino);
				}
			}
			return new List<Board>(){ board};
		}



	}
}