﻿string Step1 (string msg)
{
    Console.WriteLine(msg);
    return Console.ReadLine()?? String.Empty;
}

string[] Algorithm(string[] array, int value, int length = 0)
{
    string[] arrTemp = new string[length];
    for (int i = 0, j = 0; i < array.Length; i++)
    {
        if (array[i].Length <= value)
        {
            if (arrTemp.Length > 0 && j < arrTemp.Length)
            {
                arrTemp[j] = array[i];
                j++;
            }
            length++;
        }
    }

    if (length > 0 && arrTemp.Length <= 0) return Algorithm(array, value, length);
    return arrTemp;
}

string[] ArrCreatAndFill(int lenght)
{
    string[] arr = new string[lenght];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Step1 ($"Введите любое значение в элемент массива: {i}");
    }
    return arr;
}

string[] arr = ArrCreatAndFill(lenght);

int lenght = Convert.ToInt32(Step1 ("Введите длину массива"));
int value = Convert.ToInt32(Step1 ("Элементы какой длинны необходимо найти?"));

Console.Write($"[{string.Join(", ", arr)}] -> [{string.Join(", ",Algorithm(arr, value))}]");