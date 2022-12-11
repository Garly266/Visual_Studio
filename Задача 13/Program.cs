Console.WriteLine("Введите число");
int i = int.Parse(Console.ReadLine());

if (Math.Abs(i) <= 99)
{
    Console.WriteLine("Нет третьего символа");
}
else
{
    string s1 = i.ToString();
    if (i > 0 )
    {
        Console.WriteLine(s1[2]);
    }
    else
    {
        Console.WriteLine(s1[3]);
    }
}