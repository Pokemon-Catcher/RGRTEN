using System;

namespace RGR10
{
    public class Vector1D
    {
        public double x = 0;

        public Vector1D(double x = 0)
        {
            this.x = x;
        }

        public static Vector1D operator +(Vector1D vector1, Vector1D vector2)
        {
            return new Vector1D(vector1.x + vector2.x);
        }
        public static Vector1D operator -(Vector1D vector1, Vector1D vector2)
        {
            return new Vector1D(vector1.x - vector2.x);
        }
        public static double operator *(Vector1D vector1, Vector1D vector2)
        {
            return vector1.x * vector2.x;
        }

        public virtual double Length()
        {
            return Math.Abs(x);
        }

        public override string ToString()
        {
            return string.Format("X:{0}", x);
        }
    }
}
