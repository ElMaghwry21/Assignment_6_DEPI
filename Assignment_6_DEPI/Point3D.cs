using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_6_DEPI
{
    class Point3D : IComparable, ICloneable
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        public Point3D() : this(0, 0, 0)
        {
        }

        public Point3D(int x, int y) : this(x, y, 0)
        {
        }

        public Point3D(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public override string ToString()
        {
            return $"Point Coordinates: ({X}, {Y}, {Z})";
        }

        public int CompareTo(object obj)
        {
            PointTPos(obj as Point3D, out Point3D p);
            if (p == null) return 1;

            if (this.X != p.X)
            {
                return this.X.CompareTo(p.X);
            }
            else if (this.Y != p.Y)
            {
                return this.Y.CompareTo(p.Y);
            }
            else
            {
                return this.Z.CompareTo(p.Z);
            }
        }

        private void PointTPos(Point3D other, out Point3D result)
        {
            result = other;
        }

        public object Clone()
        {
            return new Point3D(this.X, this.Y, this.Z);
        }
    }
}