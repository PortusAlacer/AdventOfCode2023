namespace AdventOfCode2023.Day1;

public class Day1
{
    public string Run(string[] inputLines)
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
}