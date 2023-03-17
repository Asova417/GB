// Задача 64: Задайте значение N. Напишите программу, 
//которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
// Console.Write("Введите номер: ");
// int num = Convert.ToInt32(Console.ReadLine());

// int Recurs(int num)
// {
//     if (num == 0) return 0;
//     Console.Write("\t"+num);
//     return Recurs(num - 1) ;
// }

// Recurs(num);

void RoadToN(int N)
{
    if (N == 0)
    {
        return;
    }
    RoadToN(N - 1);
    Console.Write($"{N} ");
}

Console.Write("Введиет число: ");
int number = Convert.ToInt32(Console.ReadLine());

RoadToN(number);