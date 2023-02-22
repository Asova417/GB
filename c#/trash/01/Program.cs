// Console.WriteLine("Введите число1: ");
// int a1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число2: ");
// int b1 = Convert.ToInt32(Console.ReadLine());

// static int Sum (int a, int b)
// {
//     int result = a + b;
//     return result;
// }

// int c = Sum (a1, b1);
// Console.WriteLine(c);

int Nachalo(string message) //Метод ввода числа
{
    Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

static int Sum (int a, int b)//Метод расчета
{
    int result = a + b;
    return result;
}

int a1 = Nachalo("Введите первое число: ");
int b1 = Nachalo("Введите второе число: ");
int c = Sum (a1, b1);
Console.WriteLine(c);