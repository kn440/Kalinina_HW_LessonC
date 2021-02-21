//Калинина Н.А.
//3.а) Написать программу, которая подсчитывает расстояние между точками с координатами 
//x1, y1 и x2, y2 по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2 - y1, 2).
//Вывести результат, используя спецификатор формата .2f (с двумя знаками после запятой);
//б) *Выполнить предыдущее задание, оформив вычисления расстояния между точками в виде метода.

using System;

namespace _1._3_Task
{
    class Program
    {
        static void DistanceAB(double x1, double x2, double y1, double y2)
        {
            double r;
            r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine();
            Console.WriteLine($"Расстояние между точками с координатами ({x1},{x2}) и точкой ({y1},{y2}) равно = {r}");
            Console.WriteLine($"Округленно - {String.Format("{0:0.00}", r)}");
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            double x1, x2, y1, y2;
            x1 = x2 = y1 = y2 = 0;
            Console.WriteLine("Введите координаты первой точки");
            x1 = double.Parse(Console.ReadLine());
            x2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите координаты второй точки");
            y1 = double.Parse(Console.ReadLine());
            y2 = double.Parse(Console.ReadLine());
            DistanceAB(x1, x2, y1, y2);


        }
    }
}