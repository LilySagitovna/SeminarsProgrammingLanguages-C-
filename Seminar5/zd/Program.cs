// Задача 32: Напишите программу замена элементов массива: положительные 
//элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 
/* int[] inputinputArray = {1,2,2,3,5};
for(int i = 0; i < inputinputArray.Length; i++)
{
    inputinputArray[i] = -inputinputArray[i];
    
}
System.Console.WriteLine($"[{String.Join(", ", inputinputArray)}]"); */
//////////////////////////////////////////
// int [] array = {-4, -8, 8, 2};
// Console.Write("[");
// for (int index = 0;index < array.Length; index++)
// {
//     array[index] = -array[index];
//     // array[index] = array[index]*(-1)
//     Console.Write(array[index]);
//     
// }
// Console.Write("]");




// Задача 33: Задайте массив. Напишите программу, которая 
//определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

/* int[] inputArray = {6,7,19,345,3};
System.Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < inputArray.Length; i++)
{
    if (inputArray[i] == number)
    {
        Console.WriteLine(i);
        
    }
} */

int [] array = {1,2,3,4,5,88};

int searchNumber = -2;

bool flagResult = false; // false - ответ не найден

for (int i = 0; i<array.Length; i++)
{
    if (searchNumber == array[i])
    {
        flagResult = true;
        break;
    }
}

if (flagResult) Console.WriteLine($"Элемент {searchNumber} найден");
else Console.WriteLine($"Элемент {searchNumber} НЕ найден");
