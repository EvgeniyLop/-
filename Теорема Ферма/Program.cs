using System;

namespace Теорема_Ферма
{
    class Program
    {
        static void Main(string[] args)
        {
			int var = 0;
			Console.WriteLine("Введите диапозон чисел");
			int ch = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Введите диапозон степеней");
			int nc = Convert.ToInt32(Console.ReadLine());
			for (int n = 3; n <= nc; n++)
			{//цикл для степени
				for (int a = 1; a <= ch; a++)
				{ //цикл для числа a
					for (int b = 1; b <= ch; b++)
					{ //цикл для числа b
						for (int c = 1; c <= ch; c++)
						{ //цикл для числа c
							long x = Convert.ToInt64(Math.Pow(a, n));
							long y = Convert.ToInt64(Math.Pow(b, n));
							long z = Convert.ToInt64(Math.Pow(c, n));
							Console.WriteLine("Попытка №  {0}",var);
							Console.WriteLine("{0}^{1} + {2}^{1} = {3}^{1}", a, n, b, c);
							if (x + y == z)
							{
								Console.WriteLine("Теорема Ферма  неверна");
								Console.ReadKey();
								}
							else { Console.WriteLine("Неправильно, но я не унываю..."); var++; }
						}
					}
				}
			}
			Console.WriteLine("В заданном диапозоне ничего не найдено");
			Console.WriteLine("Было перебрано вариантов:{0}", var);
			Console.ReadKey();
		}
    }
}
