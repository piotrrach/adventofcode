using System.Text.RegularExpressions;
using Year2022.Properties;

namespace Year2022.Day05
{
    public class PuzzleSolver
    {
        public static void Solve()
        {
            Console.WriteLine($"Part A output: {SolvePuzzlePart(false)}");
            Console.WriteLine($"Part B output: {SolvePuzzlePart(true)}");
        }

        private static string SolvePuzzlePart(bool IsPartB)
        {
            StorageOfSortedStacks<char> storageOfCrates = new StorageOfSortedStacks<char>();

            var lines = Resources.Day05.Split("\r\n");
            var entryStorageState = lines.TakeWhile(line => !string.IsNullOrEmpty(line)).SkipLast(1);
            var commands = lines.SkipWhile(line => !string.IsNullOrEmpty(line)).Skip(1);

            foreach (var line in entryStorageState)
            {
                for (int i = 1; i < line.Length; i++)
                {
                    if (line[i] == ' ')
                    {
                        continue;
                    }

                    if (i == 1 || (i - 1) % 4 == 0)
                    {
                        storageOfCrates.Add(i == 1 ? 1 : (i - 1) / 4 + 1, line[i]);
                    }
                }
            }

            foreach (var command in commands)
            {
                var numbers = Regex.Matches(command, @"\d+").Select(m => int.Parse(m.Value)).ToArray();
                storageOfCrates.Move(numbers[0], numbers[1], numbers[2], IsPartB);

                foreach (var stack in storageOfCrates)
                {
                    string s = "";
                    foreach (var value in stack)
                    {
                        s += value;
                    }
                }
            }

            return new string(storageOfCrates.Select(c => c.Peek()).ToArray());
        }
    }
}
