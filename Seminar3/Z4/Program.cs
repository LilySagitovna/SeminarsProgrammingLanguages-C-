// Задача 22: Напишите программу, которая принимает на вход число
// (N) и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

int N = Convert.ToInt32(Console.ReadLine());

// while(1<=N)
// {

// }

for (int i = 1; i <= N; i++)
{
    System.Console.WriteLine($"Квадрат числа {i} равен {Math.Pow(i,2)}");
    //System.Console.WriteLine($"Квадрат числа {i} равен {i*i}");
}