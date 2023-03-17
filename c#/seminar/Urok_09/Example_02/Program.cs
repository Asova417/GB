// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите первое число: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int N = Convert.ToInt32(Console.ReadLine());

int Recurs(int M,int N)
{
    if (N == M)
    {
        return N;
    }
    return N + Recurs(M,N-1);
}

Console.Write($"Сумма элементов равна: {Recurs(M,N)}");