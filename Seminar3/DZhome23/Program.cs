// Напишите программу, которая принимает на вход 
// число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int N = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= N; i++)
{
    System.Console.WriteLine($"Куб числа {i} равен {Math.Pow(i,3)}");
    //System.Console.WriteLine($"Куб числа {i} равен {i*i*i}");
}


/////////////////////// Влада
// System.Console.WriteLine("Введите число N: ");
// int N = int.Parse(Console.ReadLine()!);

// Способ №1
/* int i = 1; 
int coub = 1;
while (i <= N)
{
    coub = i * i * i;
    Console.Write($"{coub},");
    i++;
}
System.Console.WriteLine("\b \b"); */


//Способ №2
/* for (int i = 1; i <= N; i++)
{
    Console.Write($"{Math.Pow(i, 3)},");
}
System.Console.WriteLine("\b \b"); */


//Способ №3

// int Coub(int a)
// {
// int coub = 1;
// int i = 1;
//     while (i <= a)
//     {
//         coub = i * i * i;
//         Console.Write($"{coub},");
//         i++;
//     }
//     return coub;
// }
// Coub(N);
// System.Console.WriteLine("\b \b");