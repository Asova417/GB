// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

double Distance2D(double ax, double ay, double az, double bx, double by, double bz)
{
double distance = Math.Sqrt(Math.Pow(bx - ax, 2) + Math.Pow(by - ay, 2) + Math.Pow(bz - az, 2));
return Math.Round(distance, 2);
}

Console.Write("Введите координату Х точки А: ");
double Ax = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Y точки А: ");
double Ay = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Z точки A: ");
double Az = Convert.ToDouble(Console.ReadLine());




Console.Write("Введите координату X точки B: ");
double Bx = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Y точки B: ");
double By = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Z точки B: ");
double Bz = Convert.ToDouble(Console.ReadLine());


double result = Distance2D(Ax, Ay, Az, Bx, By, Bz);
System.Console.WriteLine(result);

//Да, заддача решина, но это благодаря подобной, что была решена на занятии. Самостоятельно вряд ли бы решила с использованием метода. Не понимаю методы.