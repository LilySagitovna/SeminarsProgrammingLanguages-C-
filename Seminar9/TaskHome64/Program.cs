/* Задача 64: Задайте значения M и N. 
Напишите программу, которая выведет 
все натуральные числа в промежутке от M до N.
M = 1; N = 5. -> ""1, 2, 3, 4, 5""
M = 4; N = 8. -> ""4, 6, 7, 8"" */

Console.WriteLine("Вывести все натуральные числа в промежутке от M до N.");
Console.WriteLine("Введите значение числа М: ");
int M = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите значение числа N: ");
int N = int.Parse(Console.ReadLine()!);
Console.WriteLine(IntegersRecursivno(M,N)); 

string IntegersRecursivno(int numberFirst, int numberSecond)
{
    if (numberFirst == numberSecond) return numberSecond.ToString();
    else return (numberFirst + ", " + IntegersRecursivno(numberFirst+1, numberSecond));
}