// Solution to https://projecteuler.net/problem=11

using Shared;

int[][] grid = MatrixHelper.CreateIntegerMatrix("grid.txt");

Console.WriteLine($"The largest sum in the grid is: {GetLargestProdutInGrid(grid, 4)}");

static int GetLargestProdutInGrid(int[][] grid, int numAdjacent)
{
    List<int> results =
    [
        GetHorizontalProduct(grid, numAdjacent),
        GetVerticalProduct(grid, numAdjacent),
        GetForwardDiagonalProduct(grid, numAdjacent),
        GetReverseDiagonalProduct(grid, numAdjacent),
    ];

    return results.Max();
}

static int GetHorizontalProduct(int[][] grid, int numAdjacent)
{
    int result = 0;
    for (int i = 0; i < grid.Length; i++) 
    {
        for (int j = 0; j <= grid.Length - numAdjacent; j++) 
        {
            int product = 1;
            for (int k = 0; k < numAdjacent; k++)
            {
                product *= grid[i][j + k];
            }

            if (product > result)
            {
                result = product;
            }
        }
    }

    return result;
}

static int GetVerticalProduct(int[][] grid, int numAdjacent)
{
    int result = 0;
    for (int i = 0; i < grid.Length - numAdjacent; i++)
    {
        for (int j = 0; j < grid.Length; j++)
        {
            int product = 1;
            for (int k = 0; k < numAdjacent; k++)
            {
                product *= grid[i + k][j];
            }

            if (product > result)
            {
                result = product;
            }
        }
    }

    return result;
}

static int GetForwardDiagonalProduct(int[][] grid, int numAdjacent)
{
    int result = 0;
    for (int i = 0; i < grid.Length - numAdjacent; i++) 
    {
        for (int j = 0; j < grid.Length - numAdjacent; j++)
        {
            int product = 1;
            for (int k = 0; k < numAdjacent; k++)
            {
                product *= grid[i + k][j + k];
            }

            if (product > result)
            {
                result = product;
            }
        }
    }

    return result;
}

static int GetReverseDiagonalProduct(int[][] grid, int numAdjacent)
{
    int result = 0;
    for (int i = 0; i < grid.Length - numAdjacent; i++)
    {
        for (int j = numAdjacent - 1; j < grid.Length; j++)
        {
            int product = 1;
            for (int k = 0; k < numAdjacent; k++)
            {
                product *= grid[i + k][j - k];
            }

            if (product > result)
            {
                result = product;
            }
        }
    }

    return result;
}