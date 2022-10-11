﻿/*
Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке 
и выдаёт номер строки с наименьшей суммой элементов: 1 строка
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
        Console.WriteLine("Матрица:");
        PrintMatrix(matrix);
        Console.WriteLine();


        double k = double.MaxValue;
        int row = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            double sum = 0;
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                sum += matrix[i, j];
            }
            if (sum < k)
            {
                row = i;
                k = sum;
            }
        }
        Console.WriteLine("Номер строки с наименьшей суммой: {0}", row);
        Console.WriteLine("Cумма {0}", k);
    }
}