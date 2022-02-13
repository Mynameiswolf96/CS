using System;

namespace Hello_CS
{
	internal class Program
	{

		static bool Proverka(string login, string password)
		{
			string l = "root";
			string p = "GeekBrains";

			if (l == login && p == password)
			{
				return true;
			}
			else
				return false;
		}
		static int Print(int a, int b)
		{
			{
				Console.Write("{0,4} ", a);
				if (a < b) Print(a + 1, b);
				if ((b - a + 1) % 2 == 0)
				{
					return (a + b) * ((b - a + 1) / 2);
				}
				else { return (a + b) * ((b - a) / 2) + ((a + b) / 2); }
			}

		}



		static long RecursiveSum(long a)
		{

			if (a == 0)
			{
				return 0;
			}
			else return RecursiveSum(a / 10) + a % 10;


		}
		static void Task01()
		{
			Console.WriteLine("Введите число a");
			double a = double.Parse(Console.ReadLine());
			Console.WriteLine("Введите число b");
			double b = double.Parse(Console.ReadLine());
			Console.WriteLine("Введите число c");
			double c = double.Parse(Console.ReadLine());
			if (a < b && a < c)
			{
				Console.WriteLine(a);
			}
			else if (b < c && b < a)
			{
				Console.WriteLine(b);
			}
			else
			{
				Console.WriteLine(c);
			}
		}


		static void Task02()
		{
			Console.WriteLine("Введите число a");
			double a = double.Parse(Console.ReadLine());
			int i = 0;
			while (a >= 1)
            {
				a = a / 10;
				i++;
			}
			Console.WriteLine("Количество цифр " + i);

		}
		static void Task03()
		{
			Console.WriteLine("Введите число a");
			double a = double.Parse(Console.ReadLine());
			double b = 0;
			while (a != 0)
			{
				if (a % 2 == 1)
				{
					b = a + b;
				}
				Console.WriteLine("Введите число a");
				a = double.Parse(Console.ReadLine());
			}
			Console.WriteLine("Сумма введеных нечетных чисел= " + b);
		}
		static void Task04()
		{
			int i = 0;
			do
			{
				Console.WriteLine("Введите логин");
				string l = Console.ReadLine();
				Console.WriteLine("Введите пароль");
				string p = Console.ReadLine();
				if (Proverka(l, p) == true)
				{
					Console.WriteLine("Вы авторизовались");
					break;
				}
				else
				{
					Console.WriteLine("Повторые попытку");
				}
				i++;
			} while (i < 3);
		}
		static void Task05()
		{
			double m, h, I;
			string stroka;
			Console.WriteLine("Введите вес человека");
			stroka = Console.ReadLine();
			m = double.Parse(stroka);
			Console.WriteLine("Введите рост человека");
			stroka = Console.ReadLine();
			h = double.Parse(stroka);
			I = m / (h * h);
			Console.WriteLine("При весе:  {0}   и росте {1}   масса индекса тела будет равна:   {2:N}", m, h, I);
			if (I < 20)
			{
				double n = 20 * h * h;
				Console.WriteLine($"У вас недобор веса, вам надо добрать {(n - m):F2}   кг");
			}
			else if (I > 20 && I < 25)
			{
				Console.WriteLine("Ваш вес в норме");
			}
			else
			{
				double n = 25 * h * h;
				Console.WriteLine($"Вам надо похудеть на  {(m - n):F2} кг");
			}
		}

		static void Task06()
		{
			DateTime dateTime = DateTime.Now;
			int schetchik = 0;
			for (int i = 1; i < 1000000000; i++)
			{

				if (i % RecursiveSum(i) == 0)
				{
					schetchik++;
				}


			}
			DateTime dateTime1 = DateTime.Now;
			Console.WriteLine(schetchik + " " + (dateTime1 - dateTime));
		}

		static void Task07()
		{
			Console.WriteLine("Введите число a");
			int a = int.Parse(Console.ReadLine());
			Console.WriteLine("Введите число b");
			int b = int.Parse(Console.ReadLine());
			Console.WriteLine(Print(a, b));
		}
			static void Main(string[] args)
			{
				Console.Title = "Кучук";
				Console.WriteLine("1-Task 1");
				Console.WriteLine("2-Task 2");
				Console.WriteLine("3-Task 3");
				Console.WriteLine("4-Task 4");
				Console.WriteLine("5-Task 5");
				Console.WriteLine("6-Task 6");
				Console.WriteLine("7-Task 7");

				do

				{
					string menu = Console.ReadLine();
					switch (menu)
					{
						case "1":
							Task01(); /*Написать метод, возвращающий минимальное из трёх чисел.*/
							break;
						case "2":
							Task02(); /*Написать метод подсчета количества цифр числа.*/
							break;
						case "3":
							Task03();/* С клавиатуры вводятся числа, пока не будет введен 0.Подсчитать сумму всех нечетных положительных чисел.*/
							break;
						case "4":
							Task04(); /*Реализовать метод проверки логина и пароля. На вход метода подается логин и пароль.На выходе истина, если прошел авторизацию, и ложь, если не прошел(Логин: root, Password: GeekBrains). Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает.С помощью цикла do while ограничить ввод пароля тремя попытками.*/

							break;
						case "5":


							Task05(); //а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает, нужно ли человеку похудеть, набрать вес или всё в норме.
									  //б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.

							break;
						case "6":
							Task06(); /*используя структуру DateTime.*Написать программу подсчета количества «хороших» чисел в диапазоне от 1 до 1 000 000 000. «Хорошим» называется число, которое делится на сумму своих цифр.Реализовать подсчёт времени выполнения программы, испо*/

							break;
						case "7":
							Task07();
							//				Task07(); a) Разработать рекурсивный метод, который выводит на экран числа от a до b(a < b).
							//б) *Разработать рекурсивный метод, который считает сумму чисел от a до b.
							break;
						case "0":
							return;
						default:
							Console.WriteLine("Wrong!");
							break;

					}
				}
				while (true);
			}
		}
	}



