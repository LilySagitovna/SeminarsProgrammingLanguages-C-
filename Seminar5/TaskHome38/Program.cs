/* Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и 
минимальным элементов массива.
[3 7 22 2 78] -> 76 */

double[] array = { -1.9, 7, 22, 2, 78, 85.1,};
Console.WriteLine($"Массив: [{String.Join("; ", array)}]");
// SearchMax(array);
// SearchMin(array);
double differenceMaxMin = SearchMax(array) - SearchMin(array);
Console.WriteLine($"Разница между max и min = {differenceMaxMin}");

double SearchMax(double[] array)
{
    int i = 0;
    double max = array[i];
    for (i = 1; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
    }
    Console.WriteLine($"max = {max}");
    return max;
}


double SearchMin(double[] array)
{
    int index = 0;
    double min = array[index];
    for (index = 1; index < array.Length; index++)
    {
        if (array[index] < min) min = array[index];
    }
    Console.WriteLine($"min = {min}");
    return min;
}