//Напишите программу, которая принимает на вход число и проверяет, 
//кратно ли оно одновременно 7 и 23.

14 -> нет
46 -> нет
161 -> да

Console.WriteLine("Enter your firstNumber");
int firstNumber = Convert.ToInt32(Console.ReadLine());
if(firstNumber%7 == 0 && firstNumber%23 == 0)
{Console.WriteLine("Your Number is good div");}
else
{Console.WriteLine("Your Number is NOT good div");}