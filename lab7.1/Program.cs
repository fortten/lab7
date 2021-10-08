using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7._1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Два треугольника заданы длинами сторон. Определить, площадь какого из них больше. Использовать метод.
            #region Инициализация переменных
            double a1, b1, c1, a2, b2, c2;
            Console.WriteLine("Введите стороны первого треугольника");
            a1 = Convert.ToDouble(Console.ReadLine());
            b1 = Convert.ToDouble(Console.ReadLine());
            c1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите стороны второго треугольника");
            a2 = Convert.ToDouble(Console.ReadLine());
            b2 = Convert.ToDouble(Console.ReadLine());
            c2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            #endregion
            if ((CalcArea(a1, b1, c1)) > (CalcArea(a2, b2, c2)))
            {
                Console.WriteLine("Площадь первого треугольника больше");
            }
            else
            {
                Console.WriteLine("Площадь второго треугольника больше");
            }
            Console.WriteLine("Для завершения нажмите любую клавишу");
            Console.ReadKey();
        }
        static double CalcArea(double a, double b, double c)
        {
            double p, S;
            p = (a + b + c) / 2; // Полупериметр
            S = Math.Round(Math.Sqrt(p * (p - a) * (p - b) * (p - c)), 2); // Площадь треугольника
            return S;
        }
    }
}
