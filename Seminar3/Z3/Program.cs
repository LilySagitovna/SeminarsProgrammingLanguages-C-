﻿// Задача 21: Напишите программу, которая принимает на вход 
// координаты двух точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21

//////////////
// Вычисление расстояния между взятыми на плоскости двумя точками 
// А(х А; у А) и В(х В; у В), выполняется по формуле 
// d = √((хА – хВ)2 + (уА – уВ)2), 
// где d – длина отрезка, который соединяет эти точки на плоскости. 
// Если один из концов отрезка совпадает с началом координат, 
// а другой имеет координаты М(х М; у М), то формула для вычисления 
// d примет вид ОМ = √(х М 2 + у М 2).


System.Console.WriteLine("Напишите координаты");
int x1 = Convert.ToInt32(Console.ReadLine());
int x2 = Convert.ToInt32(Console.ReadLine());
int y1 = Convert.ToInt32(Console.ReadLine());
int y2 = Convert.ToInt32(Console.ReadLine());


double d = Math.Round(Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2)));
System.Console.WriteLine("Расстояние между точками: " + d);