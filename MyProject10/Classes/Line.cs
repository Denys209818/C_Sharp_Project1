using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject10.Classes
{
    class Line<T, U>
    {
        Point<T, U> point1;
        Point<T, U> point2;

        public Line(Point<T, U> p1, Point<T, U>p2)
        {
            this.point1 = p1;
            this.point2 = p2;
        }
        public Line(T x1, U y1, T x2, U y2)
        {
            this.point1 = new Point<T, U>(x1,y1);
            this.point2 = new Point<T, U>(x2, y2);
        }

        public override string ToString()
        {
            return $"Point 1: X:{this.point1.x}, Y:{this.point1.y}\nPoint 2: X:{this.point2.x}, Y:{this.point2.y}";
        }
    }

    struct Point<T, U> 
    {
        public T x;
        public U y;

        public Point(T x, U y)
        {
            this.x = x;
            this.y = y;
        }
    }
}
