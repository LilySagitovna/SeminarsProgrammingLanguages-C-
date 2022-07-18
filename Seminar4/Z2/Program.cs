// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

// string number = Console.ReadLine();
// int digits = number.Length;
// Console.WriteLine(digits);

int number = Convert.ToInt32(Console.ReadLine());
int Count = 0;
while(number != 0)
{
    number /= 10;
    Count++;
}
Console.WriteLine(Count);
