// 14.Напишите программу, которая принимает 
//на вход число и проверяет, кратно ли оно одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да


bool paritycheck (int number)

{
return(number % 7 == 0 && number % 23 == 0); // True, ес
}

Console.WriteLine(paritycheck(161));
