//Калинина Н.А.
// 1.	Написать метод, возвращающий минимальное из трёх чисел

using System;

namespace _2._1_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            MinNumber();

        }

        private static void MinNumber()
        {
            string a, b, c;
            Console.WriteLine("Поиск минимального из трех чисел");
            Console.WriteLine();
            Console.WriteLine("Введите три числа");
            a = Console.ReadLine();
            b = Console.ReadLine();
            c = Console.ReadLine();
            double anum, bnum, cnum;
            while (!double.TryParse(a, out anum))
            {
                Console.WriteLine($"Введеное значение {a} не является числом. \n Введите число");
                a = Console.ReadLine();
            }
            anum = Convert.ToDouble(a);
            while (!double.TryParse(b, out bnum))
            {
                Console.WriteLine($"Введеное значение {b} не является числом. \n Введите число");
                b = Console.ReadLine();
            }
            bnum = Convert.ToDouble(b);
            while (!double.TryParse(c, out cnum))
            {
                Console.WriteLine($"Введеное значение {c} не является числом. \n Введите число");
                c = Console.ReadLine();
            }
            cnum = Convert.ToDouble(c);
            double min;

            if (anum < bnum)
            { min = anum; }
            else min = bnum;
            if (min > cnum)
            {
                min = cnum;
                Console.WriteLine($"{min} - наименьшее значение из {a}, {b}, {c}");
            }
            else Console.WriteLine($" {min} - наименьшее значение из {a}, {b}, {c}");

            Console.ReadKey();
        }
    }
}
