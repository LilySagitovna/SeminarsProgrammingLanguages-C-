/* Задача 54: Задайте двумерный массив. 
Напишите программу, которая упорядочит по убыванию 
элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
1 2 4 7
2 3 5 9
2 4 4 8 */

Console.WriteLine("Введите количество строк, столбцов,а также минимальное и максимальное "
           + " значение рандомных чисел для генерации массива через запятую");
var answer = Console.ReadLine()?.Split(",").Select(int.Parse).ToList();
int rows = answer[0];
int columns = answer[1];
int minRandom = answer[2];
int maxRandom = answer[3];
int[,] matrix = GetMatrix(rows, columns, minRandom, maxRandom);
Console.WriteLine("Массив:");
PrintMatrix(matrix);

SortDescending(matrix);


int[,] GetMatrix(int row, int colmn, int min, int max)
{
    int[,] mtrx = new int[row, colmn];
    var rnd = new Random();
    for (int i = 0; i < mtrx.GetLength(0); i++)
    {
        for (int j = 0; j < mtrx.GetLength(1); j++)
        {
            mtrx[i, j] = rnd.Next(min, max + 1);
        }
    }
    return mtrx;
}

void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

void BubbleSort(int[] inArray)// сортировка пузырьком одномерного массива
{
    for (int i = 0; i < inArray.Length; i++)
    {
        for (int j = 0; j < inArray.Length - i - 1; j++)
        {
            if (inArray[j] > inArray[j + 1])
            {
                int temp = inArray[j];
                inArray[j] = inArray[j + 1];
                inArray[j + 1] = temp;
            }
        }
    }

}

void SortDescending(int[,] arr)
{
    Console.WriteLine("Сортировка по строкам: ");
    int[] row = new int[arr.GetLength(1)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            row[j] = arr[i, j];
        BubbleSort(row);
        //Insert(true, i, row, arr);
        for (int k = 0; k < row.Length; k++)
        {
                arr[i, k] = row[k];
        }
    }
    PrintMatrix(arr);
    
    // Console.WriteLine("Сортировка по столбцам: ");
    // int[] col = new int[arr.GetLength(0)];
    // for (int i = 0; i < arr.GetLength(1); i++)
    // {
    //     for (int j = 0; j < arr.GetLength(0); j++)
    //         col[j] = arr[j, i];
    //     BubbleSort(col);
    //     Insert(false, i, col, arr);
    // }
    // PrintMatrix(arr);
}

/* void Insert(bool isRow, int dim, int[] source, int[,] dest)
 {
     for (int k = 0; k < source.Length; k++)
     {
         if (isRow)
             dest[dim, k] = source[k];
         else
             dest[k, dim] = source[k];
     }
 } */
