//Калинина Н.А.
//2.Ввести вес и рост человека. 
// Рассчитать и вывести индекс массы тела (ИМТ) по формуле I=m/(h*h); где m — масса тела в килограммах, h — рост в метрах

using System;

namespace _1._2_Task
{
    class Program
    {
        static void IMT()
        {
            string weightS;
            string heightS;
            Console.WriteLine("Для рассчета индекса массы введите Ваш вес (в кг): ");
            weightS = Console.ReadLine();
            Console.WriteLine("введите Ваш рост (в метрах): ");
            heightS = Console.ReadLine();
            double m = Convert.ToDouble(weightS);
            double h = Convert.ToDouble(heightS);
            double Index = m / (h * h);

            Console.WriteLine();
            Console.WriteLine($"Ваши данные: вес {m}кг., рост {h}м.\nИндекс массы тела - {String.Format("{0:0.00}", Index)}");
            }
        static void Main(string[] args)
        {
            IMT();
            Console.ReadKey();
        }
    }
}
