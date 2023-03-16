if (args == null)
{
    Console.WriteLine("Please provide correct argument");
    return;
}

if(args.Length != 1)
{
    Console.WriteLine("You can provie maksimum 1 argument");
    return;
}

switch (args[0])
{
    case "-day01":
        Console.WriteLine("Run day01 solver");
        Year2022.Day01.PuzzleSolver.Solve();
        break;
    case "-day02":
        Console.WriteLine("Run day02 solver");
        Year2022.Day02.PuzzleSolver.Solve();
        break;
    case "-day03":
        Console.WriteLine("Run day03 solver");
        Year2022.Day03.PuzzleSolver.Solve();
        break;
    case "-day04":
        Console.WriteLine("Run day04 solver");
        Year2022.Day04.PuzzleSolver.Solve();
        break;
    case "-day05":
        Console.WriteLine("Run day05 solver");
        Year2022.Day05.PuzzleSolver.Solve();
        break;
    case "-day06":
        Console.WriteLine("Run day06 solver");
        Year2022.Day06.PuzzleSolver.Solve();
        break;
    default:
        Console.WriteLine("Argument not definded");
        break;
}