// Задача 29: Напишите программу, которая задаёт
//  массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

/* int[] array = new int [8]{1,2,5,7,19,6,1,33};
System.Console.WriteLine($"[{String.Join(",",array)}]"); */
///////////////////////////


/* int[] array = {1,2,5,7,19,6,1,33};
System.Console.WriteLine($"[{String.Join(",",array)}]"); */
/////////////////////


int[] array = new int [8];
for (int i = 0; i < array.Length; i++)
{
    array[i]=new Random().Next(-100,101);
}
System.Console.WriteLine($"[{String.Join(",",array)}]");
















