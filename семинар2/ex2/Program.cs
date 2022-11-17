Console.WriteLine("Введите число до 10000");
string a =  Console.ReadLine(); 
int b = int.Parse(a);
if (a.Length < 3)
{
    Console.WriteLine("подумайте по лучше над числом которое ввели");
}
else
{
    if (b > 10000)
    {
        Console.WriteLine("подумайте по лучше над числом которое ввели");
    }
    else
    {
        Console.WriteLine($"третья цыфра введённого числа : {a[2]}");
    }
    //if (a.Length > 5 )  - 10 минут жизни на непонимание что не так ;)
    //{
        //Console.WriteLine("подумайте по лучше над числом которое ввели");
    //}
    //else
    //{
       //Console.WriteLine($"третья цыфра введённого числа : {a[2]}"); 
    //}

}