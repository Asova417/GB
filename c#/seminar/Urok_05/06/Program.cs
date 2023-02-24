// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

int ArrSearch(int[] arry)
{
    int count = 0;
    for(int i = 0; i < arry.Length; i++)
    {
        if(arry[i] > 9 && arry[i] < 100)
        {
            count++;
        }
    }
    return count;
}

int[] arr = { 5, 18, 123, 6, 2};
Console.Write($"[{string.Join(", ", arr)}]");
int count = ArrSearch(arr);
Console.Write(count);