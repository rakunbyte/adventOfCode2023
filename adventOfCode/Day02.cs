namespace adventOfCode;

public class Game
{
    public int GameId { get; set; }
    public List<Round> Rounds { get; set; } = new();


    public Game(string line)
    {
        var gameAndRounds = line.Split(":");
        var gameIdString = gameAndRounds[0].Replace("Game ", "");
        GameId = int.Parse(gameIdString);
        
        var rounds = gameAndRounds[1];
        var roundStrings = rounds.Split(";");
        
        foreach (var roundString in roundStrings)
        {
            var round = new Round();
            var colorStrings = roundString.Split(",");
            foreach (var colorString in colorStrings)
            {
                if(colorString.Contains("blue")) round.BlueCubes = int.Parse(colorString.Replace("blue", ""));
                if(colorString.Contains("red")) round.RedCubes = int.Parse(colorString.Replace("red", ""));
                if(colorString.Contains("green")) round.GreenCubes = int.Parse(colorString.Replace("green", ""));
            }
            
            Rounds.Add(round);
        }
    }
 }

public class Round
{
    public int BlueCubes { get; set; } = 0;
    public int RedCubes { get; set; } = 0;
    public int GreenCubes { get; set; } = 0;
}

public static class Day02
{
    public static void Solve()
    {
        var input = FileReader.Read("inputs/day02.txt");
        var xxx = input.Select(x => new Game(x));

        var part1Answer = SolvePart1(input);
        //var part2Answer = SolvePart2(input);

        Console.WriteLine("Day 01");
        Console.WriteLine("------");
        Console.WriteLine($"Answer part 1: {part1Answer}");
        //Console.WriteLine($"Answer part 2: {part2Answer}");
    }

    private static int SolvePart1(IEnumerable<string> input)
    {
        return 0;
    }
}