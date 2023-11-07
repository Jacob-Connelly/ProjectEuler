// Solution to https://projecteuler.net/problem=99

Console.WriteLine($"Line with largest exponential is {GetLargestExponential()}");

int GetLargestExponential()
{
    int currentLine = 1;
    int largestExponentialLine = 0;
    int expBase = 0;
    int exp = 0;

    using (StreamReader sr = File.OpenText("base_exp.txt"))
    {
        string? s = string.Empty;
        while ((s = sr.ReadLine()) != null)
        {
            string[] splitLine = s.Split(',');

            int currentExpBase = int.Parse(splitLine[0]);
            int currentExp = int.Parse(splitLine[1]);

            if (currentLine == 1)
            {
                expBase = currentExpBase;
                exp = currentExp;
                currentLine++;
                continue;
            }

            int gcd = GreatestCommonDivisor(exp, currentExp);

            if (Math.Pow(currentExpBase, currentExp / gcd) > Math.Pow(expBase, exp / gcd))
            {
                largestExponentialLine = currentLine;
            }

            expBase = currentExpBase;
            exp = currentExp;
            currentLine++;
        }
    }

    return largestExponentialLine;
}

// Euclidean algorithm
int GreatestCommonDivisor(int a, int b)
{
    while (a != 0 && b != 0)
    {
        if (a > b)
        {
            a %= b;
        }
        else
        {
            b %= a;
        }
    }

    return a | b;
}