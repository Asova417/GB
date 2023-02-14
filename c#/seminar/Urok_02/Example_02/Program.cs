//Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

//456 -> 46
//782 -> 72
//918 -> 98

int number = new Random().Next(100, 1000);
Console.WriteLine ($"Ваше случайное число: {number} ");

int a = number/10;
int b = number%10;

Console Write.Line ($"{a} {b}");