using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace Tetris
{
    public static class FileReader
    {
        public static async Task<List<(List<Polymino> polyminos, ProblemType problemType, AlgorithmType algorithmType)>> LoadPolyminosFromFileAsync(string filePath)
        {
            var result = new List<(List<Polymino> polyminos, ProblemType problemType, AlgorithmType algorithmType)>();
            var reader = new StreamReader(filePath);
            string line;

            while(true)
            {
                if ((line = await reader.ReadLineAsync()) == null)
                    break;

                ValidateSize(line);
                (ProblemType problemType, AlgorithmType algorithmType) = ReadType(await reader.ReadLineAsync());
                List<Polymino> polyminos = ReadPolyminos(await reader.ReadLineAsync());
                result.Add((polyminos, problemType, algorithmType));
            }

            return result;
        }

        private static List<Polymino> ReadPolyminos(string line)
        {
            string[] numbersFromFile = line.Split(' ');
            int[] numbers = new int[numbersFromFile.Length];

            if (numbersFromFile.Length == 0)
                throw new ArgumentException("Incorrect polyminos input");

            if (numbersFromFile.Length == 1
                && int.TryParse(numbersFromFile[0], out int numberOfRandoms)
                && numberOfRandoms > 0)
                return GenerateRandomPolyminos(numberOfRandoms);

            for (int i = 0; i < numbersFromFile.Length; ++i)
            {
                if (!int.TryParse(numbersFromFile[i], out numbers[i]))
                    throw new ArgumentException("Incorrect polyminos input");
            }

            return GeneratePolyminosFromArrayOfTypes(numbers);
        }

        private static List<Polymino> GeneratePolyminosFromArrayOfTypes(int[] numbers)
        {
            var result = new List<Polymino>();

            for (int i = 0; i < numbers.Length; ++i)
            {
                if (numbers[i] <= 0)
                    continue;
                result.AddRange(GetNumberOfPolyminosOfGivenType(numbers[i], (Types)(i + 1)));
            }

            return result;
        }

        private static List<Polymino> GetNumberOfPolyminosOfGivenType(int numberOfPolyminos, Types type)
        {
            var result = new List<Polymino>();

            for (int i = 0; i < numberOfPolyminos; ++i)
            {
                result.Add(new Polymino(type, i+1));
            }

            return result;
        }

        private static List<Polymino> GenerateRandomPolyminos(int numberOfRandoms)
        {
            var result = new List<Polymino>();
            var random = new Random();
            int numberOfTypes = Enum.GetNames(typeof(Types)).Length - 1;

            for (int i = 0; i < numberOfRandoms; ++i)
            {
                var pentomino = random.Next(0, numberOfTypes + 1);
                result.Add(new Polymino((Types)pentomino, i+1));
            }

            return result;
        }

        private static (ProblemType problemType, AlgorithmType algorithmType) ReadType(string line)
        {
            switch (line)
            {
                case "ok":
                    return (ProblemType.Square, AlgorithmType.Precise);
                case "hk":
                    return (ProblemType.Square, AlgorithmType.Heuristic);
                case "op":
                    return (ProblemType.Rectangle, AlgorithmType.Precise);
                case "hp":
                    return (ProblemType.Rectangle, AlgorithmType.Heuristic);
                default:
                    throw new ArgumentException("Correct value of algorithm type must be given");
            }
        }

        private static void ValidateSize(string line)
        {
            if (!int.TryParse(line, out int size) || size != 5)
                throw new ArgumentException("Size has to be 5");
        }
    }
}
