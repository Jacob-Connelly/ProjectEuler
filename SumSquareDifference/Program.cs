// Solution to https://projecteuler.net/problem=6

int max = 100;

Console.WriteLine($"The difference between the sum of the squares of the first {max} natural numbers and the square of the sum is {GetSumSquareDifference(max)}");

double GetSumSquareDifference(int max)
{
    double sumOfSquares = 0;
    double squareOfSums = 0;

    for (int i = 1; i <= max; i++)
    {
        sumOfSquares += Math.Pow(i, 2);
        squareOfSums += i;
    }

    return Math.Pow(squareOfSums, 2) - sumOfSquares;
}