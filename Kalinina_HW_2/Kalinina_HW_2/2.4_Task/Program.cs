//Калинина Н.А.
//4.	Реализовать метод проверки логина и пароля. На вход метода подается логин и пароль. 
//На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password:  ). 
//  Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, 
//программа пропускает его дальше или не пропускает. С помощью цикла do while ограничить ввод пароля тремя попытками.

using System;

namespace _2._4_Task
{
    class Program
    {
        static bool CheckPassword(string a, string b)
        {
            bool d = false;
            if (a == "root" && b == "GeekBrains")
            {
                d = true;
            }

            return d;

        }
        static void Main(string[] args)
        {
            string a, b;
            int count = 0;
            do
            {
                count = count + 1;
                Console.WriteLine("Введите логин и пароль");
                Console.WriteLine("логин:");
                a = Console.ReadLine();
                Console.WriteLine("пароль:");
                b = Console.ReadLine();

            }
            while (CheckPassword(a, b) != true && count != 3);
            {

            }

            if (CheckPassword(a, b) == true)
            {
                Console.WriteLine("Ваш логин или пароль принят");
                Console.ReadKey();
            }
            if (count == 3)
            {
                Console.WriteLine("Вы ввели 3 раза ошибочно логин и пароль");
            }


        }
    }
}
