﻿// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

//Решение от преподавателя, пример работы РЕКУРСИИ

void BinaryView(int number)
{
if(number <= 0)
{
return;
}
BinaryView(number/2);
Console.Write(number%2);
}

System.Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
BinaryView(number);

//Решение в зале с преподавателем
// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

// void BinaryView(int number)
// {
// if(number <= 0)
// {
// return;
// }
// BinaryView(number/2);
// Console.Write(number%2);
// }

// System.Console.WriteLine("Введите число:");
// int number = Convert.ToInt32(Console.ReadLine());
// BinaryView(number);



// int num = Convert.ToInt32(Console.ReadLine());
// string arr = "";

// while (num > 0)
// {
// arr = arr + Convert.ToString(num % 2);
// num = num / 2;
// }

// char[] charArray = arr.ToCharArray();
// Array.Reverse(charArray);
// Console.WriteLine(string.Join("",charArray));

//Решение от Мухамеда

// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10

// int number = 0;
// string str = String.Empty;

// Console.WriteLine("Введите десятичное число");
// number = Convert.ToInt32(Console.ReadLine());

// while ( number > 0)
// {
//     str = Convert.ToString(number%2) + str;
//     number = number / 2;
    
// }
// Console.WriteLine(str);