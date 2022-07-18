//Напишите программу, которая на вход принимает число и выдаёт, 
//является ли число чётным (делится ли оно на два без остатка).
Console.Clear();
System.Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine()!);

if (number % 2 == 0)
{
    System.Console.WriteLine("Является четным");
}
else
{
    System.Console.WriteLine("Не является четным");
}



