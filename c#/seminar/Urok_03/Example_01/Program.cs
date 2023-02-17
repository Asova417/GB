//Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y), 
//причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

int Promt(string message)
{
    Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

string Quaters(int x, int y)
{
    string result = "";
    if(x > 0 && y > 0)
    {
        result = "Точка лежит в 1-ой четверти";
    }
    else if(x < 0 && y > 0)
    {
        result = "Точка лежит вo 2-ой четверти";
    }
    else if(x < 0 && y < 0)
    {
        result = "Точка лежит в 3-ей четверти";
    }
    else if(x > 0 && y < 0)
    {
        result = "Точка лежит в 4-ой четверти";
    }
    else
    {
        result = "Точка лежит на одной из осей";
    }

    return result;
}


int X = Promt("Введите X координату ->");
int Y = Promt("Введите Y координату ->");

string quater = Quaters(X, Y);
Console.WriteLine(quater);