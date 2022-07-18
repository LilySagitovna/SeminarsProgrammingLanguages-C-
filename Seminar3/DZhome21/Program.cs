/* Напишите программу, которая принимает на вход 
координаты двух точек и 
находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53 */

// System.Console.WriteLine("Напишите координаты");
// int x1 = Convert.ToInt32(Console.ReadLine());
// int x2 = Convert.ToInt32(Console.ReadLine());

// int y1 = Convert.ToInt32(Console.ReadLine());
// int y2 = Convert.ToInt32(Console.ReadLine());

// int z1 = Convert.ToInt32(Console.ReadLine());
// int z2 = Convert.ToInt32(Console.ReadLine());



// double d = Math.Round(Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2)));
// System.Console.WriteLine("Расстояние между точками: " + d);

// По теореме Пифагора ∆t² = ∆y² + ∆z²
// Еще раз по теореме Пифагора ∆r² = ∆x² + ∆t²

System.Console.WriteLine("Введите координаты точки A через запятую:");
string A = Console.ReadLine()!;
var a1 = A.Split(',').Select(int.Parse).ToArray();

System.Console.WriteLine("Введите координаты точки B через запятую:");
string B = Console.ReadLine()!;
var b1 = B.Split(',').Select(int.Parse).ToArray();

double d = Math.Sqrt(Math.Pow(b1[0]-a1[0],2) + Math.Pow(b1[1]-a1[1],2) + Math.Pow(b1[2]-a1[2],2));
System.Console.WriteLine($"Расстояние между точками: {d}");