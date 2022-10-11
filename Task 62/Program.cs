/*
Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

internal class Program
{
    private static void Main(string[] args)
    {
        int GetNumber(string message)
        {
            Console.WriteLine(message);
            int number = int.Parse(Console.ReadLine() ?? "");
            return number;
        }


        void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] >= 1 && matrix[i, j] < 10)
                        Console.Write($"0{matrix[i, j]} ");
                    else
                        Console.Write($"{matrix[i, j]} ");

                }
                Console.WriteLine();
            }
        }


        int n = GetNumber("Введите размерность массива N x N:");
        Console.WriteLine();
        int[,] matrix = new int[n, n];

        int i = 0, j = 0;

        int value = 1;

        while (n != 0)
        {
            int k = 0;
            do { matrix[i, j++] = value++; } while (++k < n - 1);
            for (k = 0; k < n - 1; k++) matrix[i++, j] = value++;
            for (k = 0; k < n - 1; k++) matrix[i, j--] = value++;
            for (k = 0; k < n - 1; k++) matrix[i--, j] = value++;

            ++i; ++j; n = n < 2 ? 0 : n - 2;
        }

        PrintMatrix(matrix);
        Console.WriteLine();
    }
}