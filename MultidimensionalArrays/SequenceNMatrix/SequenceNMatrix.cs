//Problem 3. Sequence n matrix

//We are given a matrix of strings of size N x M. Sequences in the matrix we define as sets of several neighbour 
//elements located on the same line, column or diagonal.
//Write a program that finds the longest sequence of equal strings in the matrix.
//Example:

// matrix	                result		    matrix	         result
// ha	fifi	ho	hi      ha, ha, ha      s	qq	s        s, s, s
// fo	ha	    hi	xx                      pp	pp	s
// xxx	ho	    ha	xx                      pp	qq	s
//		

using System;

class SequenceNMatrix
{
    static void Main()
    {

        string equal = null;
        int maxCount = int.MinValue;
        int count = 1;
        int secondCount = 1;
        int thirdCount = 1;
        string maxElement = null;

        string[,] matrix = 
        {       {"s",	"qq",	"s"},
                {"pp",	"pp",	"s"},
                {"pp",	"qq",	"s"}
         };

        // just uncomment to test!

        ////string[,] matrix = 
        //{       {"ha",	"fifi",	"ho",	"hi"},
        //        {"fo",	"ha",   "hi",	"xx"},
        //        {"xxx",	"ho",	"ha",	"xx" }
        //};
        int n = matrix.GetLength(0);
        int m = matrix.GetLength(1);

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.WriteLine(matrix[row, col]);

                if ((col + 1) < matrix.GetLength(1) && matrix[row, col] == matrix[row, col + 1] && count > maxCount)
                {
                    if (matrix[row, col] != equal)
                    {
                        count = 1;
                    }
                    else
                    {
                        maxCount = count;
                    }
                    equal = matrix[row, col];
                    count++;
                }
                if ((row + 1) < matrix.GetLength(0) && matrix[row, col] == matrix[row + 1, col] && secondCount > maxCount)
                {
                    if (matrix[row, col] != equal)
                    {
                        secondCount = 1;
                    }
                    else
                    {
                        maxCount = secondCount;
                    }
                    equal = matrix[row, col];
                    secondCount++;
                }
                if ((col + 1) < matrix.GetLength(1) && (row + 1) < matrix.GetLength(0)
                    && matrix[row, col] == matrix[row + 1, col + 1] && thirdCount > maxCount)
                {
                    if (matrix[row, col] != equal)
                    {
                        thirdCount = 1;
                    }
                    else
                    {
                        maxCount = thirdCount;
                    }
                    equal = matrix[row, col];
                    thirdCount++;
                }
            }
        }
        for (int i = 0; i <= maxCount; i++)
        {
            Console.Write(i < maxCount ? "{0}, " : "{0}", equal);
        };
        Console.WriteLine();
    }
}
