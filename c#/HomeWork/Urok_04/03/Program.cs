// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int Step1 (string message)
{
    Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int min = Step1("Введите минимальное значение: ");
int max = Step1("Введите максимальное значение: ");
int n = Step1("Длинна массива: ");

int[] Nol_Ed=new int[n];
int count = Nol_Ed.Length;

Console.Write("[");

for (int i=0; i < count; i++)
{
Nol_Ed[i]=new Random().Next(min , max);
if(i==count-1)
{
    Console.Write($"{Nol_Ed[i]}");
    break;
}
Console.Write($"{Nol_Ed[i]}, ");
}
Console.WriteLine("]");

//Если смотреть правде в глаза, то если бы не подобная задача на семинаре, я бы это вообще не решила. Я не понимаю массивы, от слова СОВСЕМ =\ Мои одногруппники самые крутые!