// Напишите программу, которая принимает на вход 
// трёхзначное число и на выходе показывает вторую цифру этого числа.

// System.Console.WriteLine("Введите трехзначное число: ");
// int number = int.Parse(Console.ReadLine()!);
// int secondNumber = number / 10 % 10;
// System.Console.WriteLine($"Вторая цифра трехзначного числа: {secondNumber}");

System.Console.WriteLine("Введите трехзначное число: ");
string number = Console.ReadLine()!;
System.Console.WriteLine($"Вторая цифра трехзначного числа: {number[1]}");