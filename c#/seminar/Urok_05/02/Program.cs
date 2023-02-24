// Задача 32: Напишите программу замена элементов массива: 
// положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

int [] ArrReplace (int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = -1 * arr[i];
    }
    return arr;
}

int Entry (string msg)
{
    Console.WriteLine(msg);
    return Convert.ToInt32(Console.ReadLine());
}

int [] ArrManually(int lenght)
{
    int [] arr = new int [lenght];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Entry($"Введите целочисленное значение в элемент {i}");
    }
    return arr;
}

// int lenght = Entry($"Введите длину массива");
// int [] array = ArrManually(lenght);
// Console.Write($"[{string.Join(", ", array)}]");
// array = ArrReplace (array);
// Console.Write($"[{string.Join(", ", array)}]");


// int[] FillArrayWithRandomNumbers(int length)
// {
// int[] arr = new int [length];
// Random rnd = new Random();
// for(int i =0; i < arr.Length; i++)
// {
// arr[i] = rnd.Next(-9, 10);
// }
// return arr;
// }

// int[] newMassive(int[] array)
// {
// for(int i = 0; i < array.Length; i++)
// {
// array[i] = -array[i]; // == array[i] = array[i] * -1// == array[i]*= -1
// }
// return array;
// }

// System.Console.WriteLine("Введите длину массива: ");
// int length = Convert.ToInt32(Console.ReadLine());
// int[] array = FillArrayWithRandomNumbers(length);
// System.Console.WriteLine($"[{string.Join(", ", array)}]");
// int[] newArray = newMassive(array);
// System.Console.WriteLine($"[{string.Join(", ", newArray)}]");

// // Решение от преподавателя