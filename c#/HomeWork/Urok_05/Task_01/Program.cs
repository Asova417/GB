// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int n = Step1("Длинна массива: ");
int[] Fignya = new int [n];
Random random = new Random();
int count = 0;

int Step1(string msg)
{
    Console.Write(msg);
    int result = Math.Abs(Convert.ToInt32(Console.ReadLine()));
    return result;
}

for (int i=0; i < Fignya.Length; i++)
{
    Fignya [i] = Convert.ToInt32(random.Next(100, 1000));
    Console.Write($"[{string.Join(", ", Fignya [i])}]");
}

for (int j=0; j<Fignya.Length; j++)
{
    if (Fignya[j]%2 == 0)
    {
        count++;
    }
}

Console.WriteLine();
Console.WriteLine($"Количество чётных чисел в массиве: {count}");

// Как сократить код?
// Нужно ли упаковывать в метод? Как можно упаковать в метод?