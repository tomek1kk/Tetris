using System;
using System.Collections.Generic;

namespace Tetris {
	enum BoardType
	{
		Square,
		Rectangle
	}

	enum AlgorithmType
	{
		precise,
		heuristic
	}

	public static class Solver
	{

		public static void Solve(Board board, AlgorithmType algorithmType, List<Pentomino> pentominos)
		{
			var boardType = board.Width == board.Height ? BoardType.Square : BoardType.Rectangle;

			if (boardType == BoardType.Square)
				{
					if (algorithmType = AlgorithmType.precise)
					{
						SquarePrecise(pentominos, board);
					}
					else
					{
						SquareHeuristic(pentominos, board);
					}
				}
				else
				{
					if (algorithmType = AlgorithmType.precise)
					{
						RectanglePrecise(pentominos, board);
					}
					else
					{
						RectangleHeuristic(pentominos, board);
					}
				}
		}

		public static void SquarePrecise(List<Pentomino> pentominos, Board board)
		{

		}

		public static void RectanglePrecise(List<Pentomino> pentominos, Board board)
		{

		}

		public static void SquareHeuristic(List<Pentomino> pentominos, Board board)
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