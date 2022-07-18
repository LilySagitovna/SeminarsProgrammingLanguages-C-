// Задача 34: Задайте массив заполненный случайными 
// положительными трёхзначными числами. Напишите программу,
//  которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
//Уточнения:размер массива задается с консоли пользователем

Console.WriteLine($"Введите число,определяющее количество рандомных чисел: ");
int number = int.Parse(Console.ReadLine()!);

int[] newArray = CreateArray(number);
Console.WriteLine($"Массив:[{String.Join(";", newArray)}]");

CountEvensNumbers(newArray);

int[] CreateArray(int size)
{
    int[] array = new int[size];
    
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}

void CountEvensNumbers(int[] array)
{
    int count = 0;
    for (int j = 0; j < array.Length; j++)
    {
        if (array[j] % 2 == 0) count += 1;
    }
    Console.WriteLine($"Количество четных чисел в массиве {count}");
}