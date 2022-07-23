/* Задача 58: Задайте две матрицы. Напишите программу,
 которая будет находить произведение двух матриц.
Например, заданы 2 массива:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
и
1 5 8 5
4 9 4 2
7 2 2 6
2 3 4 7
Их произведение будет равно следующему массиву:
1 20 56 10
20 81 8 6
56 8 4 24
10 6 24 49 */

Console.WriteLine("Количество строк первого массива: ");
int rows1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Количество столбцов первого массива: ");
int columns1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Количество строк второго массива: ");
int rows2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Количество столбцов второго массива: ");
int columns2 = int.Parse(Console.ReadLine()!);

int[,] matrixFerst = GetMatrix(rows1, columns1, 1, 10);
Console.WriteLine("Первый массив:");
PrintMatrix(matrixFerst);
System.Console.WriteLine();
Console.WriteLine("Второй массив:");
int[,] matrixSecond = GetMatrix(rows2, columns2, 1, 10);
PrintMatrix(matrixSecond);
System.Console.WriteLine();

if (columns1 == rows2)
{
    Console.WriteLine("Произведение первого и второго массива равна следующему массиву:");
    PrintMatrix(SearchProductTwoMatric(matrixFerst, matrixSecond));
}
else
{
    Console.WriteLine("Вычислить произведение двух матриц можно только"
            + " если количество столбцов первой матрицы равно количеству строк второй матрицы."
            + " Матрицы, для которых данное условие не выполняется, умножать нельзя.");
}


int[,] GetMatrix(int row, int colmn, int min, int max)
{
    int[,] mtrx = new int[row, colmn];
    var rnd = new Random();
    for (int i = 0; i < mtrx.GetLength(0); i++)
    {
        for (int j = 0; j < mtrx.GetLength(1); j++)
        {
            mtrx[i, j] = rnd.Next(min, max);
        }
    }
    return mtrx;
}

void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write(matr[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

int[,] SearchProductTwoMatric(int[,] mtrx1, int[,] mtrx2)
{
    //int row = mtrx1.GetLength(0);
    //int column = mtrx2.GetLength(1);
    int[,] resultMatrix = new int[mtrx1.GetLength(0), mtrx2.GetLength(1)];

        for (int i = 0; i < mtrx1.GetLength(0); i++) // счетчик строк первой матрицы
        {
            for (int j = 0; j < mtrx2.GetLength(1); j++) // счетчик столбцов второй матрицы
            {
                for (int k = 0; k < mtrx2.GetLength(0); k++) // счетчик строк второй матрицы добавляет и сохраняет в результ матрицу
                {
                    resultMatrix[i, j] += mtrx1[i, k] * mtrx2[k, j];
                }
            }
        }
        return resultMatrix;
}