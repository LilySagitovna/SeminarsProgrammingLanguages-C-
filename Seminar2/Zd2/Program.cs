// 12.Напишите программу, которая будет принимать 
//на вход два числа и выводить, является ли второе число 
//кратным первому. Если число 2 не кратно числу 1, 
//то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите первое число");
        int numberOne = int.Parse(Console.ReadLine()!);

        Console.WriteLine("Введите второе число");
        int numberTwo = int.Parse(Console.ReadLine()!);

        if (numberOne % numberTwo == 0)
        {
            Console.WriteLine($"{numberOne} кратно {numberTwo}");
        }
        else
        {
            System.Console.WriteLine(
                $"{numberOne} не кратно {numberTwo}," +
                $"остаток {numberOne % numberTwo}"
                );
        }
    }
}