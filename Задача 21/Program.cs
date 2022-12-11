int x1 = ReadInt("Введите координату X1: ");
int y1 = ReadInt("Введите координату Y1: ");
int z1 = ReadInt("Введите координату Z1: ");
int x2 = ReadInt("Введите координату X2: ");
int y2 = ReadInt("Введите координату Y2: ");
int z2 = ReadInt("Введите координату Z2: ");

int a = x2 - x1;
int b = y2 - y1;
int c = z1 - z2;

double length = Math.Sqrt(a * a + b * b + c * c);
Console.WriteLine($"Расстояние между точками : {length}");


int ReadInt(string message)
{
    Console.WriteLine(message);

    if ( int.TryParse(Console.ReadLine(), out int i))
    { 
        return i; 
    }
    Console.WriteLine(" No message");
    return -1;
}
