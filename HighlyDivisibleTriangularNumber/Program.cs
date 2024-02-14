// Solution to https://projecteuler.net/problem=12

int maxDivisor = 500;
Console.WriteLine($"The first triangle number with more divisors than {maxDivisor} is {GetHighlyDivisbleTriangularNumber(maxDivisor)}");

int GetHighlyDivisbleTriangularNumber(int maxDivisor)
{
    int i = 1;
    while (true)
    {
        int triangleNumber = GetTriangleNumber(i);
        long divisorCount = GetDivisorCountExpress(triangleNumber);
        Console.WriteLine(divisorCount);
        if (divisorCount > maxDivisor)
            return triangleNumber;

        i++;
    }
}

int GetTriangleNumber(int n)
{
    int sum = 0;
    for (int i = 1; i <= n; i++)
    {
        sum += i;
    }

    return sum;
}

long GetDivisorCountExpress(int n)
{
    long divisorCount = 2;

    for (int i = 2; i <= Math.Sqrt(n); i++)
    {
        if  (n % i == 0)
        {
            divisorCount++;

            if (i * i != n)
            {
                divisorCount++;
            }
        }
    }

    return divisorCount;
}