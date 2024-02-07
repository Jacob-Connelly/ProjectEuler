// Solution to https://projecteuler.net/problem=7

//int place = 6;
int place = 10001;

Console.WriteLine($"The {place} prime is {GetPrime(place)}");

int GetPrime(int n)
{
    int count = 1;
    while (n != 0)
    {
        if (IsPrime(count))
        {
            n--;
        }
        count++;
    }

    return count - 1;
}

bool IsPrime(int n)
{
    if (n <= 1)
        return false;

    // Check if n=2 or n=3 
    if (n == 2 || n == 3)
        return true;

    // Check whether n is divisible by 2 or 3 
    if (n % 2 == 0 || n % 3 == 0)
        return false;

    // Check from 5 to square root of n 
    // Iterate i by (i+6) 
    for (int i = 5; i <= Math.Sqrt(n); i = i + 6)
        if (n % i == 0 || n % (i + 2) == 0)
            return false;

    return true;
}