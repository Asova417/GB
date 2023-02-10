//Напишите программу, которая будет выдавать название дня недели по заданному номеру.
//3 -> Среда
//5 -> Пятница


Console.Write("Введите число: ");
int number = Convert.ToInt32 (Console.ReadLine());

if (number == 1)

{
    Console.WriteLine($"{number} = понедельник");
}
else if (number == 2)

{
    Console.WriteLine($"{number} = вторник");
}
else if (number == 3)

{
    Console.WriteLine($"{number} = среда");
}
else if (number == 4)

{
    Console.WriteLine($"{number} = четверг");
}
else if (number == 5)

{
    Console.WriteLine($"{number} = пятница");
}
else if (number == 6)

{
    Console.WriteLine($"{number} = суббота");
}
else if (number == 7)

{
    Console.WriteLine($"{number} = воскресенье");
}
else
{
    Console.WriteLine($"{number} = такого дня недели нет");
}

// Решение через Switch_case
// Задача №3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3 -> Среда 
// 5 -> Пятница

//Console.Write("Введите день недели: ");
//int day = Convert.ToInt32(Console.ReadLine());

//switch (day)
//{
    //case 1:
    //    Console.Write("Понедельник");
    //    break;

    // case 2:
    //    Console.Write("Вторник");
    //    break;

    //case 3:
    //    Console.Write("Среда");
    //    break;

    //case 4:
    //    Console.Write("Четверг");
    //    break;

    //case 5:
    //    Console.Write("Пятница");
    //    break;

    //case 6:
    //    Console.Write("Суббота");
    //    break;

    //case 7:
    //    Console.Write("Воскресенье");
    //    break;

    //default:
    //    Console.Write("Не верное значение!");
    //    break;
//}