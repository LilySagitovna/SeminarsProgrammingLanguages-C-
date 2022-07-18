//Задача 48: Задайте двумерный массив размера m на n,
// каждый элемент в массиве находится по формуле: 
//Aₘₙ = m+n. Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

int m = Int32.Parse(Console.ReadLine()!);
int n = Int32.Parse(Console.ReadLine()!);
int [,] matrix = new int [m,n];
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        int Amn = i + j;
        Console.Write(Amn + "\t");
    }
    Console.WriteLine();
}
