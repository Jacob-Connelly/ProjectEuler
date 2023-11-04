// This is the solution for https://projecteuler.net/problem=1

int[] targets = { 3, 5 };
int max = 1000;

int answer = GetSumOfMultiples(targets, max);

Console.WriteLine($"The sum of the multiples of 3 and 5 below 1000 is {answer}.");

int GetSumOfMultiples(int[] targets, int max)
{
    int count = 1, sum = 0;

    while (count < max)
    {
        foreach (int target in targets)
        {
            if (count % target == 0)
            {
                sum += count;
                break;
            }
        }

        count++;
    }

    return sum;
}