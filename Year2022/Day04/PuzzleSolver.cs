using System.Text.RegularExpressions;
using Year2022.Common;
using Year2022.Properties;

namespace Year2022.Day04
{
    public class PuzzleSolver
    {
        public static void Solve()
        {
            Console.WriteLine($"Number of full overlaps: {SolvePartA()}");
            Console.WriteLine($"Number of any overlaps: {SolvePartB()}");
        }

        private static int SolvePartA()
        {
            int result = 0;
            var numbers = Regex.Matches(Resources.Day04, @"\d+").Select(p => int.Parse(p.Value)).ToArray();
            for (int i = 0; i < numbers.Length; i += 4)
            {
                if ((numbers[i] <= numbers[i + 2] && numbers[i + 1] >= numbers[i + 3])
                        || (numbers[i + 2] <= numbers[i] && numbers[i + 3] >= numbers[i + 1]))
                {
                    result++;
                }
            }
            return result;
        }

        private static int SolvePartB()
        {
            int result = 0;
            var numbers = Regex.Matches(Resources.Day04, @"\d+").Select(p => int.Parse(p.Value)).ToArray();
            for (int i = 0; i < numbers.Length; i += 4)
            {
                if (numbers[i].IsInRange(numbers[i + 2], numbers[i + 3])
                    || numbers[i + 1].IsInRange(numbers[i + 2], numbers[i + 3])
                    || numbers[i + 2].IsInRange(numbers[i], numbers[i + 1])
                    || numbers[i + 3].IsInRange(numbers[i], numbers[i + 1]))
                {
                    result++;
                }
            }

            return result;
        }
    }
}
