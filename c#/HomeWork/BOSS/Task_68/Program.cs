// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
int M = Step1 ("Введите первое число: ");
int N = Step1 ("Введите второе число: ");

int Step1(string msg)
{
    Console.Write(msg);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int Accerman(int m,int n)
{
    if(m>0&&n>0) return Accerman(m-1,Accerman(m,n-1));
    else if(m>0&&n==0) return Accerman(m-1,1);
    else return n+1; 
}

Console.Write($"Результат: {Accerman(M, N)}");