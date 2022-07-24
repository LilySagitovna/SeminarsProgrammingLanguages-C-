// Задача 69: Напишите программу, 
// которая на вход принимает два числа A и B,
//  и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

Console.Write("Enter the number please: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the number please: ");
int b = Convert.ToInt32(Console.ReadLine());

int PowerOf(int number, int power)
{
    if (number == 0) return 0;
    else if (power == 0) return 1;
    return number * PowerOf(number, power-1);
}
Console.Write(PowerOf(a,b));
////////////////////////////



// 69
int number = Convert.ToInt32(Console.ReadLine());

int power = Convert.ToInt32(Console.ReadLine());

int Pow(int num, int degree)
{
    if(degree == 0) return 1;
    return (num * Pow(num, degree-1));
}

System.Console.WriteLine(Pow(number,power));