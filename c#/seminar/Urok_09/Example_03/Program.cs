// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Write("Input M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input N: ");
int n = Convert.ToInt32(Console.ReadLine());

int Acer(int m, int n)
{
    if (m > 0 && n == 0)
    {
        return Acer(m - 1, 1);
    }
    else if (m > 0 && n > 0)
    {
        return Acer(m - 1, Acer(m, n - 1));
    }
    return n + 1;
}
Console.Write($"Ваш результат: {Acer(m, n)}");