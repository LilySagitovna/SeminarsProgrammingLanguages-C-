// Задача 40: Напишите программу, которая принимает
//  на вход три числа и проверяет, может ли существовать 
//  треугольник с сторонами такой длины.
int numbersOne = int.Parse(Console.ReadLine()!);
int numbersTwo = int.Parse(Console.ReadLine()!);
int numbersThree = int.Parse(Console.ReadLine()!);

//bool result =  numbersOne<=(numbersTwo + numbersThree) true: false;
if (numbersOne<(numbersTwo + numbersThree) && numbersTwo<(numbersOne + numbersThree) 
    && numbersThree<(numbersTwo + numbersOne))
{
    System.Console.WriteLine("Может");
}
else
{
    System.Console.WriteLine("Не может");
}