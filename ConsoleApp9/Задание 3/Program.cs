//а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2, y2 по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2 - y1, 2).
//Вывести результат, используя спецификатор формата .2f (с двумя знаками после запятой);
//б) *Выполнить предыдущее задание, оформив вычисления расстояния между точками в виде метода.
using System;

namespace Hello_CS
{
    internal class Program
    {
        static double R(double x1, double x2, double y1, double y2) {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Title = "Кучук";
        Console.Write("Введите x1:");
        double x1 = double.Parse(Console.ReadLine());
        Console.Write("Введите x2:");
        double x2 = double.Parse(Console.ReadLine());
        Console.Write("Введите y1:");
        double y1 = double.Parse(Console.ReadLine());
        Console.Write("Введите y2:");
        double y2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Расстояние между точками {0:f2} ", R(x1, x2, y1, y2));
    }
}
}