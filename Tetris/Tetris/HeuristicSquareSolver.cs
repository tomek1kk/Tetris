using System;
using System.Collections.Generic;

namespace Tetris
{
	public static class HeuristicSquareSolver : Solver
	{
		public static override void Solve(List<Pentomino> pentominos, Board board)
		{
			//foreach (var t in pentominos)
			//{
			//	var rating = new Dictionary<int, Pentomino>();
			//	foreach (var position in t.Rotations())
			//	{
			//		rating.Add(board.RatePosition(), position);
			//	}
			//	var best_position = rating.FindBestRating(rating);
			//	if (!best_position)
			//	{
			//		return null; //no solution found, no place to put all pentominos in current board
			//	}
			//	else
			//	{
			//		board.PlacePentomino(t, best_position);
			//	}s

			//}


		}

		public static Pentomino FindBestRating(Dictionary<Pentomino, int> rating)
		{
			if (!rating.Keys)
			{
				return null;
			}
			return rating[rating.Keys.Max()];
		}

		public static void RectangleHeuristic(List<Pentomino> pentominos, Board board)
		{

		}

	}
}