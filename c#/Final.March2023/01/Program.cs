string Step1 (string msg)
{
    Console.WriteLine(msg);
    return Console.ReadLine()?? String.Empty;
}