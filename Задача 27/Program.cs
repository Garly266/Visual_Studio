int a = ReadInt("Введите число");
int Sum = 0;
while (a > 0)
{
    Sum = Sum + a % 10;
    a = a/ 10;
}
Console.WriteLine($"Сумма цифр в числе = {Sum}");


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
