/* Задача 66: Задайте значения M и N. 
Напишите программу, которая найдёт 
сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

Console.WriteLine("Найдти сумму натуральных элементов в промежутке от M до N.");
Console.WriteLine("Введите число M: ");
int M = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число N: ");
int N = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Сумма натуральных элементов равна {SummNaturNumberRecursiv(M,N)}");

int SummNaturNumberRecursiv(int numberFerst, int numberSecond)
{
    if (numberFerst == numberSecond) return numberSecond;
    else return (numberFerst + SummNaturNumberRecursiv(numberFerst + 1, numberSecond));
}