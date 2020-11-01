using System;
using System.Collections.Generic;

namespace Tetris
{
	public static class HeuristicSquareSolver
	{
		public static void Solve(List<Polymino> polyminos)
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
			//	}
			//}
		}

		public static Polymino FindBestRating(Dictionary<Polymino, int> rating)
		{
			//if (!rating.Keys)
			//{
			//	return null;
			//}
			//return rating[rating.Keys.Max()];
			return null;
		}
	}
}