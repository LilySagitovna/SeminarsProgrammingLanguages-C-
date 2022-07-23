// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.

Console.Write("Введите количество строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int columns = Convert.ToInt32(Console.ReadLine());
/// summary
/// строчки - m, столбцы - n; min , max
int[,] GetArray(int m, int n, int min, int max)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++) // Строчки
    {
        for (int j = 0; j < n; j++) // Столбцы
        {
            result[i, j] = new Random().Next(min, max + 1); // [min,max]
        }
    }
    return result;
}

void PrintArray(int[,] inputArray)
{
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            Console.Write(inputArray[i, j] + "\t"); // tab - "\t"
        }
        Console.WriteLine();
    }
}

void ChangesRows(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            //matrix[i,j] = matrix[j,i];
            System.Console.Write(matrix[j, i] + "\t");
            if (i != j) System.Console.WriteLine("Невозможно заменить строки на столбцы.");
        }
        System.Console.WriteLine();
    }
}

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
ChangesRows(array);
System.Console.WriteLine();
System.Console.WriteLine();
// PrintArray(array);
