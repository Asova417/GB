// // Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// // 456 -> 3
// // 78 -> 2
// // 89126 -> 5

// int Counter(int number)
// {
// int count = 0;
// if(number == 0)
// {
// count = 1;
// }
// while(number > 0)
// {
// number/=10; // == number = number/10
// count++;
// }
// return count;
// }

// System.Console.Write("Введите число: ");
// int A = Math.Abs(Convert.ToInt32(Console.ReadLine()));
// Console.Write($"Количество цифр в числе = {Counter(A)}");

Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
[1,0,1,1,0,1,0,0]



// Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

System.Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[n];
Random rnd = new Random();
for(int i = 0; i < arr.Length; i++)
{
arr[i] = rnd.Next(0,2);
}
Console.WriteLine(string.Join(", ", arr));