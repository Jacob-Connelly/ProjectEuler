// Solution to https://projecteuler.net/problem=5

int max = 20;
Console.WriteLine($"Smallest multiple of 1 to {20} is {GetSmallestMultipleBruteForce(max)}");

int GetSmallestMultipleBruteForce(int max){

    int count = max;
    while (true)
    {
        for (int i = 2; i <= max; i++)
        {
            if (count % i != 0)
            {
                break;
            }

            if (i == max)
            {
                return count;
            }
        }

        count++;
    }
}