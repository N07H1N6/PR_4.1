//**********************************************************
//*Практическая работа №4                                  *   
//* Выполнил: Кондаков.П.А.,группа 2ИСП                    *
//* Задание: составить программу работы линецного алгоритма*
//**********************************************************

using System;
using System.Runtime.InteropServices;

namespace PR_4
{
    class Program
    {
        static void Main(string[] args)// точка входа в программу
        {
            Console.Title = "Практическая работа № 4"; // Заголовок консоли

            double b, c, m, t, y; // обьявление переменных
            double v1, v2, v3, v4, v5, v6, v7, v8, v9, v10,v11;

            Console.WriteLine("Здравствуйте");
            Console.Write("Введите b = ");
             b= Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите c = ");
            c = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите m = ");
            m = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите t = ");
            t = Convert.ToDouble(Console.ReadLine());

            // расчет значения выражения
            v1 = Math.Log(m,2);
            Console.WriteLine("v1 = {0}", v1);
            v2 = Math.Pow((b * t), 2);
            Console.WriteLine("v2 = {0}", v2);
            v3 = Math.Cos(v2);
            Console.WriteLine("v3 = {0}", v3);
            v4 = Math.Exp(t+c);
            Console.WriteLine("v4 = {0}", v4);
            v5 = v1 * v3;
            Console.WriteLine("v5 = {0}", v5);
            v6 = v5 * v4;
            Console.WriteLine("v6 = {0}", v6);
            v7 = Math.Tan(b);
            Console.WriteLine("v7 = {0}", v7);
            v8 = m * v7;
            Console.WriteLine("v8 = {0}", v8);
            v9 = Math.Pow(Math.Sin(t), 2);
            Console.WriteLine("v9 = {0}", v9);
            v10 = c * v9;
            Console.WriteLine("v10 = {0}", v10);
            v11 = v8 + v10;
            Console.WriteLine("v11 = {0}", v11);

            y = v6 / v11;
    

            Console.WriteLine("Результат: y = {0}" , y);
            Console.ReadKey();
           



        }
    }
}
