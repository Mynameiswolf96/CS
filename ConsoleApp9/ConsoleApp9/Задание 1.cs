/*1. Написать программу «Анкета». Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес). В результате вся информация выводится в одну строчку:
а) используя склеивание;
б) используя форматированный вывод;
в) используя вывод со знаком $.*/
using System;

namespace Hello_CS
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.Title = "Кучук";
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Red;
            int  Age,Heigh,Weigh;
            string str, Name, Surname;
            Console.WriteLine("Введите имя");
            Name=Console.ReadLine();
            Console.WriteLine("Введите фамилию");
            Surname = Console.ReadLine();
            Console.WriteLine("Введите возраст: ");
            str = Console.ReadLine();
            Age = int.Parse(str);
            Console.WriteLine("Введите рост: ");
            str = Console.ReadLine();
            Heigh = int.Parse(str);
            Console.WriteLine("Введите вес: ");
            str = Console.ReadLine();
            Weigh= int.Parse(str);
            Console.WriteLine("Имя: " + Name + " Фамилия: "+Surname+" Возраст: " +Age.ToString() + " Вес: "+Weigh.ToString() + " Рост: "+Heigh.ToString());//Склейка строк
            Console.WriteLine("Имя: {0} Фамилия: {1} Возраст: {2} Вес: {3} Рост: {4}", Name, Surname, Age, Weigh, Heigh);//строка форматирования 
            Console.WriteLine($"Имя: {Name} Фамилия: {Surname} Возраст: {Age} Вес: {Weigh} Рост: {Heigh}", Name, Surname, Age, Weigh, Heigh);// Строка интерполяции        
        }
    }
}