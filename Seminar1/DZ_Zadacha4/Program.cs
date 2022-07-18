//Напишите программу, которая на вход принимает число (N), 
//а на выходе показывает все чётные числа от 1 до N.
Console.Clear();
System.Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

//for (int index = 2; index <= number; index += 2)
//   System.Console.WriteLine(index);

int index = 2;
System.Console.WriteLine("Все четные числа: ");
while (index <= number)
{
    System.Console.Write($"{index},");
    index += 2;
}
System.Console.WriteLine("\b \b");