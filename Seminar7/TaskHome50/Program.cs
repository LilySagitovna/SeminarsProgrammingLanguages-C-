/* Задача 50. Напишите программу, которая на вход принимает
 позиции элемента в двумерном массиве, и возвращает значение
  этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
1,7 -> такого числа в массиве нет */

int[,] matrix = new int[3, 4] { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 } };

Console.Write("Введите номер строки элемента: ");
int rows = (int.Parse(Console.ReadLine()!)) - 1;
Console.Write("Введите номер столбца элемента: ");
int columns = (int.Parse(Console.ReadLine()!)) - 1;
ResultMtrx(matrix, rows, columns);

void ResultMtrx(int[,] mtrx, int line, int clmns)
{

    if (line <= mtrx.GetLength(0) && clmns <= mtrx.GetLength(1))
    {
      Console.WriteLine($"Значение элемента на позиции равна {mtrx[line, clmns]}");
    }
    else
    {
      Console.WriteLine("Такого элемента нет");
    }
}

