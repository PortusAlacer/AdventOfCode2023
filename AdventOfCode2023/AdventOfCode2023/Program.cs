// See https://aka.ms/new-console-template for more information

using AdventOfCode2023;
using AdventOfCode2023.Day1;

public static class Program
{
    enum Version
    {
        Test,
        Final
    }

    enum DayVersion
    {
        First,
        Second
    }
    
    public static void Main(string[] args)
    {
        string dayString = "Day1";
        Version version = Version.Final;
        DayVersion dayVersion = DayVersion.Second;

        string inputFileName = "../../../" + dayString + "/input";
        switch (version)
        {
            case Version.Test:
                inputFileName += "_test";
                break;
        }
        Console.WriteLine($"Input file name {inputFileName}");
        
        string[] input = LoadInput.Read(inputFileName);

        // foreach (string line in input)
        // {
        //     Console.WriteLine(line);
        // }
        
        Day1 day = new Day1();

        switch (dayVersion)
        {
            case DayVersion.First:
                Console.WriteLine(day.RunFirst(input));
                break;
            case DayVersion.Second:
                Console.WriteLine(day.RunSecond(input));
                break;
        }
       
    }
}










