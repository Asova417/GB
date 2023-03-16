// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

System.Console.Write("Введите количество строк: ");
int n = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите количество столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());

int[,] FillMatrix(int n, int m)
{
    int[,] matrix = new int[n, m];
    Random rnd = new Random();
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = rnd.Next(0, 10);
            Console.Write(matrix[i,j] + " ");
        }
        Console.WriteLine();
    }
    return matrix;
}


int[,] matrix = FillMatrix(n, m);
int min = int.MaxValue;
int Nrow = 0; 
for(int i = 0; i < matrix.GetLength(0); i++)
{
    int sumi = 0;   
    for(int j = 0; j < matrix.GetLength(1); j++)
    {
        sumi+= matrix[i,j];
    }
if(sumi < min) 
{
    min = sumi;
    Nrow = i + 1;
}
}
Console.WriteLine("Строка "+Nrow+", сумма - "+min);