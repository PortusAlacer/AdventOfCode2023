using System.Diagnostics;

namespace AdventOfCode2023.Day2;

public class Day2 : IDay
{
    private class Game
    {
        public class Set
        {
            public int Blue = 0;
            public int Red = 0;
            public int Green = 0;
            
            public bool IsValid()
            {
                return Blue <= 14 && Red <= 12 && Green <= 13;
            }
            
            public void AddGems(string gems)
            {
                string[] setSplitted = gems.Split(" ");

                switch (setSplitted[1])
                {
                    case "red":
                        Red += int.Parse(setSplitted[0]);
                        break;
                    case "blue":
                        Blue += int.Parse(setSplitted[0]);
                        break;
                    case "green":
                        Green += int.Parse(setSplitted[0]);
                        break;
                }
            }
        }
        
        public int ID = 0;
        public List<Set> Sets = new List<Set>();
        public bool IsValid = true;
        
        public Game(string gameString)
        {
            string[] gameInfoSplitted = gameString.Split(": ");

            ID = int.Parse(gameInfoSplitted[0].Substring(5));
            
            string[] sets = gameInfoSplitted[1].Split("; ");

            foreach (string set in sets)
            {
                Set newSet = AddSet(set);
                IsValid &= newSet.IsValid();
            }
        }

        public Set AddSet(string setInfo)
        {
            Set set = new Set();
            
            string[] gems = setInfo.Split(", ");

            foreach (string gem in gems)
            {
                set.AddGems(gem);
            }
            
            Sets.Add(set);
            return set;
        }
    }
    
    public string RunFirst(string[] lines)
    {
        int sum = 0;
        
        foreach (string line in lines)
        {
            Game game = new Game(line);

            if (game.IsValid)
            {
                Console.WriteLine(game.ID);
                sum += game.ID;
            }
        }

        return sum.ToString();
    }

    public string RunSecond(string[] lines)
    {
        throw new NotImplementedException();
    }
}