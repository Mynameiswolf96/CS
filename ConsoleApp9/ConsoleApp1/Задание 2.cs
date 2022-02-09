//2.Ввести вес и рост человека. Рассчитать и вывести индекс массы тела (ИМТ) по формуле I=m/(h*h);
//где m — масса тела в килограммах, h — рост в метрах.

using System;

namespace Hello_CS
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Title = "Кучук";
            double m, h, I;
            string stroka;
            Console.WriteLine("Введите вес человека");
            stroka = Console.ReadLine();
            m = double.Parse(stroka);
            Console.WriteLine("Введите рост человека");
            stroka=Console.ReadLine();
            h = double.Parse(stroka);
            I = m / (h * h);

            Console.WriteLine("При весе:  {0}   и росте {1}   масса индекса тела будет равна:   {2:N}", m,h,I);
        }
    }
}