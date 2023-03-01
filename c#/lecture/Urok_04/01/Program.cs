//string[,] table = new string[2, 5];
// чтобы обратиться к нужному массиву нужно указать наименование вначале индекс строки, затем столбца, после равно это переменная
//Инициализация происходит константой String.Empty
//table[0, 0]  table[0, 1]  table[0, 2]  table[0, 3]  table[0, 4]
//table[1, 0]  table[1, 1]  table[1, 2]  table[1, 3]  table[1, 4]

//table[1,2] = "слово";
// это цикл для распечатки массива
// for (int rows = 0; rows < 2; rows++) // количество строк 2, поэтому в условии меньше 2
// {
//     for (int columns = 0; columns < 5; columns++)// количество столбцов 5, поэтому меньше 5
//     {
//         Console.WriteLine($"{table[rows, columns]}-");
//     }
// }

int [,] matrix = new int [3,4]; // для инициализации цифры 3 и 4 должна присутствовать, но в строчках 18 и 20 можно заменить на имя массива и новыая функция дает размер данных-> 18 и 20 примеры
for (int i = 0; i < 3; i++)//работает со строками      for (int i = 0; i <matrix.GetLength(0); i++)  name_massiv.GetLength(0) - всегда 0!
{
    for (int j = 0; j < 4; j++)//работает со столбцами     for (int j = 0; j <matrix.GetLength(1); j++)  name_massiv.GetLength(1) - всегда 1!
    {
        Console.Write($"{matrix[i, j]} ");
    }
Console.WriteLine();
}