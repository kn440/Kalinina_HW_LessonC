//Калинина Н.А.
//2.	а)  С клавиатуры вводятся числа, пока не будет введён 0 (каждое число в новой строке). 
//Требуется подсчитать сумму всех нечётных положительных чисел. 
//   Сами числа и сумму вывести на экран, используя tryParse.

using System;

namespace _3._2_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Sum();

            Console.ReadKey();
        }

        private static void Sum()
        {
            string a;
            int anum, sum;
            anum = 0;
            sum = 0;
            Console.WriteLine("Сумма всех нечетных положительных чисел. \nВведите целые числа (для прекращения вода нажмите 0)");
            Console.WriteLine();
            a = Console.ReadLine();
            while (a != "0")
            {
                while (!Int32.TryParse(a, out anum))
                {
                    Console.WriteLine($"Введеное значение {a} не является числом. \n Введите число");
                    a = Console.ReadLine();
                }
                anum = Convert.ToInt32(a);
                if (anum % 2 != 0 && anum > 0)
                { sum = sum + anum; }
                if (a == "0")
                { break; }
                a = Console.ReadLine();

            }
            Console.WriteLine();
            Console.WriteLine($"Ввод завершен.Сумма всех нечетных положительных чисел равна {sum}");
        }
    }
}
