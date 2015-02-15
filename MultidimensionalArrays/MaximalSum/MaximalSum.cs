//Problem 2. Maximal sum

//Write a program that reads a rectangular matrix of size N x M and finds 
//in it the square 3 x 3 that has maximal sum of its elements.
using System;

class MaximalSum
{
    static void Main()
    {
        int n = 8; //int.Parse(Console.ReadLine());
        int m = 11; //int.Parse(Console.ReadLine());
        Random rnd = new Random();
        int[,] matrix = new int[n, m];
        int maxSum = int.MinValue;
        int sum = 0;
        int startRow = 0;
        int startCol = 0;

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                matrix[row, col] = row + col;//rnd.Next(0, 80);
            }

        }
        for (int row = 0; row < matrix.GetLength(0) - 2; row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 2; col++)
            {
                sum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] +
                    matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2] +
                    matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];

                if (sum > maxSum)
                {
                    maxSum = sum;
                    startRow = row;
                    startCol = col;
                }
            }

        }
        Console.Write(matrix[startRow, startCol] + " " + matrix[startRow, startCol + 1] + " " + matrix[startRow, startCol + 2]);
        Console.WriteLine();
        Console.Write(matrix[startRow + 1, startCol] + " " + matrix[startRow + 1, startCol + 1] + " " + matrix[startRow + 1, startCol + 2]);
        Console.WriteLine();
        Console.Write(matrix[startRow + 2, startCol] + " " + matrix[startRow + 2, startCol + 1] + " " + matrix[startRow + 2, startCol + 2]);
        Console.WriteLine();
        Console.WriteLine("The max sum is: {0} " ,maxSum);
        Console.WriteLine();

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0,4} ", matrix[row, col]);
            }
            Console.WriteLine();
        }
    }
}

