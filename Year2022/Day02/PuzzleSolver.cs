using Year2022.Properties;

namespace Year2022.Day02
{
    public class PuzzleSolver
    {
        public static void Solve()
        {
            Console.WriteLine($"Total score for part A : {GetScoreForPartA()}");
            Console.WriteLine($"Total score for part B : {GetScoreForPartB()}");
        }

        private static int GetScoreForPartA()
        { 
            int score = 0;

            foreach (var line in Resources.Day02.Split("\r\n"))
            {
                switch (line)
                {
                    //second character is what player has to choose, points are counted as follows:
                    //win = 6, draw = 3, lose = 0
                    //rock = 1, paper = 2, scissors = 3
                    case "A X": // rock + rock = draw => 1 + 3 = 4
                        score += 4;
                        break;
                    case "A Y": // rock + paper = win => 2 + 6 = 8
                        score += 8;
                        break;
                    case "A Z": // rock + scissors = lose => 3 + 0 = 3
                        score += 3;
                        break;
                    case "B X": // paper + rock = lose => 1 + 0 = 1
                        score += 1;
                        break;
                    case "B Y": // paper + paper = draw => 3 + 2 = 5
                        score += 5;
                        break;
                    case "B Z": // paper + scissors = win => 3 + 6 = 9
                        score += 9;
                        break;
                    case "C X": // scissors + rock = win => 1 + 6 = 7
                        score += 7;
                        break;
                    case "C Y": // scissors + paper = lose => 2 + 0 = 2
                        score += 2;
                        break;
                    case "C Z": // scissors + scissors = draw => 3 + 3 = 6;
                        score += 6;
                        break;
                    default:
                        throw new ArgumentException($"line {line} is invalid");
                }
            }
            return score;
        }

        private static int GetScoreForPartB()
        {
            int score = 0;

            foreach (var line in Resources.Day02.Split("\r\n"))
            {
                switch (line)
                {
                    //second character is what player has to do:
                    //X => player needs to lose
                    //Y => player needs to draw
                    //Z => player needs to win
                    //points are counted as follows:
                    //win = 6, draw = 3, lose = 0
                    //rock = 1, paper = 2, scissors = 3
                    case "A X": // lose by playing scissors => 0 + 3 = 3
                        score += 3;
                        break;
                    case "A Y": // draw by playing rock => 1 + 3 = 4
                        score += 4;
                        break;
                    case "A Z": // win by playing paper => 2 + 6 = 8
                        score += 8;
                        break;
                    case "B X": // lose by playing rock => 1 + 0 = 2
                        score += 2;
                        break;
                    case "B Y": // draw by playing paper => 2 + 3 = 5
                        score += 5;
                        break;
                    case "B Z": // win by playing scissors => 3 + 6 = 9
                        score += 9;
                        break;
                    case "C X": // lose by playing paper => 2 + 0 = 2
                        score += 2;
                        break;
                    case "C Y": // draw by playing scissors => 3 + 3 = 6
                        score += 6;
                        break;
                    case "C Z": // win by playing rockc => 1=+ 6 = 7
                        score += 7;
                        break;
                    default:
                        throw new ArgumentException($"line {line} is invalid");
                }
            }
            return score;
        }
    }
}