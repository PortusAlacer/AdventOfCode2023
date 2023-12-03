// See https://aka.ms/new-console-template for more information

using AdventOfCode2023;
using AdventOfCode2023.Day1;
using AdventOfCode2023.Day2;

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
        string dayString = "Day2";
        Version version = Version.Final;
        DayVersion dayVersion = DayVersion.First;

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
        
        IDay day = new Day2();

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










