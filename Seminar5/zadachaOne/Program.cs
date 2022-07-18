// Задача 31: Задайте массив из 12 элементов, заполненный случайными 
// числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел
//  равна 29, сумма отрицательных равна -20


int[] array = new int[12];

int size = array.Length;

int resultPositive = 0;

int resultNegative = 0;

// {1,2,3} -> size = 3, maxIndex  = 2

for (int i = 0; i < size; i++)
{
    array[i] = new Random().Next(-9, 10);// [-9;10)

    if (array[i] > 0)
    {
        resultPositive += array[i];
        // resultPositive++ -> resultPositive = resultPositive +1
        // Инкремент - увеличение на 1
        // resultPositive-- - декремент - уменьшение переменной resultPositive на 1
    }
    else
    {
        resultNegative += array[i]; 
    }
}
Console.WriteLine($"sum positive: {resultPositive}, sum negative: {resultNegative}");
Console.WriteLine($"Исходный массив: [{String.Join(", ", array)}]");
////////////////////////////////
////  Найдите произведение пар чисел в одномерном массиве. 
//Парой считаем первый и последний элемент, 
//второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21


int[] inputArray = { 1, 2, 3, 4, 5 };

int lastIndex = inputArray.Length - 1; // 5 - 1 = 4

int[] resultArray = new int[inputArray.Length / 2 + inputArray.Length % 2];

for (int i = 0; i < resultArray.Length; i++)
{
    // [1 2 3 4 5]
    // Индекс числа "3" - 2
    // 0 - 4
    // 2 -> 4-2
    resultArray[i] = inputArray[i] * inputArray[lastIndex - i];
    if (i == lastIndex - i)
    {
        resultArray[i] = inputArray[i];
    }
}
Console.WriteLine($"Ответ: [{String.Join("; ",resultArray )}]");




