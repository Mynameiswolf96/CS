//Написать программу обмена значениями двух переменных:
//а) с использованием третьей переменной;
//б) *без использования третьей переменной.

using System;
class Program
{
    static void Main(string[] args)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.BackgroundColor = ConsoleColor.Red;
        Console.Title = "Кучук";
        int a, b;
        string stroka;
        Console.WriteLine("Введите число a");
        stroka= Console.ReadLine();
        a=int.Parse(stroka);
        Console.WriteLine("Введите число b");
        stroka=Console.ReadLine();
        b = int.Parse(stroka);
        a = a + b;
        b = a - b;
        a = a - b;
        Console.WriteLine("После обмена значений: a={0} b={1}",a,b);
    }
}