using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.LyaginVA.Sprint2.Task6.V2.Lib;

namespace Tyuiu.LyaginVA.Sprint2.Task6.V2
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Лягин В. Л. | АСОиУБ-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Получение результата из switch                                    *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #2                                                              *");
            Console.WriteLine("* Выполнил: Лягин Владимир Александрович | АСОиУБ-23-2                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая использует сокращенную форму записи         *");
            Console.WriteLine("* оператора switch вычисляет   требуемое значение и возвращает результат. *");
            Console.WriteLine("* По данному месяцу, определите в какую пору года попадает этот месяц     *");
            Console.WriteLine("* (Зима, Лето, Весна, Осень).                                             *");
            Console.WriteLine("*                                                                         *");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите номер месяца: ");
            int numMonthSeason = Convert.ToInt32(Console.ReadLine());

            string res;

            if ((numMonthSeason < 1) || (numMonthSeason > 12))
            {
                res = "Введенно неверное значение!";
            }
            else
            {
                res = "Это пора года: " + ds.FindMonthSeason(numMonthSeason);
            }
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(res);

            Console.ReadKey();
        }
    }
}
