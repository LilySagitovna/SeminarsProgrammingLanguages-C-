try
{
    int a=int.Parse(Console.ReadLine()!);
}
catch (System.Exception e)
{
    Console.WriteLine("Не верно!");
    Console.WriteLine(e);
    throw;
}
//////////////////////////////////////////////////////////////
Console.WriteLine("Введите первое число");
int number = int.Parse(Console.ReadLine()!);

while (!int.TryParse(Console.ReadLine(), out number))
{
    System.Console.WriteLine("Введите корректное значение!");
}
System.Console.WriteLine(number);

///////////////////////////////////////////////////
