/* Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и 
минимальным элементов массива.
[3 7 22 2 78] -> 76 */

int length = 8;

double[] array = PrintArray(length);
Console.WriteLine($"Массив: [{String.Join("; ",array)}]");


double[] PrintArray(int size)
{
    double[] array = new double [size];
    for (int index = 0; index < size; index++)
    {
        array[index] = new Random().NextDouble() * (100-(-100))+(-100);
        array[index] = Math.Round(array[index],2);
    }
    return array;
}
int i = 0;
double max = array[i];
double min = array[i];
for (i = 1; i < array.Length; i++)
{
    if (array[i] > max) max = array[i];
    if (array[i] < min && array[i] != max) min = array[i];
}
Console.WriteLine($"max = {max}");
Console.WriteLine($"min = {min}");
Console.WriteLine($"Разница между max и min = {max - min}"); 



    

