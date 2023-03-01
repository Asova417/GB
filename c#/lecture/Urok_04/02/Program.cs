// Программа с методами распечатывающий массив и его заполняющий.

void PrintArray(int [,] matr)
{
    for (int i = 0; i < 3; i++)//работает со строками      for (int i = 0; i <matrix.GetLength(0); i++)  name_massiv.GetLength(0) - всегда 0!
    {
        for (int j = 0; j < 4; j++)//работает со столбцами     for (int j = 0; j <matrix.GetLength(1); j++)  name_massiv.GetLength(1) - всегда 1!
        {
            Console.Write($"{matr[i, j]} ");
        }
    Console.WriteLine();
    }
}

//Метод заполняющий массив
void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10); //[1; 10) - т.е. 10 не будет печататься он не включен в сам интервал
        }
    }
}

int [,] matrix = new int [3,4];
PrintArray(matrix);
FillArray(matrix);
Console.WriteLine(); //пустая строка, чтобы поделить пустой массив от заполненного
PrintArray(matrix);