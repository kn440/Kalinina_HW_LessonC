//Калинина Н.А.
//1.Написать программу «Анкета». Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес). 
//В результате вся информация выводится в одну строчку:
//а) используя склеивание;
//б) используя форматированный вывод;
//в) используя вывод со знаком $.

using System;

namespace _1._1_Task
{
    class Program
    {

        static void Anketa()
        {
            Console.WriteLine("Программа Анкета");
            Console.WriteLine();
            Console.WriteLine("Введите имя");
            string Name = Console.ReadLine();
            Console.WriteLine("Введите фамилию");
            string SurName = Console.ReadLine();
            Console.WriteLine("Введите возраст");
            string Age = Console.ReadLine();

            Console.WriteLine("Введите рост");
            string Heigth = Console.ReadLine();

            Console.WriteLine("Введите вес");
            string Wigth = Console.ReadLine();

            //а) используя склеивание;
            Console.WriteLine();
            Console.WriteLine("а) используя склеивание");
            Console.WriteLine("Добрый день, уважаемый(aя) " + Name + " " + SurName + ", \nВы ввели: возраст - " + Age + " лет, рост - " + Heigth + " и вес - " + Wigth + ".");
            Console.WriteLine();
            Console.ReadKey();
            //в) используя вывод со знаком $.
            Console.WriteLine("в) используя вывод со знаком $");
            Console.WriteLine($"Добрый день, уважаемый(aя) {Name}  {SurName},  \nВы ввели: возраст - {Age} лет, рост - {Heigth} и вес - {Wigth}.");
            Console.ReadKey();

            //б) используя форматированный вывод;
            Console.Clear();
            Console.WriteLine("б) используя форматированный вывод");
            var box1 = "Добрый день, уважаемый(aя) " + Name + " " + SurName + "!";
            var box2 = "Вы ввели:";

            Console.SetCursorPosition((Console.WindowWidth - box1.Length) / 5, 5);
            Console.WriteLine(box1);
            Console.SetCursorPosition((Console.WindowWidth - box1.Length) / 5, 7);
            Console.WriteLine(box2);
            Console.SetCursorPosition((Console.WindowWidth - box1.Length) / 5, 8);
            Console.WriteLine($"\tвозраст - {Age}");
            Console.SetCursorPosition((Console.WindowWidth - box1.Length) / 5, 9);
            Console.WriteLine($"\tрост - {Heigth}");
            Console.SetCursorPosition((Console.WindowWidth - box1.Length) / 5, 10);
            Console.WriteLine($"\tвес - {Wigth}");
            Console.WriteLine();


            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            Anketa();
        }
    }
}
