// // Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// // [1,0,1,1,0,1,0,0]
// void NumberRandom(int[] collection)  //имя метода void -  метод который не выводит результат и не нуждается в команде ruturn result
// {
//     int length = collection.Length;  //длинна массива
//     int index = 0;
//     while (index < length) //пока индек меньше длинны
//     {
//         collection [index] = new Random().Next(0, 2);  // обратиться к int length = collection.Length на позицию индекс и положить туда новое случайное чило от 1 до 10
//         index++;
//     }                                      
// }


// void PrintArray (int[] col) //Метод будет печатать массив
// {
//     int count = col.Length;
//     int position = 0;
//     while (position < count) //пок позиция будет меньше чем count будет выводить
//     {
//         Console.Write(col[position] );
//         position ++;
//     }
// }

// int [] array = new int [8];

// //Вызов методов
// NumberRandom(array);   //метод заполняющий массив
// PrintArray(array); 


// Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]
int[] Nol_Ed=new int[8];
int count = Nol_Ed.Length;

Console.Write("[");

for (int i=0; i < count; i++)
{
Nol_Ed[i]=new Random().Next(0,2);
if(i==count-1)
{
    Console.Write($"{Nol_Ed[i]}");
    break;
}
Console.Write($"{Nol_Ed[i]}, ");
}
Console.WriteLine("]");