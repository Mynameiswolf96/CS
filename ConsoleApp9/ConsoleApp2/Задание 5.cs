//а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
//б) *Сделать задание, только вывод организовать в центре экрана.
//в) **Сделать задание б с использованием собственных методов (например, Print(string ms, int x, int y).
using System;

namespace Hello_CS
{
    internal class Program
    {
        static void Print()
        {
            Console.Write("Введите ширину консольного окна");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Введите высоту консольного окна");
            int y = int.Parse(Console.ReadLine());
            Console.WindowHeight = y;
            Console.WindowWidth = x;
            Console.BufferHeight = y;
            Console.BufferWidth = x;
            Console.SetCursorPosition(x/2-7,y/2-7);    
            
        }
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Title = "Кучук";
            string stroka;
            Console.Clear();
            Print();
            Console.Write("Valery Kuchuk Minsk");

        }
    }
}