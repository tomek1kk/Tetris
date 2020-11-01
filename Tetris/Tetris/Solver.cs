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

	public abstract class Solver
	{
        public static void Solve(Board board, AlgorithmType algorithmType, List<Pentomino> pentominos)
        {
            var boardType = board.Width == board.Height ? BoardType.Square : BoardType.Rectangle;

            if (boardType == BoardType.Square)
            {
                if (algorithmType = AlgorithmType.precise)
                {
					PreciseSquareSolver.Solve(pentominos, board);
                }
                else
                {
                    HeuristicSquareSolver.Solve(pentominos, board);
                }
            }
            else
            {
                if (algorithmType = AlgorithmType.precise)
                {
					PreciseRectangleSolver.Solve(pentominos, board);
                }
                else
                {
					HeuristicRectangleSolver.Solve(pentominos, board);
                }
            }
        }
	}
}