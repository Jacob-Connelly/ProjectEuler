using System;
using System.Collections.Generic;
namespace Shared;

/// <summary>
/// Matrix helper class
/// </summary>
public static class MatrixHelper
{
    /// <summary>
    /// Convert a text file input to an integer matrix.
    /// </summary>
    /// <param name="file">File to use.</param>
    /// <returns>Integer matrix</returns>
    public static int[][] CreateIntegerMatrix(string file)
    {
        List<int[]> matrix = [];
        string? line;
        try
        {
            StreamReader sr = new(file);
            line = sr.ReadLine();

            while (line != null)
            {
                List<int> row = [];
                string[] splitLine = line.Split(' ');
                foreach (string s in splitLine)
                {
                    row.Add(int.Parse(s));
                }

                matrix.Add(row.ToArray());
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        return matrix.ToArray();
    }
}
