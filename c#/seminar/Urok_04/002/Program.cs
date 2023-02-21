// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

int Proisvedenie (int number)
{
    int sum = 1;
    for (int i = 1; i <= number; i++)
    {
        sum *= i; //sum * 1 = i
    }
    return sum;
}

Console.Write("Введите число: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма чисел от 1 до А = {Proisvedenie (A)}");