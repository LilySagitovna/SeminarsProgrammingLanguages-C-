/* Задача 52. Задайте двумерный массив из целых чисел.
 Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */
int[,] matrix = { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 } };
PrintMatrix(matrix);
Console.WriteLine();
AverageArithmetical(matrix);


void PrintMatrix(int[,] mtrx)
{
    for (int i = 0; i < mtrx.GetLength(0); i++)
    {
        for (int j = 0; j < mtrx.GetLength(1); j++)
        {
            Console.Write(mtrx[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

void AverageArithmetical(int[,] array)
{
    double mathAverage = 0;
    double sum = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        sum = 0;
        for (int j = 0; j < array.GetLength(0); j++)
        {
            sum += array[j, i];
        }
        Console.WriteLine($"Сумма цифр в столбце = {Math.Round(sum)}");
        mathAverage = sum / array.GetLength(0);
        Console.WriteLine($"Среднее арифметическое элементов в каждом столбце: {Math.Round(mathAverage, 2)}");
    }
}