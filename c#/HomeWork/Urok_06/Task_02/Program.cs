// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double Step1(string msg)
{
    Console.Write(msg);
    double result = Convert.ToInt32(Console.ReadLine());
    return result;
}

double b1 = Step1("Введите значение b1: ");
double k1 = Step1("Введите значение b1: ");
double b2 = Step1("Введите значение b1: ");
double k2 = Step1("Введите значение b1: ");

double x = (b2 - b1) / (k1 - k2);
double y = k1 * x + b1;

Console.WriteLine($"две прямые пересекутся в точке X: {x}, Y: {y}");