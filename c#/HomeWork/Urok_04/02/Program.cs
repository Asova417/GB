// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int Step1 (string message)
{
    Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int Step2 (int numb, int res = 0)
{
    while (numb > 0)
    {
        res += numb%10;
        numb = numb/10;
    }
    return res;
}

int a = Math.Abs(Step1 ("Введите число: "));
int Result = Step2 (a);
Console.WriteLine(Result);