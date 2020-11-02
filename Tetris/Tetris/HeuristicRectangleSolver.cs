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
            var positions = Solver.PotentiallyValidPositions(polyminos, board.Width, board.Height);
            int index = 0;
            foreach (var t in polyminos)
            {
                index++;
                // wstaw klocek w najlepsze miejsce jesli sie da - skopiować od Poliny
                var rating = new Dictionary<(Polymino, Point), int>();
                foreach (var p in positions[t.Type])
                {
                    foreach (var rotated_polymino in t.Rotations())
                    {
                        if (board.CanPolyminoBePlacedInFields(p.X, p.Y, rotated_polymino))
                            rating.Add((rotated_polymino, p), board.RatePosition(p.X, p.Y, rotated_polymino));
                    }
                }
                (Polymino polymino, Point position)? best_position = Solver.FindBestRating(rating);
                if (best_position != null)
                {
                    board.PlacePolymino(best_position.Value.position.X, best_position.Value.position.Y, best_position.Value.polymino);
                }
                else // jesli sie nie da
                {
                    // wygenerować listę pociętych
                    var cuts = Solver.CutPolymino(t);
                    // znaleść największy który wejdzie z najmniejszą liczbą cięć
                    int max = 0;
                    int maxRate = 0;
                    Point position = new Point(0, 0);
                    Polymino maxToPlace = null;
                    Polymino maxToSkip = null;
                    var freePoints = board.GetFreePoints();
                    foreach (var poly in cuts[1])
                    {
                        foreach (var point in freePoints)
                        {
                            if (board.CanPolyminoBePlacedInEmpty(point.X, point.Y, poly.part1) && board.CanPolyminoBePlacedInFields(point.X, point.Y, poly.part1))
                            {
                                int rate = board.RatePosition(point.X, point.Y, poly.part1);
                                if (poly.part1.Points.Count > max || (poly.part1.Points.Count == max && rate > maxRate))
                                {
                                    max = poly.part1.Points.Count;
                                    maxRate = rate;
                                    maxToPlace = poly.part1;
                                    maxToSkip = poly.part2;
                                    position = point;
                                }
                            }
                            else if (board.CanPolyminoBePlacedInEmpty(point.X, point.Y, poly.part2) && board.CanPolyminoBePlacedInFields(point.X, point.Y, poly.part2))
                            {
                                int rate = board.RatePosition(point.X, point.Y, poly.part2);
                                if (poly.part2.Points.Count > max || (poly.part2.Points.Count == max && rate > maxRate))
                                {
                                    max = poly.part2.Points.Count;
                                    maxRate = rate;
                                    maxToPlace = poly.part2;
                                    maxToSkip = poly.part1;
                                    position = point;
                                }
                            }
                        }
                    }
                    // wstawić kloca, a resztę dodać na koniec listy
                    board.PlacePolymino(position.X, position.Y, maxToPlace);
                    polyminos.RemoveRange(0, index);
                    polyminos.Add(maxToSkip);
                    board = Solve(polyminos, board);
                    break;
                }
            }
            return board;
        }
    }
}