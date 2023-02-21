// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.Write("Введите число : ");
int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));
string num = Convert.ToString(number);

Console.WriteLine($"{num.Length}");
