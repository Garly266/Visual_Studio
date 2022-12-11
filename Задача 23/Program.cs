int number = ReadInt("Введите число N: ");

for (int i = 1; i <= number; i++)
{
    Console.Write($"{i * i * i} ");
}



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