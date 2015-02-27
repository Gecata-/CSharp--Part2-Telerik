// Problem 5. Maximal area sum

// Write a program that reads a text file containing a square matrix of numbers.
// Find an area of size 2 x 2 in the matrix, with a maximal sum of its elements.
// The first line in the input file contains the size of matrix N.
// Each of the next N lines contain N numbers separated by space.
// The output should be a single number in a separate text file.
// Example:

// input	        output
// 4 
// 2 3 3 4 
// 0 2 3 4 
// 3 7 1 2 
// 4 3 3 2	        17
using System;
using System.IO;

class MaximalAreaSum
{
    static void Main()
    {
        var streamReader = new StreamReader(@"..\..\Matrix.txt");
        string line = streamReader.ReadLine();
        int n = int.Parse(line);
        
        int[,] matrix = new int[n, n];
        int maxSum = int.MinValue;
        int sum = 0;
        line = streamReader.ReadLine();
        while (line != null)
        {            
                for (int i = 0; i < n; i++)
                { 
                   string[] lineTextNumbers = line.Split(' ');
                
                    for (int j = 0; j < n; j++)
                    {
                        matrix[i, j] = int.Parse(lineTextNumbers[j]);
                    }

                    line = streamReader.ReadLine();
                }                      
        }
        streamReader.Close();

        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - 1; j++)
            {
                sum = matrix[i, j] + matrix[i, j + 1] + matrix[i + 1, j] + matrix[i + 1, j + 1];
                if (sum > maxSum)
                {
                    maxSum = sum;
                }
            }
        }
        var streamWriter = new StreamWriter(@"..\..\MatrixMaxSum.txt");
        streamWriter.WriteLine(maxSum);
        streamWriter.Close();
    }
}

