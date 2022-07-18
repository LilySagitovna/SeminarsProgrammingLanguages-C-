// // Задача 49: Задайте двумерный массив. Найдите элементы, у 
// // которых оба индекса чётные, и замените эти элементы на их 
// // квадраты. 
 
int[,] array= new int [3, 4]; 
 
void FillArray(int[,] array) 
{ 
    for (int i = 0; i < array.GetLength(0); i++) 
    { 
        for (int j = 0; j < array.GetLength(1); j++) 
        { 
           array [i, j] = new Random().Next(1, 9);  
        } 
 
    } 
} 
void CheckArray(int[,] array) 
{ 
    for (int i = 0; i < array.GetLength(0); i+=2) 
    { 
        for (int j = 0; j < array.GetLength(1); j+=2) 
        { 
           array [i,j] = Convert.ToInt32(Math.Pow(array [i,j] , 2)); 
 
        } 
 
    } 
} 
void PrintArray(int[,] array2) 
{ 
    for (int i = 0; i < array2.GetLength(0); i++) 
    { 
        for (int j = 0; j < array2.GetLength(1); j++) 
        { 
           System.Console.Write($"{array2[i,j],  3}"); 
 
        } 
        System.Console.WriteLine(); 
    } 
} 
        FillArray (array); 
        PrintArray(array); 
        Console.WriteLine(); 
        CheckArray (array); 
         PrintArray(array); 

//Задача 49: Задайте двумерный массив. Найдите элементы, у 
//которых оба индекса чётные, и замените эти элементы на их квадраты.

Console.WriteLine("задайте массив");
int m = Int32.Parse(Console.ReadLine()!);
int n = Int32.Parse(Console.ReadLine()!);
int [,] matrix = { { 2 , 3 , 5 , 5 },
                    { 3 , 4,  6 , 7 },
                    { 4 , 3 , 5 , 6 } };


for (int i = 0; i < matrix.GetLength(0); i+=2)
{
    for (int j = 0; j < matrix.GetLength(1); j+=2)
    {
        matrix [i,j] = Convert.ToInt32(Math.Pow(matrix [i,j] , 2));
        Console.Write( matrix [i,j] + "\t");
    }
    Console.WriteLine();
}
