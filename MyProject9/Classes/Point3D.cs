using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject9.Classes
{
    class Point3D : Point2D<int>
    {
        public int Z { get; set; }

        public Point3D(int X, int Y, int Z) : base(X,Y)
        {
            this.Z = Z;
        }

        public Point3D() : base()
        {
            this.Z = default;
        }

        public override string ToString()
        {
            return $"Z:{this.Z}, X: {this.X}, Y:{this.Y};";
        }
    }
}
