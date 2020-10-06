using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject9.Classes
{
    //Клас з лекції
    public class Point2D<T>
    {
        public T X { get; set; }
        public T Y { get; set; }
        public Point2D(T x, T y)
        {
            X = x;
            Y = y;
        }

        public Point2D()
        {
            X = default(T);
            Y = default(T);
        }
    }
    }
