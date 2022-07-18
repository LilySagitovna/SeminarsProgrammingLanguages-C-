// Напишите программу, которая принимает на вход координаты точки (X и Y),
//  причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости,
//   в которой находится эта точка.

int X = Convert.ToInt32(Console.ReadLine());

int Y = Convert.ToInt32(Console.ReadLine());

if (X > 0 && Y > 0)
{
   Console.WriteLine("Четверть: 1");
}

if (X < 0 && Y > 0)
{
   Console.WriteLine("Четверть: 2");
}

if (X <0 && Y <0)
{
   Console.WriteLine("Четверть: 3");
}


if (X > 0 && Y < 0)
{
   Console.WriteLine("Четверть: 4");
}


