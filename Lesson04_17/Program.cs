using System;

namespace Lesson04_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int MATRIX_ROWS = 3;
            const int MATRIX_COLUMNS = 3;
            double allSum = 0;
            double firstRowSum = 0;
            double secondRowSum = 0;
            double thirdRowSum = 0;
            double firstColumSum = 0;
            double secondColumSum = 0;
            double thirdColumSum = 0;
            double[,] matrix = new double[MATRIX_ROWS, MATRIX_COLUMNS];

            for (int i = 0; i < MATRIX_ROWS; i++)
            {
                for (int j = 0; j < MATRIX_COLUMNS; j++)
                {
                    Console.Write("Enter value for ({0},{1}): ", i, j);
                    matrix[i, j] = double.Parse(Console.ReadLine());
                    allSum += matrix[i, j];
                    if (j >= 0 && j <= 2 && i == 0)
                    {
                        firstRowSum += matrix[i, j];
                    }
                    else if (j >= 0 && j <= 2 && i == 1)
                    {
                        secondRowSum += matrix[i, j];
                    }
                    else if (j >= 0 && j <= 2 && i == 2)
                    {
                        thirdRowSum += matrix[i, j];
                    }
                    if (i >= 0 && i <= 2 && j == 0)
                    {
                        firstColumSum += matrix[i, j];
                    }
                    else if (i >= 0 && i <= 2 && j == 1)
                    {
                        secondColumSum += matrix[i, j];
                    }
                    else if (i >= 0 && i <= 2 && j == 2)
                    {
                        thirdColumSum += matrix[i, j];
                    }



                }
            }
            Console.WriteLine();
            for (int i = 0; i < MATRIX_ROWS; i++)
            {
                for (int j = 0; j < MATRIX_COLUMNS; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine($"matricos suma = {allSum}");
            Console.WriteLine($"Pirmmos eilutes suma = {firstRowSum}");
            Console.WriteLine($"antros eilutes suma = {secondRowSum}");
            Console.WriteLine($"trecios eilutes suma = {thirdRowSum}");
            Console.WriteLine($"pirmo stulpelio suma = {firstColumSum}");
            Console.WriteLine($"pirmo stulpelio suma = {secondColumSum}");
            Console.WriteLine($"pirmo stulpelio suma = {thirdColumSum}");

            Console.ReadKey();
        }
    }
}
