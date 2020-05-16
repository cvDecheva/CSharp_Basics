using System;

class DifficultMatrix
{
    static void Main()
    {
        bool isValid = false;
        do
        {     
            int row = 0, col = 0;
           
            try
            {
                int br = 0;
                Console.WriteLine("Enter the size of the matrix:");
                int number = int.Parse(Console.ReadLine());
                isValid = true;
                int[,] matrix = new int[number, number];
                int minCol = 0, minRow = 0;
                int maxCol = number - 1, maxRow = number - 1;

                while (col < number)
                {
                    br++;
                    matrix[row, col] = br;
                    col++;
                }
                minRow++;
                col--;
                for (int i = 0; i < number * 2 - 2; i++)
                {
                    if (row < col)
                    {
                        while (row != col)
                        {
                            br++;
                            row++;
                            matrix[row, col] = br;                           
                        }
                        maxCol--;
                    }
                    else if (row == col)
                    {
                        while (col != minCol)
                        {
                            br++;
                            col--;
                            matrix[row, col] = br;                        
                        }
                        maxRow--;
                    }
                    else if (row > col && col == minCol)
                    {
                        while (row != (minCol+1))
                        {
                            br++;
                            row--;
                            matrix[row, col] = br;                      
                        }
                        minCol++;
                    }
                    else if (row > col && col < minCol)
                    {
                        while (col != maxCol)
                        {
                            br++;
                            col++;
                            matrix[row, col] = br;                         
                        }
                        minRow++;
                    }
                }

                for (int i = 0; i < number; i++)
                {
                    for (int j = 0; j < number; j++)
                    {
                        Console.Write("{0,4}", matrix[i,j]);
                    }
                    Console.WriteLine();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Incorrect values!");
            }
        } while (!isValid);
        Console.Read();
    }
}

