Console.WriteLine("Введите 3 числа");
int a = int.Parse(Console.ReadLine()), b = int.Parse(Console.ReadLine()), c = int.Parse(Console.ReadLine());
int max = 0; 

if (a < b)
{
    max = b;  
}
if (a > b)
{
   max = a ;
}
if (c < max)
{
    Console.WriteLine(max);
}
if (c > max)
{
    Console.WriteLine(c);
}