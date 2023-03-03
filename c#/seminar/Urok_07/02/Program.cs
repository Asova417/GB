// // Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
// // m = 3, n = 4.
// // 0 1 2 3
// // 1 2 3 4
// // 2 3 4 5

// //Решение в группе

// int[,] ArrayWithRandom(int row, int column)
// {
//     int[,] arr = new int[row, column];
    
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for(int j = 0; j < arr.GetLength(1); j++)
//         {
//             arr[i,j] = new Random().Next(1, 10);
//         }
        
//     }
//     return arr;
// }
// void PrintMatrix(int[,] matrix)
// {
//     for(int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for(int j = 0; j < matrix.GetLength(1); j++)
//         {
//             System.Console.Write(matrix[i,j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// int [,] Rewrite(int[,] matrix)
// {
//     for(int i = 2; i < matrix.GetLength(0); i++)
//     {
//         for(int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i,j] = matrix[i-1, j] + matrix[i-2, j];
//         }
//     }
//     return matrix;
// }

// Console.Write("Введите кол-во строк: ");
// int row = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите кол-во столбцов: ");
// int column = Convert.ToInt32(Console.ReadLine());
// int[,] matrix = ArrayWithRandom(row, column);
// PrintMatrix(matrix);
// Console.WriteLine();
// PrintMatrix(Rewrite(matrix));

// Решение от преподавателя
// Задача 48: Задайте двумерный массив размера m на n,
// каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

int[,] FillMatrix(int row, int column)
{
    int[,] matrix = new int[row, column];
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = i+j;
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
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

System.Console.Write("Введите кол-во строк: ");
int row = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите кол-во столбцов: ");
int column = Convert.ToInt32(Console.ReadLine());
int[,] matrix = FillMatrix(row, column);
PrintMatrix(matrix);