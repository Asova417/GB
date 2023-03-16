// Задача №47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// Console.WriteLine("Минимальное значение: ");
// double min = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine("Максимальное значение: ");
// double max = Convert.ToDouble(Console.ReadLine());

int Step1(string msg)
{
    Console.Write(msg);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int min = Step1 ("Введите минимальное значение массива: ");
int max = Step1 ("Максимальное значение массива: ");

double[,] FillMatrixWithRandom(int row, int column)
{
    double[,] matrix = new double[row, column];
    Random rnd = new Random();
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = Convert.ToDouble(rnd.Next (min, max)/10.0);
        }
    }
    return matrix;
}

void PrintMatrix(double[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i,j] + " ");
        }
        Console.WriteLine();
    }
}

int row = Step1 ("Введите кол-во строк: ");
int column = Step1("Введите кол-во столбцов: ");
double[,] matrix = FillMatrixWithRandom(row, column);
PrintMatrix(matrix);

