using System;
using System.IO;
using System.Linq;
using Year2022.Properties;

namespace Year2022.Day01
{
    class PuzzleSolver
    {
        private const int _topMostHardworkingElves = 3;

        public static void Solve()
        {
            var lines = Resources.Day01.Split("\r\n");
            int currentCalories = 0;
            int[] topElves = new int[_topMostHardworkingElves];

            foreach (var line in lines)
            {
                if (string.IsNullOrEmpty(line))
                {
                    if (currentCalories > topElves[_topMostHardworkingElves - 1])
                    {
                        topElves[_topMostHardworkingElves - 1] = currentCalories;
                        topElves = topElves.OrderByDescending(v => v).ToArray();
                    }
                    currentCalories = 0;
                    continue;
                }

                if (int.TryParse(line, out int calsToAdd))
                {
                    currentCalories += calsToAdd;
                }
                else
                {
                    throw new Exception($"line: {line} should be parsable to int32");
                }
            }

            Console.WriteLine($"Top most hardworking elf is carrying {topElves[0]}, \n" +
                              $"and the top {_topMostHardworkingElves} most hardworking elves are carrying {topElves.Sum()}");
        }
    }
}
