﻿System.Console.WriteLine("Введите пятизначное число");
string a = Console.ReadLine();
int length = a.Length;
if ( a.Length > 5 )
{
    Console.WriteLine("Неправильный ввод");
}
if(a.Length <= 5 )
{
    if (a[0] == a[4] && a[1] == a[3] )
    {
       Console.WriteLine($"Число {a} является палиндромом");
        
    }
    else
    {
        Console.WriteLine($"Число {a} не является палиндромом");
    }
   
}









