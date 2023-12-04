using adventOfCode;

namespace AdventOfCodeTests;

[TestClass]
public class Day01
{
    private List<string> Input { get; set; } = FileReader.Read("inputs/day01.txt");

    [TestMethod]
    public void Part1()
    {
        var result = Input.Sum(line => GetLeftNumber(line) * 10 + GetRightNumber(line));
        Assert.AreEqual(53921, result);
    }

    [TestMethod]
    public void Part2()
    {
        var result = Input.Sum(line =>
        {
            var line2 = ReplaceNumbers(line);
            return GetLeftNumber(line2) * 10 + GetRightNumber(line2);
        });
        
        Assert.AreEqual(54676, result);
    }
    
    private static int GetLeftNumber(string line)
    {
        for(var i = 0; i < line.Length; i++)
        {
            if (char.IsNumber(line[i])) return line[i] - '0';
        }

        throw new Exception("No number found");
    }
    
    private static int GetRightNumber(string line)
    {
        for(var i = line.Length - 1; i > -1; i--)
        {
            if (char.IsNumber(line[i])) return line[i] - '0';
        }

        throw new Exception("No number found");
    }

    private static string ReplaceNumbers(string line)
    {
        return line
            .Replace("oneight", "18", StringComparison.OrdinalIgnoreCase)
            .Replace("twone", "21", StringComparison.OrdinalIgnoreCase)
            .Replace("threeight", "38", StringComparison.OrdinalIgnoreCase)
            .Replace("fiveight", "58", StringComparison.OrdinalIgnoreCase)
            .Replace("sevenine", "79", StringComparison.OrdinalIgnoreCase)
            .Replace("eightwo", "82", StringComparison.OrdinalIgnoreCase)
            .Replace("eightree", "83", StringComparison.OrdinalIgnoreCase)
            .Replace("nineight", "98", StringComparison.OrdinalIgnoreCase)
            .Replace("one", "1", StringComparison.OrdinalIgnoreCase)
            .Replace("two", "2", StringComparison.OrdinalIgnoreCase)
            .Replace("three", "3", StringComparison.OrdinalIgnoreCase)
            .Replace("four", "4", StringComparison.OrdinalIgnoreCase)
            .Replace("five", "5", StringComparison.OrdinalIgnoreCase)
            .Replace("six", "6", StringComparison.OrdinalIgnoreCase)
            .Replace("seven", "7", StringComparison.OrdinalIgnoreCase)
            .Replace("eight", "8", StringComparison.OrdinalIgnoreCase)
            .Replace("nine", "9", StringComparison.OrdinalIgnoreCase);
    }
}