/* Задача 43: Напишите программу, которая найдёт 
точку пересечения двух прямых, заданных уравнениями 
y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 
задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */

System.Console.Write("Задайте значения b1:\t");
double b1 = double.Parse(Console.ReadLine()!);

System.Console.Write("Задайте значения k1:\t");
double k1 = double.Parse(Console.ReadLine()!);

System.Console.Write("Задайте значения b2:\t");
double b2 = double.Parse(Console.ReadLine()!);

System.Console.Write("Задайте значения k2:\t");
double k2 = double.Parse(Console.ReadLine()!);

if (k1 == k2)
{
    if (k1 == k2 && b1 == b2) Console.WriteLine($"Прямые совпадают");
    else Console.WriteLine($"Прямые параллельны");
}
else
{
    double x = (-b2 + b1) / (-k1 + k2);
    double y = k2 * x + b2;
    Console.WriteLine($"Точки пересечения двух прямых [{x};{y}]"); 
}



