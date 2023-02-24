// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

int Entry(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

int[] ArrManually(int lenght)
{
    int[] arr = new int[lenght];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Entry($"Введите целочисленное значение в элемент {i}: ");
    }
    return arr;
}

string ArrSearch(int search, int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (search == array[i])
            return $"данное число под индексом {i}: ";
    }
    return "К сожалению этого числа нет в данном массиве.";
}
int lenght = Entry($"Введите длину массива: ");
int[] array = ArrManually(lenght);
Console.WriteLine ($"[{string.Join(", ", array)}]");
int search = Entry($"Введите искомое число: ");
Console.WriteLine(ArrSearch(search, array));