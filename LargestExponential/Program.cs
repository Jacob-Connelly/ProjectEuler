// Solution to https://projecteuler.net/problem=99

Console.WriteLine($"Line with largest exponential is {GetLargestExponential()}");

int GetLargestExponential()
{
    int currentLine = 1;
    int largestExponentialLine = 0;
    double prevLargest = 0;

    using (StreamReader sr = File.OpenText("base_exp.txt"))
    {
        string? s = string.Empty;
        while ((s = sr.ReadLine()) != null)
        {
            string[] splitLine = s.Split(',');

            int currentExpBase = int.Parse(splitLine[0]);
            int currentExp = int.Parse(splitLine[1]);

            double currentLineVal = currentExp * Math.Log10(currentExpBase);

            if (currentLineVal > prevLargest)
            {
                largestExponentialLine = currentLine;
                prevLargest = currentLineVal;
            }

            currentLine++;
        }
    }

    return largestExponentialLine;
}