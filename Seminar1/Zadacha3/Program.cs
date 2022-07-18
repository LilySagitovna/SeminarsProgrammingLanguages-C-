//Принимает на вход число n,а на выход выдает все числа от -n до +n
System.Console.WriteLine("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());
int count = -number;
System.Console.WriteLine("Ответ:");

while (count <= number)
{
    System.Console.Write($"{count}, ");
    count++;
}











