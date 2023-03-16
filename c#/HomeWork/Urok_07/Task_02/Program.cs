// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


int Step1(string msg)
{
    Console.Write(msg);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int row = Step1 ("Введите количество строк: ");
int column = Step1("Введите количество столбцов: ");
int min = Step1 ("Введите минимальное значение массива: ");
int max = Step1 ("Максимальное значение массива: ");


int[,] FillMatrix(int row, int column)
{
    int[,] matrix = new int[row, column];
    Random rnd = new Random();
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = rnd.Next(min, max);
            Console.Write(matrix[i,j] + " ");
        }
        Console.WriteLine();
    }
    return matrix;
}

int[,] matrix = FillMatrix(row, column);
int N = Step1 ("Введите искомое число: ");
int indexNrow = -1;
int indexNcol = -1;
bool f = false;
for(int i = 0; i < matrix.GetLength(0); i++)
{
    for(int j = 0; j < matrix.GetLength(1); j++)
    {
        if(matrix[i,j] == N)
        {
            indexNrow = i;
            indexNcol = j;
            f = true;
            Console.WriteLine("[{0},{1}]", indexNrow, indexNcol);
        }
    }     
} 
if(f)
{
    Console.Write($"Последнее вхождение вашего числа: строка {indexNrow+1}, столбец {indexNcol+1} ");
}
else Console.WriteLine($"К сожалению вашего числа нет в массиве.");