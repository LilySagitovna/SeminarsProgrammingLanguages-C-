/* Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 4 */

Console.Write("Сколько чисел хотите ввести:\t ");
int size = int.Parse(Console.ReadLine()!);
AmountNumbersMoreZero(CreateArray(size));

int[] CreateArray(int length)
{

    int[] array = new int[length];
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write("Введите число:\t ");
        array[i] = int.Parse(Console.ReadLine()!);
    }
    Console.WriteLine($"[{String.Join(";", array)}]");
    return array;
}

void AmountNumbersMoreZero(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        //if(array[i]>0) count++;
        count = array[i]>0 ? count+=1: count+=0;
    }
    System.Console.WriteLine($"{count} чисел больше 0.");
}