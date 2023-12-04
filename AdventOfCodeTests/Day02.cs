using adventOfCode;

namespace AdventOfCodeTests;

[TestClass]
public class Day02
{
    private List<string> Input { get; set; } = FileReader.Read("inputs/day02.txt");
    
    [TestMethod]
    public void Part1()
    {
        var games = Input.Select(x => new Game(x));
        var result = games
            .Where(x => x.maxRedCubes <= 12)
            .Where(x => x.maxGreenCubes <= 13)
            .Where(x => x.maxBlueCubes <= 14)
            .Sum(x => x.GameId);
        
        Assert.AreEqual(2439, result);
    }

    [TestMethod]
    public void Part2()
    {
        
    }

}

public class Game
{
    public int GameId { get; set; }
    public List<Round> Rounds { get; set; } = new();

    public int maxBlueCubes => Rounds.Max(x => x.BlueCubes);
    public int maxGreenCubes => Rounds.Max(x => x.GreenCubes);
    public int maxRedCubes => Rounds.Max(x => x.RedCubes);

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