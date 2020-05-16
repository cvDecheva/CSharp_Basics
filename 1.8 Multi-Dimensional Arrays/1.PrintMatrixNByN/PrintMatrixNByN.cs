using System;

class PrintMatrixNByN
{
    static void Main()
    {
        bool isSizeOfMatrixCorrect = false;
        do
        {
            try
            {
                Console.Write("Enter the size of matrix:");
                int sizeOfMatrix = int.Parse(Console.ReadLine());
                isSizeOfMatrixCorrect = true;

                //first matrix
                FirstMatrix(sizeOfMatrix);

                //second matrix
                SecondMatrix(sizeOfMatrix);

                //third matrix
                ThirdMatrix(sizeOfMatrix);
            }
            catch (Exception e)
            {
                Console.WriteLine("Incorretc size!");
            }
        } while (!isSizeOfMatrixCorrect);
        Console.Read();
    }

    public static void PrintMatrix(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i,j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }

    public static void FirstMatrix(int sizeOfMatrix)
    {
        int[,] matrix = new int[sizeOfMatrix, sizeOfMatrix];
        int element = 1;
        for (int i = 0; i < sizeOfMatrix; i++)
        {
            for (int j = 0; j < sizeOfMatrix; j++)
            {
                matrix[j, i] = element;
                element++;
            }
        }
        PrintMatrix(matrix);
    }

    public static void SecondMatrix(int sizeOfMatrix)
    {
        int[,] matrix = new int[sizeOfMatrix, sizeOfMatrix];
        int element = 1;
        int k = 0;
        int step = 0;
        for (int i = 0; i < sizeOfMatrix; i++)
        {
            if (i % 2 == 0)
            {
                step = 1;
            }
            else
            {
                step = -1;
            }
            for (int j = 0; j < sizeOfMatrix; j++)
            {
                matrix[k, i] = element;
                element++;
                k += step;
            }
            k += step * -1;
        }
        PrintMatrix(matrix);
    }

    public static void ThirdMatrix(int sizeOfMatrix)
    {
        int[,] matrix = new int[sizeOfMatrix, sizeOfMatrix];
        int element = 1;
        int k = matrix.GetLength(0) - 1;
        int j = 0, i = 0;
        i = k;
        matrix[i, j] = element;
        element++;
        do
        {
            k--;
            j = 0;
            i = k;
            do
            {

                matrix[i, j] = element;
                element++;
                i++;
                j++;
            } while (i != matrix.GetLength(0));
        } while (k != 0);
        do
        {
            k++;
            i = 0;
            j = k;
            do
            {

                matrix[i, j] = element;
                element++;
                i++;
                j++;
            } while (j != matrix.GetLength(0));
        } while (k != matrix.GetLength(0) - 1);
        PrintMatrix(matrix);
    }
}

