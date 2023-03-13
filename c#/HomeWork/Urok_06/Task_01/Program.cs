// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//не работает
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int Step1(string msg)
{
    Console.Write(msg);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int n = Step1("Введите длинну массива: ");

int [] InArray (int n)
{
    int [] array = new int [n];
    for (int i = 0; i < array.Length; i++);
    {
        array [i] = Step1 ($" Введите {i + 1} элемент: ");
    }
    return array;
}

void Print (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"a[{i}] = {array[i]}");
    }
}

int Check(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    return count;
}

int [] array;
array = InArray(n);
Print(array);
Console.WriteLine($"Количество положительных элементов: {Check(array)}");