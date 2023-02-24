// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21
//Решена в группе.
// int[] Arr(int[] array)
// {
//     int[] arr;
//     if (array.Length % 2 == 0)
//     {
//         arr = new int[array.Length / 2];
//         for (int i = 0; i < arr.Length; i++)
//         {
//             arr[i] = array[i] * array[array.Length - 1 - i];
//         }
//     }
//     else
//     {
//         arr = new int[array.Length / 2 + 1];
        
//         for (int i = 0; i < arr.Length-1; i++)
//         {
//             arr[i] = array[i] * array[array.Length - 1 - i];
//         }
//         arr[arr.Length-1] = array[arr.Length-1];
//     }


//     return arr;
// }

// int[] arr = { 6, 7, 3, 6};
// Console.Write($"[{string.Join(", ", arr)}]");
// arr = Arr(arr);
// Console.Write($"[{string.Join(", ", arr)}]");

// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int[] FillArrayWithRandomNumbers(int length)
{
int[] arr = new int[length];
Random rnd = new Random();
for (int i = 0; i < arr.Length; i++)
{
arr[i] = rnd.Next(1, 10);
}
return arr;
}

System.Console.WriteLine("Введите длину массива: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = FillArrayWithRandomNumbers(length);
System.Console.WriteLine($"[{string.Join(", ", array)}]");

int newLength = array.Length / 2 + array.Length % 2;
int[] newArray = new int[newLength];

for (int i = 0; i < array.Length / 2; i++)
{
newArray[i] = array[i] * array[array.Length - 1 - i];
}

if(array.Length % 2 > 0)
{
newArray[newArray.Length - 1] = array[array.Length/2];
}
System.Console.WriteLine(string.Join(", ", newArray));

// Решение от преподавателя.