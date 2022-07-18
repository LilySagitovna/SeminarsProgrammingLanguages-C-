// // Задача 51: Задайте двумерный массив. Найдите сумму 
// // элементов, находящихся на главной диагонали (с индексами 
// // (0,0); (1;1) и т.д. 
 
int[,] array = new int[5, 3]; 
 
void FillArray(int[,] array) 
{ 
    for (int i = 0; i < array.GetLength(0); i++) 
    { 
        for (int j = 0; j < array.GetLength(1); j++) 
        { 
            array[i, j] = new Random().Next(1, 9); 
        } 
    } 
} 
// int CheckArray(int[,] array) 
// { 
//     int sum = 0; 
//     for (int i = 0; i < array.GetLength(0); i++) 
//     { 
//         for (int j = 0; j < array.GetLength(1); j++) 
//         { 
//             if (i == j) 
//             { 
//                 sum += array[i, j]; 
//             } 
//         } 
//     } 
//     return sum; 
// } 
 
int CheckArray2(int[,] array) 
{ 
    int sum = 0; 
    int index = 0; 
    index = array.GetLength(0) > array.GetLength(1)? index = 1: index = 0;
    for (int i = 0; i < array.GetLength(index); i++) 
    { 
        sum += array[i, i]; 
    } 
    return sum; 
} 

void PrintArray(int[,] array2) 
{ 
    for (int i = 0; i < array2.GetLength(0); i++) 
    { 
        for (int j = 0; j < array2.GetLength(1); j++) 
        { 
            System.Console.Write($"{array2[i, j],3}"); 
 
        } 
        System.Console.WriteLine(); 
    } 
} 
FillArray(array); 
PrintArray(array); 
Console.WriteLine(); 
 
int sumall = CheckArray2(array); 
System.Console.WriteLine(sumall);
/////////////////////////////////////////////////////////
/* Задача 51: Найти сумму элементов главной диагонали.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Сумма элементов главной диагонали: 1+9+2 = 12 */

Console.WriteLine("задайте массив");
int m = Int32.Parse(Console.ReadLine()!);
int n = Int32.Parse(Console.ReadLine()!);
int [,] matrix = new int [m,n];
int result = 0;
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i,j] = new Random().Next(15);
        Console.Write(matrix[i,j] + "\t");
    }
    Console.WriteLine();
}

Console.WriteLine();

for (int k = 0; k < matrix.GetLength(0); k++)
{
    for (int l = 0; l < matrix.GetLength(1); l++)
    {
        if (k == l)
        {
            result += matrix[k,l]; 
        }
    }
}

System.Console.WriteLine($" Сумма элеметнов главной диагонале : {result} ");