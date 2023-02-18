// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

int a1 = N/10000;
int a2 = (N/1000)%10;

int b1 = N%10;
int b2 = (N%100)/10;

if (a1 == b1 && a2 == b2)
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}