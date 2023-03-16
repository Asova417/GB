// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int Step1(string msg)
{
    Console.Write(msg);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

void FillArray3D(int[,,] array3D)
{
    int[] temp = new int[array3D.GetLength(0) * array3D.GetLength(1) * array3D.GetLength(2)];
    int num = 0;
    for(int i = 0; i < temp.GetLength(0); i++)
    {
        temp[i] = new Random().Next(10, 99);
        num = temp[i];
        for(int j = 0; j < i; j++)
        {
            while(temp[i] == temp[j])
            {
                temp[i] = new Random().Next(10, 99);
                num = temp[i];
            }
        }
    }
    int l = 0; 
    for(int i = 0; i < array3D.GetLength(0); i++)
    {
        for(int j = 0; j < array3D.GetLength(1); j++)
        {
            for(int k = 0; k < array3D.GetLength(2); k++)
            {
                array3D[i, j, k] = temp[l];
                l++;
            }
        }
    }
}

void PrintArray3D(int[,,] array3D)
{
  for(int i = 0; i < array3D.GetLength(0); i++)
  {
    for(int j = 0; j < array3D.GetLength(1); j++)
    {
        for(int k = 0; k < array3D.GetLength(2); k++)
        {
            Console.Write( $"{array3D[i,j,k]} ({i},{j},{k}); ");
        }
        Console.WriteLine();
    }
  }
}

int X = Step1 ("X: ");
int Y = Step1 ("Y: ");
int Z = Step1 ("Z: ");

Console.WriteLine($"Введите размер массива");
Console.WriteLine();
int[,,] array3D = new int[X, Y, Z];
FillArray3D(array3D);
PrintArray3D(array3D);