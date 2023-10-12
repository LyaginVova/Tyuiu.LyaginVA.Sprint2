using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.LyaginVA.Sprint2.Task6.V2.Lib
{
    public class DataService : ISprint2Task6V2
    {
        public string FindMonthSeason(int value)
        {
            switch(value)
            {
                case 1: return "Зима";
                case 2: return "Зима";
                case 3: return "Весна";
                case 4: return "Весна";
                case 5: return "Весна";
                case 6: return "Лето";
                case 7: return "Лето";
                case 8: return "Лето";
                case 9: return "Осень";
                case 10: return "Осень";
                case 11: return "Осень";
                case 12: return "Зима";
                default: throw new ArgumentException($"Месяц должен быть от 1 до 12. Значение {value}"); ;


            }
        }
    }
}
