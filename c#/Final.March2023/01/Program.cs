// 1. Создать репозиторий на GitHub
// 2. Нарисовать блок-схему алгоритма (можно обойтись блок-схемой основной содержательной части,
// если вы выделяете ее в отдельный метод)
// 3. Снабдить репозиторий оформленным текстовым описанием решения (файл README.md)
// 4. Написать программу, решающую поставленную задачу
// 5. Использовать контроль версий в работе над этим небольшим проектом (не должно быть так, что все залито
// одним коммитом, как минимум этапы 2, 3 и 4 должны быть расположены в разных коммитах)

// Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина
// которых меньше либо равна 3 символа.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
// Примеры:
// ["hello", "2", "world", ":-)"]-> ["2", ":-)"]
// ["1234", "1567", "-2", "computer science"] -> ["-2"]
// ["Russia", "Denmark", "Kazan"] -> */

string Step1 (string msg)
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