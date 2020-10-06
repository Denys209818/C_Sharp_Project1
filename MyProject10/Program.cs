using MyProject10.Classes;
using System;

namespace MyProject10
{
//    Создать обобщенный класс прямой на плоскости.В
//классе предусмотреть 2 поля типа обобщенной точки —
//точки, через которые проходит прямая. Реализовать
//в классе:
//■ конструктор, который принимает 2 точки
//■ конструктор, которые принимает 4 координаты (x и у
//координаты для первой и второй точки)
//■ метод ToString()
    class Program
    {
        static void Main()
        {
            //1. Випадок
            Point<int,double> p1 = new Point<int, double>(2,4.1);
            Point<int, double> p2 = new Point<int, double>(-2, -4.8);

            Line<int,double> line = new Line<int,double>(p1, p2);

            Console.WriteLine(line);
            Console.WriteLine("\n***\n");
            //2. Випадок
            Line<int, int> line2 = new Line<int, int>(2,5,3,6);

            Console.WriteLine(line2);
        }
    }
}
