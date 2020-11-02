using System;
using System.Collections.Generic;

namespace Tetris
{
    public static class HeuristicRectangleSolver
    {
        public static List<Board> Solve(List<Polymino> polyminos)
        {
			var sides = Solver.CalculateMinimalRectangle(polyminos);
            var result = Solve(polyminos, new Board(sides.width, sides.height));
			
			return new List<Board>() { result };
		}

        private static Board Solve(List<Polymino> polyminos, Board board)
        {
            for (int i = 0; i < polyminos.Count; i++)
            {
                // wstaw klocek w najlepsze miejsce jesli sie da - skopiować od Poliny

                // jesli sie nie da, 
                // wygenerować listę pociętych
                var cuts = Solver.CutPolymino(polyminos[i]);
                // znaleść największy który wejdzie z najmniejszą liczbą cięć

                // wstawić kloca, a resztę dodać na koniec listy

            }
        }
    }
}