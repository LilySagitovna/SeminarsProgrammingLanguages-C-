// Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

/* 
int nameDay(int numberDay)
{
    if (numberDay == 1) string day= numberDay.ToString(Console.Write("Понедельник"));
    if (numberDay == 2) string day= numberDay.ToString(Console.Write("Вторник"));
    if (numberDay == 3) string day= numberDay.ToString(Console.Write("Среда"));
    if (numberDay == 4) string day= numberDay.ToString(Console.Write("Четверг"));
    if (numberDay == 5) string day= numberDay.ToString(Console.Write("Пятница"));
    if (numberDay == 6) string day= numberDay.ToString(Console.Write("Суббота"));
    if (numberDay == 7) string day= numberDay.ToString(Console.Write("Воскресенье"));
}


Console.WriteLine("Введите число от 1 до 7, соответствующего дню недели");
int numberDay = Convert.ToInt32(Console.ReadLine());
if (numberDay <= 5)
{
    nameDay(Day); 
    System.Console.WriteLine($" Не является выходным");
}
else
{
    nameDay(Day); 
    System.Console.WriteLine($"Является выходным");
} */



Console.WriteLine("Введите число от 1 до 7, соответствующего дню недели");
int day = Convert.ToInt32(Console.ReadLine());
Console.Write("День недели: ");
switch (day)
{
    case 1: System.Console.WriteLine("Понедельник - рабочий день"); break;
    case 2: System.Console.WriteLine("Вторник - рабочий день"); break;
    case 3: System.Console.WriteLine("Среда - рабочий день"); break;
    case 4: System.Console.WriteLine("Четверг - рабочий день"); break;
    case 5: System.Console.WriteLine("Пятница - рабочий день"); break;
    case 6: System.Console.WriteLine("Суббота - выходной день"); break;
    case 7: System.Console.WriteLine("Воскресенье - выходной день"); break;
    default: System.Console.WriteLine("Error"); break;
}




