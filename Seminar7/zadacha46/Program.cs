﻿// Задача 46: Задайте двумерный массив размером m×n,
// заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1

int rows = int.Parse(Console.ReadLine()!);
int columns = Convert.ToInt32(Console.ReadLine());
int [,] matrix = new int[rows,columns];

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i,j] = new Random().Next(11);
        // [0;11) -> [0;10]
        Console.Write(matrix[i,j] + "\t"); // Литералы
    }
    Console.WriteLine();
}
