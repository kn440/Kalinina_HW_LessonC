//Калинина Н.А.
//5.а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
//б) *Сделать задание, только вывод организовать в центре экрана.
//в) **Сделать задание б с использованием собственных методов (например, Print(string ms, int x, int y).

using System;

namespace _1._5_Task
{
    class Program
    {
        static void PrintCentre(string d, int l)
        {
            Console.SetCursorPosition((Console.WindowWidth - l) / 2, Console.WindowHeight / 2);
            Console.WriteLine(d);
        }
        static void Main(string[] args)
        {
            string a, b, c, d;
            Console.WriteLine("Введите имя, фамилию и город проживания");
            a = Console.ReadLine();
            b = Console.ReadLine();
            c = Console.ReadLine();
            d = a + " " + b + ", " + "город " + c;
            int l = d.Length;

            PrintCentre(d, l);
            Console.ReadKey();
        }
    }
}
