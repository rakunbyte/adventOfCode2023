namespace adventOfCode;

public static class FileReader
{
    public static List<string> Read(string filePath)
    {
        var path = Path.Combine(Directory.GetCurrentDirectory(), filePath);
        return File.ReadAllLines(path).ToList();
    }
}