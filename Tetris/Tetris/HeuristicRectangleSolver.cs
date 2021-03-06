﻿using System.Collections.Generic;

namespace Tetris
{
    public static class HeuristicRectangleSolver
    {
        private static int totalCuts;
        public static (List<Board>, int?) Solve(List<Polymino> polyminos)
        {
            totalCuts = 0;
            var sides = Solver.CalculateMinimalRectangle(polyminos);
            var result = Solve(polyminos, new Board(sides.width, sides.height));

            return (new List<Board>() { result }, totalCuts);
        }

        private static Board Solve(List<Polymino> polyminos, Board board)
        {
            var positions = Solver.PotentiallyValidPositionsPolymino(polyminos, board.Width, board.Height);
            int index = 0;
            foreach (var t in polyminos)
            {
                index++;
                // wstaw klocek w najlepsze miejsce jesli sie da - skopiować od Poliny
                var rating = new Dictionary<(Polymino, Point), int>();
                for (int width = 0; width < board.Width; width++)
                {
                    for (int height = 0; height < board.Height; height++)
                    {
                        var p = new Point(height, width);
                        foreach (var rotated_polymino in t.Rotations())
                        {
                            if (board.CanPolyminoBePlacedInEmpty(p.Y, p.X, rotated_polymino) && board.CanPolyminoBePlacedInFields(p.Y, p.X, rotated_polymino))
                                rating.Add((rotated_polymino, p), board.RatePosition(p.Y, p.X, rotated_polymino));
                        }
                    }
                }
                //foreach (var p in positions[t])
                //{
                //    foreach (var rotated_polymino in t.Rotations())
                //    {
                //        if (board.CanPolyminoBePlacedInEmpty(p.Y, p.X, rotated_polymino) && board.CanPolyminoBePlacedInFields(p.Y, p.X, rotated_polymino))
                //            rating.Add((rotated_polymino, p), board.RatePosition(p.Y, p.X, rotated_polymino));
                //    }
                //}
                (Polymino polymino, Point position)? best_position = Solver.FindBestRating(rating);
                if (best_position != null)
                {
                    board.PlacePolymino(best_position.Value.position.Y, best_position.Value.position.X, best_position.Value.polymino);
                }
                else // jesli sie nie da
                {
                    // wygenerować listę pociętych
                    var cuts = Solver.CutPolymino(t);
                    // znaleść największy który wejdzie z najmniejszą liczbą cięć
                    int max = 0;
                    int maxRate = 0;
                    int cutsMade = 0;
                    Point position = new Point(0, 0);
                    Polymino maxToPlace = null;
                    Polymino maxToSkip = null;
                    var freePoints = board.GetFreePoints();
                    foreach (var cut in cuts.Keys)
                    {
                        if (max > 0)
                            break;
                        foreach (var poly in cuts[cut])
                        {
                            foreach (var point in freePoints)
                            {
                                foreach (var rotatedPoly in poly.part1.Rotations())
                                {
                                    if (board.CanPolyminoBePlacedInEmpty(point.Y, point.X, rotatedPoly) && board.CanPolyminoBePlacedInFields(point.Y, point.X, rotatedPoly))
                                    {
                                        int rate = board.RatePosition(point.Y, point.X, rotatedPoly);
                                        if (rotatedPoly.Points.Count > max || (rotatedPoly.Points.Count == max && rate > maxRate))
                                        {
                                            max = rotatedPoly.Points.Count;
                                            maxRate = rate;
                                            maxToPlace = rotatedPoly;
                                            maxToSkip = poly.part2;
                                            position = point;
                                            cutsMade = cut;
                                        }
                                    }
                                }
                                if (maxToPlace == null)
                                {
                                    foreach (var rotatedPoly in poly.part2.Rotations())
                                    {
                                        if (board.CanPolyminoBePlacedInEmpty(point.Y, point.X, rotatedPoly) && board.CanPolyminoBePlacedInFields(point.Y, point.X, rotatedPoly))
                                        {
                                            int rate = board.RatePosition(point.Y, point.X, rotatedPoly);
                                            if (rotatedPoly.Points.Count > max || (rotatedPoly.Points.Count == max && rate > maxRate))
                                            {
                                                max = rotatedPoly.Points.Count;
                                                maxRate = rate;
                                                maxToPlace = rotatedPoly;
                                                maxToSkip = poly.part1;
                                                position = point;
                                                cutsMade = cut;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                    totalCuts += cutsMade;
                    // wstawić kloca, a resztę dodać na koniec listy
                    board.PlacePolymino(position.Y, position.X, maxToPlace);//
                    //polyminos.RemoveAt(index);
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