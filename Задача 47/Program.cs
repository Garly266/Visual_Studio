bool HomeWork7= true;
Console.WriteLine("//Для того что бы запустить  задачу47 введите \"task47\" ");
Console.WriteLine("//Для того что бы запустить задачу50 введите \"task50\".");
Console.WriteLine("//Для того что бы запустить задачу52 введите \"task52\".");
Console.WriteLine("//Для того что бы выйти введиет \"exit\".");

while (HomeWork7)
{
    string command = Console.ReadLine();

    switch (command)
    {
        case "task47": Task47(); break;
        case "task50": Task50(); break;
        case "task52": Task52(); break;
        case "exit": HomeWork7= false; break;
    }
}
void Task47()
{
    int m = ReadInt("Задайте кол-во строк");
    int n = ReadInt("Задайте кол-во столбцов");

    int[,] matrix = new int[m, n];

    PrintArray(matrix);
    FillArray(matrix);
    Console.WriteLine();
    PrintArray(matrix);
}
void Task50()
{
    int m = ReadInt("Задайте кол-во строк M ");
    int n = ReadInt("Задайте кол-во столбцов N ");

    int[,] matrix = new int[m, n];

    PrintArray(matrix);
    FillArray(matrix);
    Console.WriteLine();
    PrintArray(matrix);

    int rows = ReadInt($"Задайте индекс строки от 0 до {m-1}");
    int colums = ReadInt($"Задайте индекс столбца от 0 до {n-1}");

    if (rows <= matrix.GetLength(0) && colums <= matrix.GetLength(1))
    {
        Console.WriteLine($"Значение индекса элемента {matrix[rows, colums]}");
    }
    else Console.WriteLine("Значения не существует");
}
void Task52()
{
    int row = ReadInt("Задайте кол-во строк M ");
    int column = ReadInt("Задайте кол-во столбцов N ");

    int[,] matrix = new int[row, column];

    PrintArray(matrix);
    FillArray(matrix);
    Console.WriteLine();
    PrintArray(matrix);
    double GetSumColums(int[,] matr, int column)
    {
        int result = 0;

        for (int i = 0; i < matr.GetLength(0); i++)
        {
            result = result + matr[i, column];
        }
        return Math.Round(result / (double)matr.GetLength(0), 2);
    }


    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        Console.WriteLine($" Среднее арифметическое столбца {i} = {GetSumColums(matrix, i)}");
    }
}

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]}");
        }
        Console.WriteLine();
    }
}
void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);//[1; 10)
        }
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
