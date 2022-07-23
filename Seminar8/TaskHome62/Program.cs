/* Задача 62. Заполните спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
1 2 3 4
12 13 14 5
11 16 15 6
10 9 8 7 */

int size = 4;
//int[,] matrix = new int[rows,columns];
int[,] matrix = GetMatrixSpirally(size);
PrintMatrix(matrix);

void PrintMatrix(int[,] mtrx)
{
    for (int i = 0; i < mtrx.GetLength(0); i++)
    {
        for (int j = 0; j < mtrx.GetLength(1); j++)
        {
            Console.Write(mtrx[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

int[,] GetMatrixSpirally(int length)
{
    int[,] array = new int[length, length];
    int number = 1;
    for (int j = 0; j < length; j++)
    {
        for (int i = 0 + j; i < length - j; i++) // i < column
        {
            array[0 + j, i] = number++;
        }
        number--;
        for (int i = 0 + j; i <= length - 1 - j; i++) //i < row
        {
            array[i, length - 1 - j] = number++; //array[i, (array.GetLength(1) - 1) - j]
        }
        number--;
        for (int i = length - 1 - j; i >= 0 + j; i--)//int i = clmn - 1
        {
            array[length - 1 - j, i] = number++;//array[array.GetLength(0) - 1, i]
        }
        number--;
        for (int i = length - 1 - j; i > 0 + j; i--)//int i = row - 1
        {
            array[i, 0 + j] = number++;
        }
    }
    return array;
}


