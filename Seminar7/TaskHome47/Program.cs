/* Задача 47. Задайте двумерный массив размером m×n,
 заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
 */
Console.WriteLine("Задайте значения количества строк и столбцов через запятую,"
                   + "а также минимальное и максимальное значения рандомных чисел cоответственно");
var lst = Console.ReadLine()?.Split(",").Select(int.Parse).ToList();
int rows = lst[0];
int columns = lst[1];
int minRandom = lst[2];
int maxRandom = lst[3];

double[,] resultMatrix = GetMatrix(rows, columns, minRandom, maxRandom);
PrintMatrix(resultMatrix);
//MaxMinValueMatrix(resultMatrix);

double[,] GetMatrix(int line, int clmn, int minRndm, int maxRndm)
{
    double[,] matrix = new double[rows, columns];
    var rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.NextDouble() * (maxRndm - minRndm) + minRndm;
        }
    }
    return matrix;
}

void PrintMatrix(double[,] mtrx)
{
    for (int i = 0; i < mtrx.GetLength(0); i++)
    {
        for (int j = 0; j < mtrx.GetLength(1); j++)
        {
            if (j == 0) Console.Write(" | ");
            Console.Write($"{Math.Round(mtrx[i, j], 3),8} | ");
        }
        System.Console.WriteLine();
    }
}

/* void MaxMinValueMatrix(double[,] array)
{
    double maxElements = array[0,0];
    double minElements = array[0,0];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (maxElements < array[i, j])
            {
                maxElements = array[i, j];
            } 
            minElements = minElements > array[i, j] ? minElements = array[i, j] : minElements;
        }
    }
    System.Console.WriteLine($"max = {Math.Round(maxElements, 3)}");
    System.Console.WriteLine($"min = {Math.Round(minElements, 3)}");
} */