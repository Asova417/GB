//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

//4 -> да
//-3 -> нет
//7 -> нет

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
double b = a;

int a1 = a/2;
double b1 = b/2;

if (a1 == b1)
{
    Console.WriteLine($"{a} - чётное число");
}
else
{
    Console.WriteLine($"{a} - нечётное число");
}