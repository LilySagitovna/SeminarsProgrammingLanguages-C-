// Задача 42: Напишите программу, 
// которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

int numberDecimal = int.Parse(Console.ReadLine()!);

ConversionBinary(numberDecimal);

void ConversionBinary(int number)
{
    string result = String.Empty;// ""; - пустая строчка инициализируется
    while (number>0)
    {
        result = number % 2+ result;
        number/=2;
    }
    System.Console.WriteLine(result);
}

/* using System.Text.RegularExpressions; - Влад, linq
using System.Linq;

Console.WriteLine("Введите числа через запятую");
string input = Console.ReadLine();

var digits = (
    from c in input
    where Char.IsDigit(c)
    select c ).ToArray();

int count = 0;
for (int i = 0; i < digits.Length; i++)
{
    if (digits[i] > 0) count++;
}

System.Console.WriteLine(string.Join(',', digits));
System.Console.WriteLine(count); */