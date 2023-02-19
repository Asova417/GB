//Виды методов (условные виды, неофициальные)
// 1 вид. Ничего не принимают/ничего не выдают

void Method1()
{
    Console.WriteLine("Автор данный программы");
}

Method1(); // Вызов метода. ВАЖНО! Наличие скобок () после имени самого метода.

// 2 вид. Принимает, не возвращает
void Method2 (string msg)
{
    Console.WriteLine(msg);
}

Method2("Текст сообщения"); // Method2(msg:"Текст");

//Пример именованных аргуметов
void Method21 (string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}

Method21 ("Теекст", 4); // Method21(count:4, msg:"текст");

// 3 вид. Не принимает, но возвращает
int Method3()
{
    return DateTime.Now.Year;
}
//(2)полож.зн.   (1) Прошедшая работа
int year = Method3(); //Вызов метода. 
Console.WriteLine(year);
//(3)Вывести

//4 вид. Принимает и возвращает
int Method4 (int count, string text)
{
    int i = 0;
    string result = string.Empty; //пустая строка
    
    while ( i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}

string res = Method4(10, "z");
Console.WriteLine(res);

//for в цикле
int Method4 (int count, string text)
{
    string result = string.Empty; //пустая строка
    for (int i = 0; i < count; i++;)
    //     счётчик    условие
    {
        result = result + text;
    }
    return result;
}

string res = Method4(10, "z");
Console.WriteLine(res);
