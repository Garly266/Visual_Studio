Console.WriteLine("Введите первое число");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число");
int b = int.Parse(Console.ReadLine());

Console.WriteLine("Введите третье число");
int c = int.Parse(Console.ReadLine());


int max = a;

if ( b > max )
{
    Console.WriteLine($"Максимальное число {b}");
}
else if ( c > max )
{
    Console.WriteLine($"Максимальное число {c}"); 
}
else
{
    Console.WriteLine($"Максимальное число {max}");
}

