// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int Step1(string msg)
{
    Console.Write(msg);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int Step2(string msg)
{
    Console.Write(msg);
    int result = Math.Abs(Convert.ToInt32(Console.ReadLine()));
    return result;
}

int row = Step2 ("Введите количество строк: ");
int column = Step2("Введите количество столбцов: ");
int min = Step1 ("Введите минимальное значение массива: ");
int max = Step1 ("Максимальное значение массива: ");
if (max < min)
{
    Console.WriteLine("Ваше максимальное значение меньше, минимального. Исправьте пожалуйста~~~<3");
    return;
}

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

for(int j = 0; j < matrix.GetLength(1); j++)
{
    double result = 0;
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        result = result + matrix[i,j];
    }
    result = Math.Round((result / row),1);

    Console.Write($"[{string.Join(", " , result)}]");
}
Console.WriteLine("~(=^_^=)~");