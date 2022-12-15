// Задача 63 и 65

int ReadInt()
{
    Console.WriteLine("input number");
    int a = int.Parse(Console.ReadLine());
    return a;
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
PrintNumbers(ReadInt(), ReadInt());






// Рекурсия наглядный пример 


PrintNumbers(1, 5);

void PrintNumbers(int m,int n)
{
    if (m < n)
    {
       Console.Write($"{m}, ");

       PrintNumbers(m + 1, n);
    }
    else
    { 
        Console.WriteLine(m);
    }
}


int n = int.Parse(Console.ReadLine());

int GetSum(int n)
{
    if (n > 0)
    return n%10 + GetSum(n/10);
    return 0;
}
Console.WriteLine(GetSum(n));


// Возведение в степень числа A в число B с помощью рекурсии

int A = int.Parse(Console.ReadLine());
int B = int.Parse(Console.ReadLine());

int GetPow(int A,int B)
{
    if (B > 1)
        return A * GetPow(A, B - 1);
    else return A ;
}
Console.WriteLine(GetPow(A,B));


//Решение через индексы 

string GetSum(string s, int index)
{
    if (index > 0)
    {
        string s1 = s[index - 1].ToString();
        string s2 = GetSum(s, index - 1);
        return (int.Parse(s1) + int.Parse(s2)).ToString();

    }
    return "0";
}

string s = "153";
Console.WriteLine(GetSum(s, s.Length));




