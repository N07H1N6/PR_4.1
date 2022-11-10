//**********************************************************
//*Практическая работа №4                                  *   
//* Выполнил: Кондаков.П.А.,группа 2ИСП                    *
//* Задание: составить программу работы линецного алгоритма*
//**********************************************************

using System;

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
            Console.Write("Введите b = ");//ввод исходнх данных
             b= Convert.ToDouble(Console.ReadLine());//явное приведение к типу double
            Console.Write("Введите c = ");
            c = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите m = ");
            m = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите t = ");
            t = Convert.ToDouble(Console.ReadLine());

            // расчет значения выражения
            v1 = Math.Log(m,2);//логорифм
            v2 = Math.Pow(b * t, 2);// возведение в степень
            v3 = Math.Cos(v2);//косинус
            v4 = Math.Exp(t+c);//экспонента
            v5 = v1 * v3;//умножение
            v6 = v5 * v4;
            v7 = Math.Tan(b);//тангенс
            v8 = m * v7;
            v9 = Math.Pow(Math.Sin(t), 2);//возведение в степень
            v10 = c * v9;
            v11 = v8 + v10;

            y = v6 / v11;

            //вывод результата на экран
            Console.WriteLine("Результат: y = {0: 0.#####}",y);
            Console.ReadKey();// задержка экрана консоли
           



        }
    }
}
