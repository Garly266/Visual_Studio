bool HomeWork9 = true;
Console.WriteLine("Для запуска Задачи64 наберите /task64/");
Console.WriteLine("Для запуска Задачи66 наберите /task66/");
Console.WriteLine("Для запуска Задачи68 наберите /task68/");

while (HomeWork9)
{
    string command = Console.ReadLine();

    switch (command)
    {
        case "task64": Task64(); break;
        case "task66": Task66(); break;
        case "task68": Task68(); break;
        case "exit": HomeWork9 = false; break; // Для того что бы выйти введите "exit".
    }
}
void Task64()
{
    //Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
    //Выполнить с помощью рекурсии.
    // N = 5-> "5, 4, 3, 2, 1"
    //N = 8-> "8, 7, 6, 5, 4, 3, 2, 1"

    int n = ReadInt("Введите число N");
    int m = ReadInt("Введите число M");

    PrintNumbers(m, n);
}
void Task66()
{
    /*Задача 66: Задайте значения M и N. Напишите программу,
      которая найдёт сумму натуральных элементов в промежутке от M до N.*/
    //M = 1; N = 15-> 120
    //M = 4; N = 8. -> 30

    int n = ReadInt("Введите начальное число N");
    int m = ReadInt("Введите конечное число  M");
    int sum = 0;

    PrintNumbers(m, n);

        for (sum = 0; n <= m; n++)
        { 
            sum = sum + n;
        }
    Console.WriteLine($"Сумма элементов = {sum}");
}
void Task68()
{
    /*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
      Даны два неотрицательных числа m и n.
      m = 2, n = 3->A(m, n) = 9
      m = 3, n = 2->A(m, n) = 29 */

    int m = ReadInt("Введите число M");
    int n = ReadInt("Введите число N");

    PrintNumbers(m, n);
    MethodAckermann(m, n);

    Console.WriteLine($"Функция Аккермана для чисел A({m},{n}) = {MethodAckermann(m, n)}");
}


void PrintNumbers(int n, int m)
{
    if (n > m)
    {
        Console.Write(m + ", ");
        PrintNumbers(n, m + 1);
    }
    else
    {
        Console.WriteLine(m);
    }
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
int MethodAckermann(int m, int n)
{
    if (m == 0) return n + 1;
    if (m != 0 && n == 0) return MethodAckermann(m - 1, 1);
    if (m > 0 && n > 0) return MethodAckermann(m - 1, MethodAckermann(m, n - 1));
    return MethodAckermann(m, n);
}


