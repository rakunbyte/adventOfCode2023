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

    private static int SolvePart2(List<string> input)
    {
        var sumPart2 = 0;
        foreach (var line in input)
        {
            var line2 = ReplaceNumbers(line);

            sumPart2 += GetLeftNumber(line2) * 10;
            sumPart2 += GetRightNumber(line2);
        }

        return sumPart2;
    }

    private static int SolvePart1(List<string> input)
    {
        var sumPart1 = 0;
        foreach (var line in input)
        {
            sumPart1 += GetLeftNumber(line) * 10;
            sumPart1 += GetRightNumber(line);
        }

        return sumPart1;
    }

    private static int GetLeftNumber(string line)
    {
        for(var i = 0; i < line.Length; i++)
        {
            var character = line[i];
            if (char.IsNumber(character))
            {
                return character - '0';
            }
        }

        throw new Exception("No number found");
    }
    
    private static int GetRightNumber(string line)
    {
        for(var i = line.Length - 1; i > -1; i--)
        {
            var character = line[i];
            if (char.IsNumber(character))
            {
                return character - '0';
            }
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