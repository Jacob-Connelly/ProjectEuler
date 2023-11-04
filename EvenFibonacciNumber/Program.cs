// This is the answer to https://projecteuler.net/problem=2

int max = 4000000;

int answer = GetSumOfEvenFibonacciNumbers(max);

Console.WriteLine($"The sum of even fibonacci numbers below 4,000,000 is {answer}");

int GetSumOfEvenFibonacciNumbers(int max)
{
    int sum = 0;
    int current = 2;
    int previous = 1;

    while (current < max)
    {
        if (current % 2 == 0)
        {
            sum += current;
        }

        int tempCurrent = current;
        current += previous;
        previous = tempCurrent;
    }

    return sum;
}