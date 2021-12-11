using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VS20._1._1
{
    class Program
    {
        delegate double MyDelegate(double radius);
        static void Main(string[] args)
        {
            Console.WriteLine("Ввести значение радиуса");
            double radius = Convert.ToDouble(Console.ReadLine());
            MyDelegate myDelegate = LengtMethod;
            if (myDelegate != null)
            {
                double r = myDelegate(radius);
                Console.WriteLine("{0:N}", r);
            }
            MyDelegate myDelegate1 = SquarMethod;
            if (myDelegate1 != null)
            {
                double r = myDelegate1(radius);
                Console.WriteLine("{0:N}", r);
            }
            MyDelegate myDelegate2 = VolumeMethod;
            if (myDelegate2 != null)
            {
                double r = myDelegate2(radius);
                Console.WriteLine("{0:N}", r);
            }
            Console.ReadKey();
        }
        //метод, определяющий длину окружности по заданному радиусу;
        static double LengtMethod(double radius)
        {
            Console.WriteLine("метод, определяет длину окружности по заданному радиусу");
            double lengthСircle = 2 * Math.PI * radius;
            return lengthСircle;
        }
        //метод, определяющий площадь круга по заданному радиусу;
        static double SquarMethod(double radius)
        {
            Console.WriteLine("метод, определяут площадь круга по заданному радиусу");
            double square = Math.PI * Math.Pow(radius, 2);
            return square;
        }
        //метод, определяющий объем шара
        static double VolumeMethod(double radius)
        {
            Console.WriteLine("метод, определяет объем шара по заданному радиусу");
            double volume = Math.PI * Math.Pow(radius, 3) * 4 / 3;
            return volume;
        }
    }

}
