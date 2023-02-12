

/* Void - Метод(функция) который ничего не возвращает
1) Определили массив (строка 46)
2) FillArray - метод заполнили массив
3) PrintArray - метод Распечатали массив
*/

void FillArray(int[] collection)   //имя метода void -  метод который не выводит результат и не нуждается в команде ruturn result                     
{
    int length = collection.Length; // длинна массива
    int index = 0;
    while(index < length) //пока индекс меньше длинны
    {
        collection[index] = new Random().Next(1,10);  //обратиться к int length = collection.Length на позицию индекс и положить туда новое случайное чило от 1 до 10
        index++;
    }
}

void PrintArray(int []col)   //Метод будет печатать массив
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]); //пока позиция будет меньше чем count будет выводить
        position++;
    }
}

int Index0f(int[] collection, int find)  // метод который ищет позицию искомого значения
{
    int count = collection.Length;
    int index = 0;
    int position = -1;
    while (index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
     return position;
}

int[] array = new int[10]; // Создай новый массив в котором будет 10 элементов

FillArray(array); //метод заполняющий массив
PrintArray(array);  // метод который вывел на консоль результат заполнения
Console.WriteLine(); // просто отступ

int pos = Index0f(array, 9); // искомое значение в массиве
Console.WriteLine(pos);