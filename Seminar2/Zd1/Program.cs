// 11.Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int number = new Random().Next(100,1000); 
Console.WriteLine($"Рандомное число: {number}"); // Интерполяция
int digitOne = number / 10; //45-> 4
int digitTwo = number % 10;// 45 -> 5
Console.WriteLine($"Первая цифра нашего числа: {digitOne}");
Console.WriteLine($"Вторая цифра нашего числа: {digitTwo}");


// int number = new Random().Next(100,1000);
// Console.WriteLine(number);

// int SearchNumber(int number)
// {
// int first = number / 100; // 456 -> 4
// int third = number % 10; // 456 -> 6
// return first * 10 + third; // 4,6 -> 4*10 + 6 = 46
// }

// Console.WriteLine(SearchNumber(number));
