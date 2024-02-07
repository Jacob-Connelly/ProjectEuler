// Solution to https://projecteuler.net/problem=9

int sum = 1000;

Console.WriteLine($"Result: {PythagoreanTriplet(sum)}");

int PythagoreanTriplet(int sum)
{
    for (int c = 0; c <= sum; c++)
    {
        for (int b = 0; b < c; b++)
        {
            for (int a = 0; a < b; a++)
            {
                if (a + b + c == sum)
                {
                    if (Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2)) == c)
                    {
                        Console.WriteLine($"a = {a}, b = {b}, c = {c}");
                        return a * b * c;
                    }
                }
            }
        }
    }

    return -1;
}