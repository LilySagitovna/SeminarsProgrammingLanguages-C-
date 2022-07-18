//Программа принимает на вход число,а выдает последнюю цифру числа 456 (6)
System.Console.WriteLine("Введите трехзначное число ");
int number = Convert.ToInt32(Console.ReadLine());
if (number >= 100 && number < 1000)
{
    System.Console.WriteLine(number % 10);
}                    
else
{
    System.Console.WriteLine("Error");
}
