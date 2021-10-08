using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7._2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создать метод для вычисления объема и площади поверхности куба по длине его ребра.
            double c, area, volume;
            Console.WriteLine("Введите длину ребра куба");
            c = Convert.ToDouble(Console.ReadLine());            
            CalcCube(c, out area, out volume);
            Console.WriteLine("Площадь поверхности куба равна = {0}", area);
            Console.WriteLine("Объем куба равен = {0}", volume);
            Console.WriteLine("Для завершения нажмите любую клавишу");
            Console.ReadKey();
        }
        static void CalcCube(double c, out double area, out double volume)
        {            
            area = 6 * Math.Pow((c), 2);
            volume = Math.Pow((c), 3);                  
        }
    }
}
