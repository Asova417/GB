﻿//Задача №5. Напишите программу, которая на вход принимает 
//одно число (N), а на выходе показывает все целые числа в 
//промежутке от -N до N.

//4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 
//2 -> " -2, -1, 0, 1, 2"

//Console.Write("Введите число: ");
//int numberA = Convert.ToInt32 (Console.ReadLine());
//int numberB = numberA - (numberA*2);

//while (numberB <= numberA)
//{
//    Console.Write(numberB+ "  ");
//    numberB++;
//}

Console.Write("Введите число: ");
int N = Convert.ToInt32 (Console.ReadLine());
int temp = -N; //*(-1) сокращение
while(temp <= N)
{
    Console.Write($"{temp} ");
    temp++; //temp = temp +1
}
