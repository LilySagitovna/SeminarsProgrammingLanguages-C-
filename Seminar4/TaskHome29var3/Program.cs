// Задача 29: Напишите программу, которая задаёт
//  массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


int[] Array = PrintArray(8);
System.Console.WriteLine($"{String.Join(",",Array)}");
int[] PrintArray(int length)
{
    int[] Print = new int [length];
    for (int i = 0; i < length; i++)
    {
        Print[i]=new Random().Next(65,351);
    }
    return Print;
}