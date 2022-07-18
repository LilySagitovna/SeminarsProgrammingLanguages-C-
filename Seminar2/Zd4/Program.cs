// Выввести случайное число из отрезка (10.99)
// и показывает наибольшее число отрезка


/* int number = new Random().Next(10,100); // [10,100)
Console.WriteLine($"Рандомное число: {number}"); // Интерполяция
int digitOne = number / 10; //45-> 4
int digitTwo = number % 10;// 45 -> 5
Console.WriteLine($"Первая цифра нашего числа: {digitOne}");
Console.WriteLine($"Вторая цифра нашего числа: {digitTwo}");

int max = Math.Max(digitOne,digitTwo); // Max(1 число, 2 число)
// Max печатает самое большое число на экран среди 2
Console.WriteLine("Самое большое число: " + max); */

int number = new Random().Next(10, 100);
Console.WriteLine($"Рандомное число: {number}");
int digit1 = number % 10;
int digit2 = number / 10;
//int digit2=(number-digit1/10);
int largestDigit = digit1;
if (digit2 > largestDigit) largestDigit = digit2;
Console.WriteLine("Самое большое число: " + largestDigit);


