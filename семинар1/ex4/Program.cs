Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine());
int n = 0;
for (int s = 0; s < a; s++ )
{
    n++;
    if (n % 2 == 0)
    {
        Console.Write($"{n},");
    }
}