using MyProject9.Classes;
using System;

namespace MyProject9
{
//    Создать необобщенный класс точки в трехмерном
//пространстве с целочисленными координатами(Point3D),
//который наследуется от generic-класса Point2D<T>, рассмотренного в уроке.Реализовать в классе:
//■ конструктор с параметрами, который принимает начальные значения для координат точки
//■ метод ToString()
    class Program
    {
        static void Main()
        {
            Console.WriteLine("*Point*");
            Point3D point = new Point3D(2,4,1);
            Console.WriteLine(point);

        }
    }
}
