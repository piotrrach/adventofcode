using Year2022.Properties;

namespace Year2022.Day03
{
    public class PuzzleSolver
    {
        public static void Solve()
        {
            Console.WriteLine($"Sum of priorities for part A: {SolvePartA()}");
            Console.WriteLine($"Sum of priorities for part B: {SolvePartB()}");
        }

        private static int SolvePartA()
        {
            int result = 0;
            string compartmentA, compartmentB;
            foreach (var rucksack in Resources.Day03.Split("\r\n"))
            {
                compartmentA = rucksack.Substring(0, rucksack.Length / 2);
                compartmentB = rucksack.Substring(rucksack.Length / 2, rucksack.Length / 2);
                result += CalculatePriority(compartmentA.First(c => compartmentB.Contains(c)));
            }
            return result;
        }

        private static int SolvePartB()
        {
            int result = 0;
            var lines = Resources.Day03.Split("\r\n");
            for (int i = 0; i < lines.Length - 2; i += 3)
            {
                var sharedElement = lines[i].First(c => lines[i + 1].Where(c2 =>  lines[i+2].Contains(c2)).Contains(c));
                result += CalculatePriority(sharedElement);
            }
            return result;
        }

        private static int CalculatePriority(char v)
        {
            if (char.IsLower(v))
            {
                return 26 - ('z' - v);
            }
            return 52 - ('Z' - v);
        }

    }
}
