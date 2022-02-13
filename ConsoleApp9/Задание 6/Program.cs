//*Создать класс с методами, которые могут пригодиться в вашей учебе (Print, Pause).
using System;

namespace Hello_CS
{
    internal class Program
    {
        static void Print() //methode print
        {

            Console.Write("Введите ширину консольного окна");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Введите высоту консольного окна");
            int y = int.Parse(Console.ReadLine());
            Console.WindowHeight = y;
            Console.WindowWidth = x;
            Console.BufferHeight = y;
            Console.BufferWidth = x;
            Console.SetCursorPosition(x / 2 - 7, y / 2 - 7);

        }
        static void Pause() //methode pause
        { 
            Console.ReadKey();
        }
            static void Main(string[] args)
        {
           

        }
    }
}