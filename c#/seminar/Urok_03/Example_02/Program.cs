// // Задача №18. Работа в группах
// // Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y)
// Самостоятельное ужасное решение задачи.
// Console.Write("Введите число от 1 до 4: ");
// int n = Convert.ToInt32(Console.ReadLine());

// switch (n)
// {
//     case 1:
//         Console.Write("X > 0 && Y < 0");
//         break;


//     case 2:
//         Console.Write("X > 0 && Y > 0");
//         break;


//     case 3:
//         Console.Write("X < 0 && Y < 0");
//         break;


//     case 4:
//         Console.Write("X > 0 && Y < 0");
//         break;
//     default:
//     Console.WriteLine("Ошибка");
//     break;
// }

int Promt(string message)
{
Console.Write(message);
int result = Convert.ToInt32(Console.ReadLine());
return result;
}

bool Checked(int quater)
{
if(quater >= 1 && quater <= 4)
{
return true;
}
else
{
return false;
}
}

string[] quaters ={"x > 0; y > 0", "x < 0; y > 0", "x < 0; y < 0", "x > 0; y < 0"};

int quater = Promt("Введите четверть: ");

if(Checked(quater))
{
Console.Write(quaters[quater - 1]);
}
else
{
Console.Write("Неправильный номер четверти");
}
