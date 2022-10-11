/*
Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
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

        int[,,] InitMatrix(int p, int m, int n)
        {
            int[,,] matrix = new int[p, m, n];
            Random rnd = new Random();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    for (int k = 0; k < matrix.GetLength(2); k++)
                    {
                        matrix[i, j, k] = rnd.Next(9, 100);
                    }
                }

            }
            return matrix;

        }

        void PrintMatrix(int[,,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                Console.WriteLine("Страница №: " + (i + 1));
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    for (int k = 0; k < matrix.GetLength(2); k++)
                    {
                        Console.Write($"{matrix[i, j, k]} ({i}, {j}, {k}) ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();

            }
        }
        int p = GetNumber("Введите число p >= 1:");
        int m = GetNumber("Введите число m");
        int n = GetNumber("Введите число n");

        int[,,] matrix = InitMatrix(p, m, n);
        Console.WriteLine("Трёхмерная матрица, с индексами элементов:");
        PrintMatrix(matrix);
        Console.WriteLine();
    }
}