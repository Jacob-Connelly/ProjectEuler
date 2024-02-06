// Solution to https://projecteuler.net/problem=3

long value = 600851475143;
//long value = 13195;

long answer = GetLargestPrimeFactor(value);

Console.WriteLine($"Largest prime factor of {value} is {answer}");

long GetLargestPrimeFactor(long n)
{
    long maxPrime = -1;

    // Print the number of 2s
    // that divide n
    while (n % 2 == 0)
    {
        maxPrime = 2;
        n /= 2;
    }

    for (int i = 3; i <= Math.Sqrt(n); i += 2)
    {
        while (n % i == 0)
        {
            maxPrime = i;
            n /= i;
        }
    }

    // This condition is to handle the case
    // when n is a prime number greater than 2
    if (n > 2)
        maxPrime = n;

    return maxPrime;
}
