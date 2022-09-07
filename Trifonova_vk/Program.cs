using System;

namespace Trifonova_vk
{
    internal class Program
    {
        public static void Zadanie_1(double a, double b)
        {
            Console.WriteLine("Результат = "+ Math.Pow(a, b));
        }

        public static void Zadanie_3(double n)
        {
            double a = n % 2;
            double b = n % 3;
            if (a == b)
            {
                Console.WriteLine("Число " + n + " при деление на 2 и на 3 остается одинаковый остаток:"+a);
            }
            else
            {
                Console.WriteLine("Число " + n + " при деление на 2 и на 3  не остается одинаковый остаток");
            }
        }
        public static void Zadanie_4(double n)
        {
            
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine(i+1);
                }
        }

        public static void Zadanie_5(double x, double y)
        {
            double rez = ((1 + Math.Sin(Math.Sqrt(x + 1))) / (Math.Cos(12 * y - 4)));
            Console.WriteLine("Результат уравнения = "+rez);
        }

        public static void Zadanie_6(double n)
        {
            int f1 = 1;
            int f2 = 1;
            for (int i = 0; i < n; i+=2)
            {
                f2 = f1;
                f1 = f1 + f2;
                Console.WriteLine(f1);
            }

        }

        static void Main(string[] args)
        {
            
        //    Console.WriteLine(" Задание 1 ");
        //    Console.WriteLine("Введите число: ");
        //    double a = Convert.ToDouble(Console.ReadLine());
        //    Console.WriteLine("Введите степень: ");
        //    double b = Convert.ToDouble(Console.ReadLine());

        //    Zadanie_1(a, b);

        //    Console.WriteLine(" Задание 3 ");
        //    Console.WriteLine("Введите число: ");
        //    double n = Convert.ToDouble(Console.ReadLine());
        //    Zadanie_3(n);

        //    Console.WriteLine(" Задание 4 ");

        //zamena: Console.WriteLine("Введите число: ");
        //   double n1 = Convert.ToDouble(Console.ReadLine());
          
        //    if ((n1>= 1)&&(10 >=n1))
        //    {
        //        Zadanie_4(n1);
        //    }
        //    else
        //    {
        //        if (n1<1)
        //        {
        //            Console.WriteLine("Число меньше чем 1");
        //            goto zamena;
        //        }
        //       else if (n1>10)
        //        {
        //            Console.WriteLine("Число больше чем 10");
        //            goto zamena;
        //        }
        //    }

        //    Console.WriteLine(" Задание 5 ");
        //    Console.WriteLine("Введите x: ");
        //    double x = Convert.ToDouble(Console.ReadLine());
        //    Console.WriteLine("Введите y: ");
        //    double y = Convert.ToDouble(Console.ReadLine());
        //    Zadanie_5(x, y);

            Console.WriteLine(" Задание 6 ");
            Console.WriteLine("Введите N=");
            int n2 = int.Parse(Console.ReadLine());
            Zadanie_6(n2);
        }
    }
}