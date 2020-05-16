using System;

class RectangularMatrix
{
    static void Main()
    {
        bool isSizeOfMatrixCorrect = false;
        int maxSum = int.MinValue;
        int temp = 0;
        do
        {
            try
            {
                Console.Write("Enter the number or rows of matrix(N):");
                int rows = int.Parse(Console.ReadLine());
                Console.Write("Enter the number or cols of matrix(M):");
                int cols = int.Parse(Console.ReadLine());
                if (rows >= 3 && cols >= 3)
                {
                    isSizeOfMatrixCorrect = true;
                    int[,] matrix = new int[rows, cols];

                    for (int i = 0; i < rows; i++)
                    {
                        for (int j = 0; j < cols; j++)
                        {
                            Console.Write("matrix[{0}][{1}] = ", i, j);
                            matrix[i,j] = int.Parse(Console.ReadLine());
                        }
                    }

                    for (int i = 0; i < rows-2; i++)
                    {
                        for (int j = 0; j < cols-2; j++)
                        {
                            temp = 0;
                            for (int k = 0; k < 3; k++)
                            {
                                for (int p = 0; p < 3; p++)
                                {
                                    temp += matrix[i + k, j + p];
                                }                           
                            }
                            if (maxSum < temp)
                            {
                                maxSum = temp;
                            }
                        }
                    }
                    Console.WriteLine("The maximus sum of part of matrix(3x3) is {0}", maxSum);
                }
                if (!isSizeOfMatrixCorrect)
                {
                    Console.WriteLine("M and N must be greater or equal than 3!");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Incorretc size!");
            }

        } while (!isSizeOfMatrixCorrect);
        Console.Read();
    }
}
