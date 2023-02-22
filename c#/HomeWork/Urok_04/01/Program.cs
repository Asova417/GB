// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

//1 - варинат решения.

double Step1(string messange)
{
    Console.Write(messange);
    double result = Convert.ToDouble(Console.ReadLine());
    return result;
}

double Step2(double chislo, double stepen)
{
    double result = Math.Pow(chislo, stepen);
    return result;
}

double a = Step1("Введи число, которое нужно возвести в степень: ");
double b = Math.Abs(Step1("Введите значение степени: "));
double Result = Step2 (a, b);
Console.WriteLine(Result);

// 2 - варинат решения.

int Step1 (string message)
{
    Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int Step2 (int chislo, int stepen)
{
    int result = 1;
    for (int i = 1; i <= stepen; i++)
    {
        result *= chislo;
    }
    return result;
}

int a = Step1 ("Введите число, которорое нужно возвести в степень: ");
int b = Math.Abs(Step1 ("Введите значене степени: "));

int c = Step2(a, b);
Console.WriteLine(c);