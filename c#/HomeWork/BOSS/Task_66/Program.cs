// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int Step1(string msg)
{
    Console.Write(msg);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int M = Step1 ("Введите первое число: ");
int N = Step1 ("Введите второе число: ");

int Recurs(int M,int N)
{
    if (N == M)
    {
        return N;
    }
    return N + Recurs(M,N-1);
}

Console.Write($"Сумма ваших элементов равна: {Recurs(M,N)}");

// int M = Step1 ("Введите первое число: ");
// int N = Step1 ("Введите второе число: ");

// int Step1(string msg)
// {
//     Console.Write(msg);
//     int result = Convert.ToInt32(Console.ReadLine());
//     return result;
// }

// int sum = 0;
// for(int i = M; i <= N; i++)
// {
//     sum+=i; 
// }
// Console.WriteLine($"Сумма чисел от M до N = {(sum)} ");