// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int[] Arr(int[] array)
{
    int[] arr;
    if (array.Length % 2 == 0)
    {
        arr = new int[array.Length / 2];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = array[i] * array[array.Length - 1 - i];
        }
    }
    else
    {
        arr = new int[array.Length / 2 + 1];
        
        for (int i = 0; i < arr.Length-1; i++)
        {
            arr[i] = array[i] * array[array.Length - 1 - i];
        }
        arr[arr.Length-1] = array[arr.Length-1];
    }


    return arr;
}

int[] arr = { 6, 7, 3, 6};
Console.Write($"[{string.Join(", ", arr)}]");
arr = Arr(arr);
Console.Write($"[{string.Join(", ", arr)}]");