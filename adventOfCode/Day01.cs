namespace adventOfCode;

public static class Day01
{
    public static void Solve()
    {
        var input = FileReader.Read("inputs/day01.txt");

        var part1Answer = SolvePart1(input);
        var part2Answer = SolvePart2(input);

        Console.WriteLine("Day 01");
        Console.WriteLine("------");
        Console.WriteLine($"Answer part 1: {part1Answer}");
        Console.WriteLine($"Answer part 2: {part2Answer}");
    }
    
    private static int SolvePart1(IEnumerable<string> input) => input.Sum(line => GetLeftNumber(line) * 10 + GetRightNumber(line));

    private static int SolvePart2(List<string> input) => input.Sum(line =>
    {
        var line2 = ReplaceNumbers(line);
        return GetLeftNumber(line2) * 10 + GetRightNumber(line2);
    });
    
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