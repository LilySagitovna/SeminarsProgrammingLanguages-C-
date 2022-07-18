// Напишите программу, которая принимает на вход 
// пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
/////////////////////Мой первый вариант  - ПРАВИЛЬНЫЙ ВАРИАНТ В САМОМ НИЗУ
// Console.Clear();
// System.Console.WriteLine("Введите пятизначное число");
// string number = Console.ReadLine()!;
// int length = number.Length;
// // while (!int.TryParse(Console.ReadLine(), out var number))  -не понимаю как сделать чтобы работало вместе
// // {
// //      Console.WriteLine("ОШИБКА! ВЫ ВВЕЛИ НЕ ЦЕЛОЧИСЛЕННОЕ ЗНАЧЕНИЕ\n");   
// //      Console.Write("Введите целое число: ");
// // }
// if (length == 5)
// {
//      if (number.Reverse().SequenceEqual(number)) Console.WriteLine($"Число {number} является палиндромом"); 
//      // реверс переворачивает число,секьенсеквал сравнивает
//      else System.Console.WriteLine($"Число {number} не является палиндромом ");
// }
// else System.Console.WriteLine($"Error. Введите пятизначное число");
//////////////////////////////////////////////////////////////////////////////////////////////////////
// Console.WriteLine("Введите пятизначное число:"); -Влад
// string chislo = Console.ReadLine();

// if (chislo[0] == chislo[4] && chislo[1] == chislo[3])
// { System.Console.WriteLine("Является палиндромом."); }
// else
// { System.Console.WriteLine("Не является палиндромом."); }
//////////////////////////////////////////////////////////////////////
/* int Reversal(int number) - Костя - проверяет все числа,не только пятизначные
{
    int reverseNumber = 0;
    int tempNumber = number;
    while ( number > 0)
    {
        int remainder = number % 10;
        reverseNumber = reverseNumber * 10 + remainder;
        number /= 10;
    }    
return reverseNumber;
}
int invertedNumber = Reversal(inputNumber); */
////////////////////////////////////////////////////////////////////////////////////////////////
/* Console.WriteLine("Введите пятизначное число:"); // гибрид Влада))
int inputNumber = int.Parse(Console.ReadLine()!);

int Reversal(int number)
{
    int reverseNumber = 0;
    int tempNumber = number;
    while (number > 0)
    {
        int remainder = number % 10;
        reverseNumber = reverseNumber * 10 + remainder;
        number /= 10;
    }
    return reverseNumber;
}

int invertedNumber = Reversal(inputNumber);
int lenght = Convert.ToString(inputNumber).Length;

if (lenght == 5)
{
    if (Convert.ToString(inputNumber).SequenceEqual(Convert.ToString(invertedNumber)))
    {
        System.Console.WriteLine($"Число {inputNumber} - палиндром");
    }
    else
    {
        System.Console.WriteLine($"Число {inputNumber} - не палиндром");
    }
}
else
{
    System.Console.WriteLine($"Введено число имеющее менее 5 знаков");
} */
//////////////////////////////////////////////////////////////////////////////////////////// Влад допилил код
// Console.Clear();
// System.Console.WriteLine("Введите пятизначное число:"); //- ввод числа пользователем
// string input = Console.ReadLine()!; //- считать то,что ввел пользователь и присвоить в строку input
// Int32 number; // создать числовую переменную number
// bool result = int.TryParse(input, out number); //-вызвать метод трупарс  и присвоить результат 
// //выражения к переменной булевого типа  result - преобразовать строку инпут в намбер и если успешно то тру,если нет то фолс
// // Преобразует строковое представление числа в эквивалентное ему 32-битовое целое число со знаком. 
// //Возвращает значение, указывающее, успешно ли выполнено преобразование. тру или фолс выдаст
// while (!result)
// {
//     Console.WriteLine("ОШИБКА! ВЫ ВВЕЛИ НЕ ЦЕЛОЧИСЛЕННОЕ ЗНАЧЕНИЕ\n");
//     Console.Write("Введите целое число: ");
//     result = int.TryParse(Console.ReadLine()!, out number);
// }

// int length = Convert.ToString(number).Length;
// if (length == 5)
// {
//     if (Convert.ToString(number).Reverse().SequenceEqual(Convert.ToString(number))) Console.WriteLine($"Число {number} является палиндромом");
//     // реверс переворачивает число,секьенсеквал сравнивает
//     else System.Console.WriteLine($"Число {number} не является палиндромом ");
// }
// else
// {
//     System.Console.WriteLine($"Error. Введите пятизначное число");
// }

////////////////////////////////////////////////////////////////////////Мой второй вариант
Console.Clear();
System.Console.WriteLine("Введите пятизначное число");
string number = Console.ReadLine()!;
int length = number.Length;
int validatingNumber;
bool validating = int.TryParse(number, out validatingNumber);
if (validating && length == 5)
{
      if (number.Reverse().SequenceEqual(number)) Console.WriteLine($"Число {number} является палиндромом"); 
      // реверс переворачивает число,секьенсеквал сравнивает
      else System.Console.WriteLine($"Число {number} не является палиндромом ");
}
else System.Console.WriteLine($"Error. Введите пятизначное число!\n");

