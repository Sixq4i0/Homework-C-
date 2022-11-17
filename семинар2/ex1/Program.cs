Console.WriteLine("Введите трёхзначное число");
string a =  Console.ReadLine();
if (a.Length != 3 )
{
    Console.WriteLine("подумайте по лучше над числом которое ввели");
}
else 
{
    Console.WriteLine($"вторая цыфра введённого числа : {a[1]}");
}
