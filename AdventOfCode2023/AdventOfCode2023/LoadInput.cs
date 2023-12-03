namespace AdventOfCode2023;

public static class LoadInput
{
    public static string[] Read(string filePath)
    {
        try
        {
            return File.ReadAllLines(filePath);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.ToString());
        }

        return null;
    }
}