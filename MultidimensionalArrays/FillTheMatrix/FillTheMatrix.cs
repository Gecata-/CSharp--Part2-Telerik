//Problem 1. Fill the matrix

//Write a program that fills and prints a matrix of size (n, n) as shown below:
//Example for n=4:
/*  a)					b)					c)					d)*
    1	5	9	13		1	8	9	16		7	11	14	16		1	12	11	10
    2	6	10	14		2	7	10	15		4	8	12	15		2	13	16	9
    3	7	11	15		3	6	11	14		2	5	9	13		3	14	15	8
    4	8	12	16		4	5	12	13		1	3	6	10		4	5	6	7
*/
using System;

class FillTheMatrix
{
    static void Main()
    {
        int n = 4; // int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, n];
        int count = 0;
        int maxCount = 0;

        // Just uncomment to test part: a)

        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                matrix[row, col] = ++count;
            }
        }
        

        // Just uncomment to test part: b)
        //for (int col = 0; col < matrix.GetLength(1); col++)
        //{
        //    if (col %2 == 0)
        //    {
        //        for (int row = 0; row < matrix.GetLength(0); row++)
        //        {
        //            {
        //                matrix[row, col] = ++count;
        //                maxCount = count;
        //            }
        //        }
        //        count = maxCount;
        //    }                
        //    else
        //    {
        //        for (int row =  matrix.GetLength(0)-1; row >= 0 ; row--)
        //        {                    
        //            matrix[row, col] = ++count;                    
        //        }
        //    }            
        //}

        // Just uncomment to test part: c)
        //int number = 1;
        //int row = 0;
        //int col = 0;
        //for (int i = n-1; i >=0 ; i--)
        //{
        //    row = i;
        //    col = 0;
        //    while (row <n && col < n )
        //    {
        //        matrix[row++, col++] = number++;
        //    }
        //}
        //for (int i = 1; i <=n ; i++)
        //{
        //    col = i;
        //    row = 0;
        //    while (col < n)
        //    {
        //        matrix[row++, col++] = number++;
        //    }
        //}      
        //for ( row = 0; row < matrix.GetLength(0); row++)
        //{
        //    for (col = 0; col < matrix.GetLength(1); col++)
        //    {
        //        Console.Write("{0,3} ", matrix[row, col]);
        //    }
        //    Console.WriteLine();
        //    Console.WriteLine();
        //}

        //Still thinking...
        //for (int col = 0; col < matrix.GetLength(1); col++)
        //{
        //    for (int row = 0; row < matrix.GetLength(0); row++)
        //    {
        //        matrix[row, col] = ++count;
        //        while (row == n-1 && col < n-1)
        //        {
        //            matrix[row, col++] = count++;
        //        }

        //        while (row > 0 && col == n - 1)
        //        {
        //            matrix[row--, col] = count++;
        //        }
               
        //    }
        //}

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0,3} ", matrix[row, col]);
            }
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}