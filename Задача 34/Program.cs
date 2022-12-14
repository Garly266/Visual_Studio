bool HomeWork5 = true;

while (HomeWork5)
{
    string command = Console.ReadLine();

    switch (command)
    {
        case "task34": Task34(); break;
        case "task36": Task36(); break;
        case "task38": Task38(); break;
        case "exit": HomeWork5 = false; break;
    }
}

void Task34()
{
    #region
    Console.WriteLine("Введите размер массива");
    int size = Convert.ToInt32(Console.ReadLine());
    int[] numbers = new int[size];
    FillArrayRandomNumbers(numbers);
    Console.WriteLine("Вот наш массив: ");
    PrintArray(numbers);
    int count = 0;

    for (int z = 0; z < numbers.Length; z++)
        if (numbers[z] % 2 == 0)
            count++;

    Console.WriteLine($"всего {numbers.Length} чисел, {count} из них чётные");

    void FillArrayRandomNumbers(int[] numbers)
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = new Random().Next(100, 1000);
        }
    }
    #endregion
    void PrintArray(int[] numbers)
    {
        Console.Write("[ ");
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + " ");
        }
        Console.Write("]");
        Console.WriteLine();
    }
}

void Task36()
{
#region
Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);
Console.WriteLine("Вот наш массив: ");
PrintArray(numbers);
int sum = 0;

for (int z = 0; z < numbers.Length; z += 2)
    sum = sum + numbers[z];

Console.WriteLine($"всего {numbers.Length} чисел, сумма элементов на нечётных позициях = {sum}");

void FillArrayRandomNumbers(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(1, 10);
    }
}
#endregion
void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}

}

void Task38()
{
    #region
    Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
double[] numbers = new double[size];
FillArrayRandomNumbers(numbers);
Console.WriteLine("Вот наш массив: ");
PrintArray(numbers);
double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int z = 0; z < numbers.Length; z++)
{
   if (numbers[z] > max)
   {
    max = numbers[z];
   }
   if (numbers[z] < min)
   {
    min = numbers[z];
   }
}

Console.WriteLine($"всего {numbers.Length} чисел. Максимальное значение = {max}, минимальное значение = {min}");
Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");

void FillArrayRandomNumbers(double[] numbers)
{
for (int i = 0; i < numbers.Length; i++)
    {
       numbers[i] = Convert.ToDouble(new Random().Next(100, 1000)) / 100;
    }
}
#endregion

void PrintArray(double[] numbers)
{
Console.Write("[ ");
  for (int i = 0; i < numbers.Length; i++)
    {
       Console.Write(numbers[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}
}
