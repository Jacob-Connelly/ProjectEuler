// Solution to https://projecteuler.net/problem=3
// Techincally this approach will work but could take millenums to finish depending on what number is used
// Thus I have not completed this problem.

long value = 600851475143;

long answer = GetLargestPrimeFactor(value);

Console.WriteLine($"Largest prime factor of {value} is {answer}");

//Console.WriteLine(IsPrime(35));

long GetLargestPrimeFactor(long value)
{
    for (long i = value - 1; i != 0; i--)
    {
        if (IsPrime(i) && value % i == 0)
        {
            return i;
        }
    }

    return -1;
}

bool IsPrime(long value)
{
    if (value < 0 || value% 2 == 0)
    {
        return false;
    }
    else if (value == 2)
    {
        return true;
    }

    var boundary = Math.Floor(Math.Sqrt(value));

    for (int i = 3; i <= boundary; i += 2)
    {
        if (value % i == 0)
        {
            return false;
        }
    }

    return true;
}
