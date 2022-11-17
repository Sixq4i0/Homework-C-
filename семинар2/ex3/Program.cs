Console.WriteLine("для определения является ли день недели выходным введите его номер");
string a =  Console.ReadLine(); 
int b = int.Parse(a);
if (a.Length < 1)
{
    Console.WriteLine("в неделе 7 дней \n НЕ МЕНЬШЕ!!!");
}
else
{
    if (b > 7)
    {
        Console.WriteLine("в неделе 7 дней \n НЕ БОЛЬШЕ!!!");
    }
    else
    {
        Console.WriteLine(b >= 6 ? "Да:)" : "Нет;(");
    }
}