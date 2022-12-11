Console.WriteLine("Введите трехзначное число");
int number = int.Parse(Console.ReadLine());
int result = number % 100;
result = result / 10;
Console.WriteLine($"Вторая цифра в числе {result}");