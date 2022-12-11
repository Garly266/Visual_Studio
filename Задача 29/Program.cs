Console.WriteLine("Заполните массив");
int length = 8;
int[] array = new int[length];

    for (int i = 0; i < array.Length; ++i )
    {
      array [i] = int.Parse(Console.ReadLine());
    }
Console.WriteLine($"Массив:[{string.Join(", ", array)}].");