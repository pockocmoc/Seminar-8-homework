/*
Задача 58: Задайте две матрицы. Напишите программу, 
которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
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

        int[,] InitMatrix(int m, int n)
        {
            int[,] matrix = new int[m, n];
            Random rnd = new Random();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = rnd.Next(1, 10);
                }

            }
            return matrix;
        }

        void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.WriteLine();
            }
        }

        int m = GetNumber("Введите число m");
        int n = GetNumber("Введите число n");
        int[,] matrix = InitMatrix(m, n);
        Console.WriteLine("Матрица 1:");
        PrintMatrix(matrix);
        Console.WriteLine();

        int[,] secondMatrix = InitMatrix(m, n);
        Console.WriteLine("Матрица 2:");
        PrintMatrix(secondMatrix);
        Console.WriteLine();

        int[,] sumMatrix = new int[matrix.GetLength(0), matrix.GetLength(1)];
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                sumMatrix[i, j] = matrix[i, j] * secondMatrix[i, j];
                if (sumMatrix[i, j] >= 1 && sumMatrix[i, j] < 10)
                    Console.Write($" {sumMatrix[i, j]}  ");
                else
                    Console.Write($"{sumMatrix[i, j]}  ");

            }
            Console.WriteLine();
        }
    }
}