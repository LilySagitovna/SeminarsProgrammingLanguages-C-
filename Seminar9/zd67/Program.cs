// Задача 67: Напишите программу, 
// которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

int ReturnSum(int n)
{
    if (n == 0) return 0;
    return (n%10) + ReturnSum(n/10);
}
Console.Write(ReturnSum(101110));

///////////////////////

// 67

// int number = Convert.ToInt32(Console.ReadLine());
// //456
// // 6, 5, 4 + 0
// int SumNumbers(int num)
// {
//     if (num == 0) return 0;
//     return (num % 10 + SumNumbers(num / 10));
// }

// Console.WriteLine(SumNumbers(number));

