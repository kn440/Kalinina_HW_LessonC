//Калинина Н.А.
//4.Написать программу обмена значениями двух переменных:
//а) с использованием третьей переменной;
//б) *без использования третьей переменной.


using System;

namespace _1._4_Task
{
    class Program
    {
        static void ChangeVar()
        {
            string a, b, c;
            //а) с использованием третьей переменной;
            Console.WriteLine("Замена с использованием третьей переменной");
            Console.WriteLine("Введите первое значение");
            a = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Введите второе значение");
            b = Console.ReadLine();
            Console.WriteLine($"Вы ввели {a} и {b}");
            Console.WriteLine();
            Console.WriteLine($"Нажмите любую клавишу для замены переменных");
            Console.ReadKey();

            c = a;
            a = b;
            b = c;
            Console.WriteLine();
            Console.WriteLine($"Результат: {a} и {b}");
            Console.ReadKey();

            Console.Clear();
            //б) *без использования третьей переменной.
            Console.WriteLine("Замена без использования третьей переменной");
            int l1, l2;
            Console.WriteLine("Введите первое значение");
            a = Console.ReadLine();
            l1 = a.Length;
            Console.WriteLine();
            Console.WriteLine("Введите второе значение");
            a = a + " и " + Console.ReadLine();
            l2 = a.Length;
            Console.WriteLine($"Вы ввели {a} ");
            Console.WriteLine();
            Console.WriteLine($"Нажмите любую клавишу для замены переменных");
            Console.ReadKey();
            b = a;
            a = b.Substring(l1 + 3);

            b = b.Substring(0, l1);
            Console.WriteLine($"Результат {a} и {b}");

            Console.ReadKey();


        }
        static void Main(string[] args)
        {
            ChangeVar();
        }
    }
}
