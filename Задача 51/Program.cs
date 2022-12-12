int[,] inputTwoDimensionArray(int length, int secondLength)
{
    int[,] mass = new int[length, secondLength];
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        FillDimension(i, mass);

    }
    return mass;
}

int ReadInt()
{
    Console.WriteLine("input number");
    int a = int.Parse(Console.ReadLine());
    return a;
}

void FillDimension(int index, int[,] massiv)
{
    for (int i = 0; i < massiv.GetLength(1); i++)
    {
        massiv[index, i] = index + i;
    }
}

void GetArrayAsString(int[,] massive)
{
    int Sum = 0;
    for (int i = 0; i < massive.GetLength(0); i++)
    {
        for (int j = 0; j < massive.GetLength(1); j++)
        {
            Console.Write($"{massive[i, j]} ");
            if (i == j)
            {
                Sum += massive[i, j];
            }
        }
        Console.WriteLine();
    }
    Console.WriteLine($"Сумма чисел на главной диагонале = {Sum}");
}


Task();
void Task()
{
    int[,] array = inputTwoDimensionArray(ReadInt(), ReadInt());
    GetArrayAsString(array);
}
