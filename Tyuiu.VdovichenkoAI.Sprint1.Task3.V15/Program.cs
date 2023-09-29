using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.VdovichenkoAI.Sprint1.Task3.V15.Lib;

namespace Tyuiu.VdovichenkoAI.Sprint1.Task3.V15
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнила: Вдовиченко А.И. | ИИПб-23-1";
            // Длинна строки 75 символов
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Операторы составного присваивания                                 *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #15                                                             *");
            Console.WriteLine("* Выполнила: Вдовиченко А.И. | ИИПб-23-1                                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, решающую следующую задачу:                          *");
            Console.WriteLine("* два автомобиля имеют скорости V1 км/ч и V2 км/ч соответственно,         *");
            Console.WriteLine("* находятся на расстоянии S км друг от друга                              *");
            Console.WriteLine("* и движутся в противоположные стороны.                                   *");
            Console.WriteLine("* Определить расстояние между ними через T часов.                         *");
            Console.WriteLine("*                                                                          ");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         ");
            Console.WriteLine("***************************************************************************");

            double v1;
            double v2;
            double S;
            double T;
            Console.WriteLine("Первый автомобиль имеет скорость: v1 = ");
            v1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Второй автомобиль имеет скорость: v2 = ");
            v2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Расстояние: S = ");
            S = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Время: T = ");
            T = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               ");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Расстояние между автомобилями равно:" + ds.DistanceOverTime(v1, v2, S, T));
            Console.ReadKey();

        }
    }
}
