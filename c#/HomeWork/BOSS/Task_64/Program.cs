// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
void RoadToN(int N, int temp)
{
    if (N == temp - 1)
    {
        return;
    }
    RoadToN(N,temp+1);
    Console.Write($"{temp} ");
}
Console.Write("Введиет число: ");
int number = Convert.ToInt32(Console.ReadLine());
int temp = 1;
RoadToN(number, temp);