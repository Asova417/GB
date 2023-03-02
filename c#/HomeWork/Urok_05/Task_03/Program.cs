// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int n = Step1("Длинна массива: ");
if ( n == 0 || n < 0 || n==1)
{
    Console.WriteLine("Длинна массива не может быть равно  или меньше нуля, а так же состоять из одного элемента.");
    return;
}

int[] Array = new int [n];
Random random = new Random();
int max = Array[0];
int min = Array[0];


int Step1(string msg)
{
    Console.Write(msg);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

for (int i=0; i < Array.Length; i++)
{
    Array [i] = Convert.ToInt32(random.Next(-99, 101));
    Console.Write($"[{string.Join(", ", Array [i])}]");
}

for (int i = 0; i < Array.Length; i++)
  {
    if (max<Array[i])
    {
      max = Array[i];
    }
    if (min>Array[i])
    {
      min = Array[i];
    }
  }
Console.WriteLine();
Console.WriteLine($"Максимальный элемент массива: {max}");
Console.WriteLine($"Минимальный элемент массива: {min}");
int result = max - min;

Console.WriteLine($"Разница между минимальным и максимальным значением в данном массиве: {result}");