// Задача 44: Не используя рекурсию, 
// выведите первые N чисел Фибоначчи. 
// Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8
int numberFibonachi = Convert.ToInt32(Console.ReadLine()); // принимаем число с консоли
int fibonachiFerst = 0;
int fibonachiSecond = 1;
int fibonachi = 0;

for (int i = 2; i <= numberFibonachi; i++) // заполняем массив
{
    fibonachi = fibonachiFerst + fibonachiSecond;
    System.Console.WriteLine($"{numberFibonachi} равно {fibonachi}");
    fibonachiFerst = fibonachiSecond;
    fibonachiSecond = fibonachi;
}


