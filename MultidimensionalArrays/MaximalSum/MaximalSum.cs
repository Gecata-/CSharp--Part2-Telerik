//Problem 2. Maximal sum

//Write a program that reads a rectangular matrix of size N x M and finds 
//in it the square 3 x 3 that has maximal sum of its elements.
using System;

class MaximalSum
{
    static void Main()
    {
        int n = 8; //int.Parse(Console.ReadLine());
        int m =11; //int.Parse(Console.ReadLine());
        Random rnd = new Random();
        int[,] matrix = new int[n, m];
        int maxSum = int.MinValue;
        int sum = 0;
        int startRow = 0;
        int startCow = 0;

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                matrix[row, col] = row + col;//rnd.Next(0, 80);
            }
            
        }
        for (int row = 0; row < matrix.GetLength(0) - 1; row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                sum = matrix[]
                if (true)
                {
                    
                }
            }

        }
        

        for (int row = 0; row < matrix.GetLength(0)-1; row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0,4} ", matrix[row,col]);
            }
            Console.WriteLine();
        } 
    }
}

