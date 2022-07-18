// Задача 27: Напишите программу, которая принимает
//  на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


System.Console.WriteLine("Введите число");
string number = Console.ReadLine()!;
int length = number.Length;
int sumNum = 0;
for (int i = 0; i < length; i++)
{
    sumNum += (number[i] - '0');
}
System.Console.WriteLine($"Сумма цифр в числе {number} равняется {sumNum}");


//sum += (int)char.GetNumericValue(chislo[i]);  конверт чар в инт
// Convert.ToInt32(chislo[i].ToString());



