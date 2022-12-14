
bool HomeWork6 = true;

while (HomeWork6)
{
    string command = Console.ReadLine();

    switch (command)
    {
        case "task41": Task41(); break; //Задача 41.
        case "task43": Task43(); break; //Задача 43.
        case "exit": HomeWork6 = false; break; // Выход.
    }
}


void Task41()
{
    // Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
    //    Пример:
    //    0, 7, 8, -2, -2 -> 2
    //    1, -7, 567, 89, 223-> 3

    int length = ReadInt("Введите длинну массива");
    int[] array = new int[length];
    FillArrayNumbers(array);

    Console.WriteLine($"Массив:[{string.Join(", ", array)}].");
    Console.WriteLine($"Количество положительных чисел в массиве = {PositiveNumbers(array)}");

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
    void FillArrayNumbers(int[] array)
    {
        for (int i = 0; i < length; i++)
        {
            Console.WriteLine("Введите M чисел , после каждой нажимая Enter");
            array[i] = Convert.ToInt32(Console.ReadLine());
        }
    }
    int PositiveNumbers(int[] array)
    {
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i]! > 0)
            {
                count++;
            }
        }
        return count;
    }
}


void Task43()
{
    // Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
    // заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 
    // задаются пользователем.
    // b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

   
    var a1 = ReadInt("Введите a1: ");
    var b1 = ReadInt("Введите b1: ");
    var a2 = ReadInt("Введите a2: ");
    var b2 = ReadInt("Введите b2: ");

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

    var x = -(b1 - b2) / (a1 - a2);
    var y = a1 * x + b1;

    x = Math.Round(x, 3);
    y = Math.Round(y, 3);

    Console.WriteLine($"Пересечение в точке: ({x};{y})");
}

