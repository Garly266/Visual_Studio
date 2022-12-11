Console.WriteLine("Введите число");
int day = int.Parse(Console.ReadLine());

if (day > 7 )
{
    Console.WriteLine("Неправильный ввод");
    return;
}
if (day == 6 || day == 7 )
{
    Console.Write("Выходной");
}
else
{
    Console.Write("Будний день");
}