// Калинина Н.А.
//1.а) Дописать структуру Complex, добавив метод вычитания комплексных чисел. Продемонстрировать работу структуры.
//б) Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса.
//в) Добавить диалог с использованием switch демонстрирующий работу класса.




using System;

namespace _3._1_Task
{
    struct Complex
    {
        public double im;
        public double re;

        public Complex Plus(Complex x)
        {
            Complex y;
            y.im = im + x.im;
            y.re = re + x.re;
            return y;
        }


        public Complex Minus(Complex x)
        {
            Complex y;
            y.im = im - x.im;
            y.re = re - x.re;
            return y;
        }
        //  Пример произведения двух комплексных чисел
        public Complex Multi(Complex x)
        {
            Complex y;
            y.im = re * x.im + im * x.re;
            y.re = re * x.re - im * x.im;
            return y;
        }
        public override string ToString()
        {
            if (im > 0)
            {
                return re + "+" + im + "i";
            }
            else
            { return re + "" + im + "i"; };
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Complex complex1;
            complex1.re = 1;
            complex1.im = -1;

            Complex complex2;
            complex2.re = 2;
            complex2.im = 2;

            Console.WriteLine("Дано 2 комплексных числа:");

            Console.WriteLine(complex1.ToString());
            Console.WriteLine(complex2.ToString());

            Console.WriteLine();
            Console.WriteLine("Результат сложения:");
            Complex result = complex1.Plus(complex2);
            Console.WriteLine(result.ToString());

            Console.WriteLine();
            Console.WriteLine("Результат умножения:");
            result = complex1.Multi(complex2);
            Console.WriteLine(result.ToString());

            Console.WriteLine();
            Console.WriteLine("Результат вычитания:");
            result = complex1.Minus(complex2);
            Console.WriteLine(result.ToString());

            Console.WriteLine(@"Введите знаки арифметических операций:
+ для сложения 2 комплексных чисел
- для вычитания 2 комплексных чисел
* для умножения 2 комплексных чисел");

            switch (Console.ReadLine())
            {
                case "+":
                    Console.WriteLine($"Результат операции сложения {complex1.Plus(complex2)} "); break;
                case "-":
                    Console.WriteLine($"Результат операции вычитания {complex1.Minus(complex2)}"); break;
                case "*":
                    Console.WriteLine($"Результат операции умножения {complex1.Multi(complex2)}"); break;
                default: Console.WriteLine("Знак арифметической операции неопознан"); break;
            }
        }


    }
}
