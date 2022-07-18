// Напишите программу, которая выводит третью цифру
// заданного числа или сообщает, что третьей цифры нет.

System.Console.WriteLine("Введите число: ");
string number = Console.ReadLine()!;
if (int.Parse(number) > 99)
{
    System.Console.WriteLine($"Третья цифра числа: {number[2]}");
}
else
{
    System.Console.WriteLine("Третьей цифры нет");
}

// System.Console.WriteLine("Введите число: ");
// int number = int.Parse(Console.ReadLine()!);
// string index = number.ToString();
// if (number > 99)
// {
//     System.Console.WriteLine($"Третья цифра числа: {index[2]}");
// }
// else
// {
//     System.Console.WriteLine("Третьей цифры нет");
// }