using Year2022.Properties;

namespace Year2022.Day06
{
    class PuzzleSolver
    {
        public static void Solve()
        {
            Console.WriteLine($"Character position of start-of-packet:" +
                $" {GetPositionOfStartMarkerPacket(Resources.Day06)}");
            Console.WriteLine($"Character position of start-of-message: " +
                $"{GetPositionOfStartMarkerMessage(Resources.Day06, 14)}");
        }

        private static int GetPositionOfStartMarkerPacket(string input)
        {
            for (int i = 3; i < input.Length; i++)
            {
                char A = input[i - 3], B = input[i - 2], C = input[i - 1], D = input[i];

                if (A != B && A != C && A != D && B != C && B != D && C != D)
                {
                    return i + 1;
                }
            }
            throw new ArgumentException("There are no 4 distinct successive characters.");
        }

        private static int GetPositionOfStartMarkerMessage(string input, int markerSize)
        {
            List<char> list = input.Take(markerSize).ToList();

            for (int i = markerSize; i < input.Length; i++)
            {
                if (list.Distinct().Count().Equals(markerSize))
                {
                    return i;
                }

                list.RemoveAt(0);
                list.Add(input[i]);
            }

            throw new ArgumentException($"There are no {markerSize} distinct successive characters.");
        }
    }
}
