// Задача 27: Напишите программу, которая принимает
//  на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

//////////////////////////////////////////////////////////
// System.Console.WriteLine("Введите число");
// int number = int.Parse(Console.ReadLine());
// int summ = 0;
// while (number > 10)
// {
//     summ += number % 10;
//     number /= 10;
// }   
// summ+=number;
// System.Console.WriteLine($"Сумма цифр в числе равно {summ}");

///////////////////////////////////////////////////////////////////////
System.Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine()!);
int summ = 0;
while (number > 0)
{
    summ += number % 10;
    number /= 10;
}
System.Console.WriteLine($"Сумма цифр в числе равна {summ}");
 
 

