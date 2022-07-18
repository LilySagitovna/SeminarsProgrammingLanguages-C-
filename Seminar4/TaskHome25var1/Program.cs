// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
//  и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

System.Console.WriteLine("Введите числа через запятую: ");
string[] numbers = Console.ReadLine()!.Split(',');
int num = int.Parse(numbers[0]);
int degree = int.Parse(numbers[1]);
if (degree > 0)
{
    Console.WriteLine($"Возведение числа {num}" +
                      $" в натуральную степень {degree}" +
                      $" равна {Math.Pow(num, degree)}");
}
else
{
    System.Console.WriteLine($"Внимание! Натуральная степень > 0 ");
}



