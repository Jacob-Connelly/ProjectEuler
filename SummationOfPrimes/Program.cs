// Solution to https://projecteuler.net/problem=10

//int max = 10;
int max = 2000000;
Console.WriteLine($"The sum of primes below {max} is {GetSummation(max)}");

long GetSummation(int n)
{
    long sum = 0;

   for (int i = 1; i <= n; i++)
   {
        if (IsPrime(i))
        {
            sum += i;
        }
   }

   return sum;
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