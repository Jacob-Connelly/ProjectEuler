// Solution to https://projecteuler.net/problem=4

Console.WriteLine($"The largest palidrone product of 3-digit numbers is {GetLargestPalindromeProduct()}");

int GetLargestPalindromeProduct()
{
    int largest = 0;

    for (int i = 100; i < 1000; i++)
    {
        for (int j = 100; j < 1000; j++)
        {
            int val = i * j;
            if (IsPalindrome($"{val}") && val > largest)
            {
                largest = val;
            }
        }
    }

    return largest;
}

bool IsPalindrome(string str)
{
    int start = 0;
    int end = str.Length - 1;
    for (int i = 0; i < str.Length/2; i++)
    {
        if (str[start] != str[end])
        {
            return false;
        }

        start++;
        end--;
    }

    return true;
}