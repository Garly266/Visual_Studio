int N = int.Parse(Console.ReadLine());

int i = 0;

while (i <= N)
{
    Console.WriteLine($"Четное число {i%2==0}");
    i=i+2;
}

Console.WriteLine("Нет четных чисел");
