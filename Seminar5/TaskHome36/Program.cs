/* Задача 36: Задайте одномерный массив, 
заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */

//Уточнения: диапазон чисел от 0 до 100 включительно;
//           длина массива заданна в программе

int[] newArray = new int[5]; //-здесь
CreateArray(newArray);
Console.WriteLine($"Массив:[{String.Join(",", newArray)}]");

SumNumbersOddPosition(newArray);

int[] CreateArray(int[] size)
{
    //int[] array = new int[size];
    for (int i = 0; i < size.Length; i++)
    {
        size[i] = new Random().Next(101);
    }
    return size;
}

void SumNumbersOddPosition(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0) sum += array[i] ;
    }
    Console.WriteLine($"Сумма чисел, стоящих на нечетных позициях равна {sum}");
}