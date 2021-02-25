//Калинина Н.А.
//2.Написать метод подсчета количества цифр числа.

using System;

namespace _2._2_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            string a;
            Console.WriteLine("Подсчет количества цифр числа");
            Console.WriteLine();
            Console.WriteLine("Введите целое число");
            a = Console.ReadLine();
            int anum;

            while (!int.TryParse(a, out anum))
            {
                Console.WriteLine($"Введеное значение {a} не является целым числом. \nВведите целое число");
                a = Console.ReadLine();
                if (a.Substring(0, 1) == " ")
                {
                    Console.WriteLine($"Введеное значение без пробелов");
                    a = Console.ReadLine();
                }
            }

            anum = a.Length;

            if (a.Substring(0, 1) == "0")
            {
                anum = a.Length - 1;
            }



            Console.WriteLine($"Вы ввели число {a}, оно состоит из {anum} чисел");
            Console.ReadKey();


        }
    }
}
