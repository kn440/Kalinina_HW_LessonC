//Калинина Н.А.
//3.	С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.

using System;

namespace _2._3_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            string a;
            int anum, sum;
            anum = 0;
            sum = 0;
            Console.WriteLine("Сумма всех нечетных положительных чисел. \nдля прекращения вода нажмите 0");
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

            Console.ReadKey();




        }
    }
}
