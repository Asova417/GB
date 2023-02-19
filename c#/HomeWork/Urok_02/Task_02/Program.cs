//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

void FillArray (int [] colection)
{
    int length = colection.Length;
    int index = 0;
    while (index <  3)
    if (index < 3)
    {
        colection [index] = a/10;
        index++;
    }
    else if (index == 3)
    {
        break;
    }
}

void PrintArray(int[]col)
{
    int count = col.Length;
    int position = 0;
    while (position < count )
    if (position < 3)
    {
        position++;
    }
    else if (position == 3)
    {
        Console.WriteLine($"{index}");
    }
}

int [] array = new int[a];

FillArray (array);
PrintArray(array);