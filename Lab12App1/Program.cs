using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12App1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Разработать статический класс для работы с окружностью.Класс должен содержать 3 метода:

            //метод, определяющий длину окружности по заданному радиусу;
            //метод, определяющий площадь круга по заданному радиусу;
            //метод, проверяющий принадлежность точки с координатами(x, y) кругу с радиусом r и координатами центра x0, y0.

            Console.WriteLine("Программа выдает данные об окружности:");
            Console.WriteLine("Длину окружности\nПлощадь круга\nИ принадлежность введенной точки с координатами x:y");
            Console.Write("Введите значение радиуса: r= ");
            double r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координаты центра (x0:y0)");
            Console.Write("Введите x0= ");
            double x0 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите y0= ");
            double y0 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координаты точки (x:y)");
            Console.Write("Введите x= ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите y= ");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            Сircle.CircumFerence(r);
            Сircle.AreaCircle(r);
            Сircle.InCircle(r, x0, y0, x, y);
            Console.ReadKey();
        }
        public static class Сircle
        {
            public static void CircumFerence(double r)
            {

                double L = 2 * r * Math.PI;
                Console.WriteLine($"Длина окружности = {L:f2}");
                return;
            }
            public static void AreaCircle(double r)
            {
                double S = (Math.PI * Math.Pow(r, 2));
                Console.WriteLine($"Площадь окружности = {S:f2}");
                return;
            }
            public static void InCircle(double r, double x0, double y0, double x, double y)
            {
                if (Math.Pow((x - x0), 2) + (Math.Pow((y - y0), 2)) <= Math.Pow(r, 2))
                {
                    Console.WriteLine("Точка (x:y) внутри круга с заданным радиусом");
                    return;
                }
                else
                {
                    Console.WriteLine("Точка (x:y) вне круга");
                    return;
                }

            }

        }
    }
}
