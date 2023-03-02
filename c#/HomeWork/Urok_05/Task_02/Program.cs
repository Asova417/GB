// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int n = Step1("Длинна массива: ");
if ( n == 0 || n < 0)
{
    Console.WriteLine("Длинна массива не может быть равно или меньше нуля.");
    return;
}
int min = Step1("Минимальное значение: ");
int max = Step1("Максимальное значение: ");
int[] Fignya = new int [n];
Random random = new Random();
int sum = 0;

int Step1(string msg)
{
    Console.Write(msg);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

for (int i=0; i < Fignya.Length; i++)
{
    Fignya [i] = Convert.ToInt32(random.Next(min, max));
    Console.Write($"[{string.Join(", ", Fignya [i])}]");
}
 for (int j = 0; j < Fignya.Length; j+=2)
    {
        sum+=Fignya[j];
    }
Console.WriteLine();
Console.WriteLine($"Сумма  элементов, стоящих на нечётных позициях: {sum}");