using System;
using System.Collections.Generic;

namespace Tetris {
	public enum BoardType
	{
		Square,
		Rectangle
	}

	public enum AlgorithmType
	{
		precise,
		heuristic
	}

	public static class Solver
	{
        public static void Solve(Board board, AlgorithmType algorithmType, List<Polymino> polyminos)
        {
            var boardType = board.Width == board.Height ? BoardType.Square : BoardType.Rectangle;

            if (boardType == BoardType.Square)
            {
                if (algorithmType == AlgorithmType.precise)
                {
					PreciseSquareSolver.Solve(polyminos);
                }
                else
                {
                    HeuristicSquareSolver.Solve(polyminos);
                }
            }
            else
            {
                if (algorithmType == AlgorithmType.precise)
                {
					PreciseRectangleSolver.Solve(polyminos);
                }
                else
                {
					HeuristicRectangleSolver.Solve(polyminos);
                }
            }
        }

        public static int CalculateMinimalSquare(List<Polymino> pentominos)
        {
            const int polyminoSize = 5;
            return (int)Math.Ceiling(Math.Sqrt(polyminoSize * pentominos.Count));
        }

        public static (int, int) CalculateMinimalRectangle(List<Polymino> pentominos)
        {
            const int polyminoSize = 5;
            int rectangleArea = polyminoSize * pentominos.Count;
            int potentialSide = (int)Math.Sqrt(rectangleArea);
            while (rectangleArea % potentialSide != 0 && potentialSide > 0)
            {
                potentialSide--;
            }
            if (potentialSide == 0)
                throw new ArgumentException("cannot fit pentominos");

            return (rectangleArea / potentialSide, potentialSide);
        }
    }
}