/* Задача 55: Задайте двумерный массив. 
Напишите программу, которая заменяет строки 
на столбцы. В случае, если это невозможно, программа 
должна вывести сообщение для пользователя. */
//транспонирование матриц

int[,] GetMatrix(int rows, int columns, int min, int max)
{
int[,] matrix = new int[rows, columns];
var rnd = new Random();
for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = 0; j < matrix.GetLength(1); j++)
{
matrix[i, j] = rnd.Next(min, max);
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
Console.Write(matrix[i, j] + "\t");
}
Console.WriteLine();
}
}

int[,] MatrixRowColmns(int[,] matr)
{
    int[,] matrnew = new int [matr.GetLength(1),matr.GetLength(0)];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matrnew[i,j] = matr[j,i];
        }
    }
    return matrnew;
}

int[,] array = GetMatrix(4, 4, 0, 10);
PrintMatrix(array);
Console.WriteLine();
PrintMatrix(MatrixRowColmns(array));