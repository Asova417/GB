void FillArray(int[] collection)  //имя метода void -  метод который не выводит результат и не нуждается в команде ruturn result
{
    int length = collection.Length;  //длинна массива
    int index = 0;
    while (index < length) //пока индек меньше длинны
    {
        collection [index] = new Random().Next(1, 10);  // обратиться к int length = collection.Length на позицию индекс и положить туда новое случайное чило от 1 до 10
        index++;
    }                                      
}


void PrintArray (int[] col) //Метод будет печатать массив
{
    int count = col.Length;
    int position = 0;
    while (position < count) //пок позиция будет меньше чем count будет выводить
    {
        Console.WriteLine(col[position]);
        position ++;
    }
}

int [] array = new int [10];

//Вызов методов
FillArray(array);   //метод заполняющий массив
PrintArray(array);  // метод который вывел на консоль результат заполнения