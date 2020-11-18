using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Tetris
{
    public static class PreciseRectangleSolver
    {
        private static List<Board> results = new List<Board>();
        private static int bestCuttingLength;
        private static int width;
        private static int height;
        private static Dictionary<Types, List<(int cutLength, List<Polymino> pieces)>> preparedCuts;
        private static Dictionary<Types[], List<(int sumCutLength, List<Polymino> pieces)>> preparedCutsCombinations;

        public static (List<Board>, int?) Solve(List<Polymino> polyminos, int solutionsLimit)
        {
            Stopwatch sw = Stopwatch.StartNew();

            InitializeHelpers(polyminos);

            List<List<Polymino>> permutations = GetAllPermutations(polyminos);
            Console.WriteLine($"I have {permutations.Count} permutations");
            permutations.ForEach(SolveCertainPermutation);

            sw.Stop();
            Console.WriteLine($"{results.Count} have been found with best cutting Length {bestCuttingLength} in {sw.ElapsedMilliseconds} ms");
            return (results, bestCuttingLength);
        }

        private static void InitializeHelpers(List<Polymino> polyminos)
        {
            results = new List<Board>();
            preparedCutsCombinations = new Dictionary<Types[], List<(int sumCutLength, List<Polymino> pieces)>>();
            bestCuttingLength = int.MaxValue;
            (width, height) = CalculateRectangleDimensions(polyminos.Count * Solver.PolyminoSize);
            preparedCuts = PrepateCuts(polyminos);
        }

        private static Dictionary<Types, List<(int cutLength, List<Polymino> pieces)>> PrepateCuts(List<Polymino> polyminos)
        {
            var result = new Dictionary<Types, List<(int cutLength, List<Polymino> pieces)>>();
            polyminos.ForEach(p =>
            {
                if (!result.ContainsKey(p.Type))
                {
                    result[p.Type] = Solver.GetAllCuts(p);
                }
            });

            return result;
        }

        private static void SolveCertainPermutation(List<Polymino> polyminos)
        {
            Console.WriteLine($"============================== Another permutation, current best length: {bestCuttingLength} ==============================");
            Solve(polyminos, new Board(width, height), 0, new List<Polymino>());
        }

        private static void Solve(List<Polymino> polyminos, Board board, int depth, List<Polymino> polyminosToBeCut)
        {
            if (depth == polyminos.Count)
            {
                if(board.IsSolved())
                {
                    AddResult(board, 0);
                    return;
                }
                if (polyminos.Count - depth <= bestCuttingLength)
                {
                    StartCutting(board, polyminosToBeCut);
                }
                return;
            }

            foreach (var polyminoRotation in polyminos[depth].Rotations())
            {
                for (int y = 0; y < board.Fields.GetLength(0); ++y)
                {
                    for (int x = 0; x < board.Fields.GetLength(1); ++x)
                    {
                        var point = new Point(y, x);
                        if (!board.CanPolyminoBePlacedInFields(point.Y, point.X, polyminoRotation))
                            continue;
                        if (polyminosToBeCut.Any())
                            return;

                        board.PlacePolymino(point.Y, point.X, polyminoRotation);
                        Solve(polyminos, board, depth + 1, polyminosToBeCut);
                        board.RemovePolymino(point.Y, point.X, polyminoRotation);
                    }
                }

                if (polyminos.Count - depth > bestCuttingLength)
                    return;

                polyminosToBeCut.Add(polyminoRotation);
                Solve(polyminos, board, depth + 1, polyminosToBeCut);
                polyminosToBeCut.RemoveAt(polyminosToBeCut.Count - 1);
            }
        }

        private static void AddResult(Board board, int cuttingLength)
        {
            if (cuttingLength > bestCuttingLength) return;
            Board boardCopy = new Board(board);

            if (cuttingLength == bestCuttingLength)
            {
                results.Add(boardCopy);
                return;
            }

            bestCuttingLength = cuttingLength;
            results = new List<Board> { boardCopy };
        }

        private static void StartCutting(Board board, List<Polymino> polyminos)
        {
            if (bestCuttingLength == 0 || polyminos.Count == 0)
                return;

            GetCutCombinations(polyminos).ForEach(c => PlaceCutPieces(board, c, 0));
        }

        private static List<(int sumCutLength, List<Polymino> pieces)> GetCutCombinations(List<Polymino> polyminos)
        {
            List<(int sumCutLength, List<Polymino> pieces)> cutCombinations;

            Types[] dictionaryKey = polyminos.Select(p => p.Type).OrderBy(p => p).ToArray();

            if (preparedCutsCombinations.Any(c => c.Key.SequenceEqual(dictionaryKey)))
            {
                cutCombinations = preparedCutsCombinations.First(p => p.Key.SequenceEqual(dictionaryKey)).Value
                    .Select(c => (c.sumCutLength, c.pieces.Select(p => (Polymino) p.Clone()).ToList()))
                    .Where(c => c.sumCutLength <= bestCuttingLength)
                    .OrderBy(c => c.sumCutLength).ToList();
            }
            else
            {
                List<List<(int cutLength, List<Polymino> pieces)>> cutsListForEachPolymino = GetCutsListForEachPolymino(polyminos);

                cutCombinations = GetAllPossibleCombinationsOfSelectigOneCutTingCombinationFromEachPiece(cutsListForEachPolymino)
                    .Where(c => c.sumCutLength <= bestCuttingLength)
                    .OrderBy(c => c.sumCutLength).ToList();

                preparedCutsCombinations[dictionaryKey] = cutCombinations
                    .Select(c => (c.sumCutLength, c.pieces.Select(p => (Polymino) p.Clone()).ToList())).ToList();
            }

            return cutCombinations;
        }

        private static List<List<(int cutLength, List<Polymino> pieces)>> GetCutsListForEachPolymino(List<Polymino> polyminos)
        {
            var result = new List<List<(int cutLength, List<Polymino> pieces)>>();

            polyminos.ForEach(poly =>
            {
                result.Add(preparedCuts[poly.Type]
                    .Select(c => (c.cutLength, c.pieces.Select(p => (Polymino) p.Clone()).ToList())).ToList());
            });

            return result;
        }


        private static List<(int sumCutLength, List<Polymino> pieces)> GetAllPossibleCombinationsOfSelectigOneCutTingCombinationFromEachPiece(
            List<List<(int cutLength, List<Polymino> pieces)>> combinationForEachPiece)
        {
            List<(int sumCutLength, List<Polymino> pieces)> result = new List<(int sumCutLength, List<Polymino> pieces)>();
            List<List<int>> indexesLists = GetIndexesForCombinations(combinationForEachPiece.Select(l => l.Count).ToList());

            for (int i = 0; i < indexesLists.Count; ++i)
            {
                List<(int cutLength, List<Polymino> pieces)> allCuts = new List<(int cutLength, List<Polymino> pieces)>();

                for (int j = 0; j < indexesLists[i].Count; j++)
                {
                    allCuts.Add(combinationForEachPiece[j][indexesLists[i][j]]);
                }

                int sumCutLength = allCuts.Sum(c => c.cutLength);
                List<Polymino> allCutPiecesConcatenated = allCuts.Aggregate(new List<Polymino>(), (a, b) => a.Concat(b.pieces).ToList());
                result.Add((sumCutLength, allCutPiecesConcatenated));
            }

            return result;
        }

        private static List<List<int>> GetIndexesForCombinations(
            List<int> lengths)
        {
            List<List<int>> result = new List<List<int>>();

            if (lengths.Count == 1)
            {
                for (int i = 0; i < lengths[0]; i++)
                {
                    result.Add(new List<int> { i });
                }

                return result;
            }

            for (int i = 0; i < lengths[0]; ++i)
            {
                List<List<int>> furtherIndexes = GetIndexesForCombinations(lengths.GetRange(1, lengths.Count - 1));

                foreach (var t in furtherIndexes)
                {
                    t.Insert(0, i);
                }

                result.AddRange(furtherIndexes);
            }

            return result;
        }

        private static void PlaceCutPieces(Board board, (int sumCutLength, List<Polymino> pieces) cutCombination, int depth)
        {
            if (cutCombination.sumCutLength > bestCuttingLength) return;

            if (depth == cutCombination.pieces.Count)
            {
                if(board.IsSolved())
                {
                    AddResult(board, cutCombination.sumCutLength);
                }

                return;
            }

            foreach (var pieceRotation in cutCombination.pieces[depth].Rotations())
            {
                for (int y = 0; y < board.Fields.GetLength(0); y++)
                {
                    for (int x = 0; x < board.Fields.GetLength(1); x++)
                    {
                        if (!board.CanPolyminoBePlacedInFields(y, x, pieceRotation)) continue;

                        board.PlacePolymino(y, x, pieceRotation);
                        PlaceCutPieces(board, cutCombination, depth + 1);
                        board.RemovePolymino(y, x, pieceRotation);
                    }
                }
            }
        }

        private static (int width, int height) CalculateRectangleDimensions(int area)
        {
            int highestDivisor = 1;
            for (int i = 2; i <= Math.Sqrt(area); ++i)
            {
                if (area % i == 0)
                {
                    highestDivisor = i;
                }
            }

            return (area / highestDivisor, highestDivisor);
        }

        private static List<List<Polymino>> GetAllPermutations(IEnumerable<Polymino> input)
        {
            IEnumerable<IEnumerable<Polymino>> allPermutations = Permutation<Polymino>(input);
            List<List<Polymino>> distinctPermutations = new List<List<Polymino>>();

            foreach (var permutation in allPermutations)
            {
                if (!distinctPermutations.Any(p => ArePermutationsEqual(permutation.ToList(), p)))
                {
                    distinctPermutations.Add(permutation.ToList());
                }
            }

            return distinctPermutations;
        }

        private static bool ArePermutationsEqual(List<Polymino> permutation1, List<Polymino> permutation2)
        {
            if (permutation1.Count != permutation2.Count)
                return false;

            return !permutation1.Where((t, i) => t.Type != permutation2[i].Type).Any();
        }

        private static IEnumerable<IEnumerable<T>> Permutation<T>(IEnumerable<T> input)
        {
            if (input == null || !input.Any()) yield break;
            if (input.Count() == 1) yield return input;

            foreach (var item in input)
            {
                var next = input.Where(l => !l.Equals(item)).ToList();
                foreach (var perm in Permutation(next))
                {
                    yield return (new List<T> { item }).Concat(perm);
                }
            }
        }
    }
}