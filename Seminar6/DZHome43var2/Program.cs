/* Задача 43: Напишите программу, которая найдёт 
точку пересечения двух прямых, заданных уравнениями 
y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 
задаются пользователем.
 k1 = 5, b1 = 2, k2 = 9, b2 = 4,  -> (-0,5; -0,5) */

ConditionsTask();

void ConditionsTask()
{
    Console.Write("Для поиска пересечений двух прямых на плоскости, "
        + "заданные уравнениями прямых с угловыми коэффициентами: "
        + "y = k1 * x + b1 и y = k2 * x + b2, где k1 и k2 - показатели коэффициентов,"
        + " а b1 и b2 - величина ординаты точки пересечения прямой с осью Оу. ");
    System.Console.WriteLine();
}

System.Console.Write("Задайте значения k1, b1, k2, b2 соответственно:\t");
string[] numbers = Console.ReadLine()!.Split(",");
double k1 = double.Parse(numbers[0]);
double b1 = double.Parse(numbers[1]);
double k2 = double.Parse(numbers[2]);
double b2 = double.Parse(numbers[3]);

void FindingPointIntersection(double k1, double b1, double k2, double b2)
{
    if (k1 == k2)
    {
        if (k1 == k2 && b1 == b2) Console.WriteLine($"Прямые совпадают"
                                         + " и имеют бесконечное множество точек пересечения.");
        else Console.WriteLine($"Прямые параллельны друг другу и не имеют точек пересечения.");
    }
    else
    {
        double x = (-b2 + b1) / (-k1 + k2);
        double y = k2 * x + b2;
        Console.WriteLine($"Точки пересечения двух прямых [{x};{y}].");
        if (k1 * k2 == 0) Console.WriteLine("Прямые перпендикулярны.");
    }
}

FindingPointIntersection(k1, b1, k2, b2);