int a = ReadInt("Введите число: ");
int b = ReadInt("Введите степень: ");

double result = Math.Pow(a, b);
Console.WriteLine($"Число {a} в степени {b} = {result}");

int ReadInt(string message)
{
    Console.WriteLine(message);

    if (int.TryParse(Console.ReadLine(), out int i))
    {
        return i;
    }
    Console.WriteLine(" No message");
    return -1;
}