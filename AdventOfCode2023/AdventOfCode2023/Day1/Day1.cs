using System.Diagnostics;

namespace AdventOfCode2023.Day1;

public class Day1
{
    private string[] digits = new string[9]
    {
        "one",
        "two",
        "three",
        "four",
        "five",
        "six",
        "seven",
        "eight",
        "nine"
    };
    
    public string RunFirst(string[] inputLines)
    {
        int sum = 0;

        foreach (string line in inputLines)
        {
            int firstNumber = 0;
            int lastNumber = 0;

            int charIdxUp = 0;
            int charIdxDown = line.Length - 1;
            for (; charIdxUp < line.Length; charIdxUp++)
            {
                if (int.TryParse(line[charIdxUp].ToString(), out firstNumber))
                {
                    break;
                }
            }

            for (; charIdxDown >= 0; charIdxDown--)
            {
                if (int.TryParse(line[charIdxDown].ToString(), out lastNumber))
                {
                    break;
                }
            }

            int lineNumber;

            lineNumber = int.Parse(firstNumber.ToString() + lastNumber.ToString());
            
            Console.WriteLine(lineNumber);
            
            sum += lineNumber;
        }

        return sum.ToString();
    }
    
    public string RunSecond(string[] inputLines)
    {
        int sum = 0;

        foreach (string line in inputLines)
        {
            int firstNumber = FindFirstNumber(line);
            int lastNumber = FindLastNumber(line);

            int lineNumber;

            lineNumber = int.Parse(firstNumber.ToString() + lastNumber.ToString());
            
            Console.WriteLine(lineNumber);
            
            sum += lineNumber;
        }

        return sum.ToString();
    }
    
    private int FindFirstNumber(string line)
    {
        int firstNumber = 0;
        
        int charIdxUp = 0;
        
        for (; charIdxUp < line.Length; charIdxUp++)
        {
            if (int.TryParse(line[charIdxUp].ToString(), out firstNumber))
            {
                break;
            }

            for (int digit = 0; digit < digits.Length; digit++)
            {
                if (line.Substring(charIdxUp).StartsWith(digits[digit]))
                {
                    firstNumber = digit + 1;
                    break;
                }
            }

            if (firstNumber != 0)
            {
                break;
            }
        }

        return firstNumber;
    }
    
    private int FindLastNumber(string line)
    {
        int lastNumber = 0;
        
        int charIdxDown = line.Length - 1;
        
        for (; charIdxDown >= 0; charIdxDown--)
        {
            if (int.TryParse(line[charIdxDown].ToString(), out lastNumber))
            {
                break;
            }

            for (int digit = 0; digit < digits.Length; digit++)
            {
                string sub = line.Substring(0,  charIdxDown + 1);
                if (sub.EndsWith(digits[digit]))
                {
                    lastNumber = digit + 1;
                    break;
                }
            }
            
            if (lastNumber != 0)
            {
                break;
            }
        }

        return lastNumber;
    }
}