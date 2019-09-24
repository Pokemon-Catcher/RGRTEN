using System;

namespace RGR10
{
    class Vector2D : Vector1D
    {
        public double y = 0;

        public Vector2D(double x = 0, double y = 0)
        {
            this.x = x;
            this.y = y;
        }

        public static Vector2D operator +(Vector2D vector1, Vector2D vector2)
        {
            return new Vector2D(vector1.x + vector2.x, vector1.y + vector2.y);
        }
        public static Vector2D operator -(Vector2D vector1, Vector2D vector2)
        {
            return new Vector2D(vector1.x - vector2.x, vector1.y - vector2.y);
        }
        public static double operator *(Vector2D vector1, Vector2D vector2)
        {
            return vector1.x * vector2.x + vector1.y * vector2.y;
        }

        public new double Length()
        {
            return Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
        }

        public double AngleBetween(Vector2D vector2)
        {
            return (this * vector2) / (this.Length() * vector2.Length());
        }

        public override string ToString()
        {
            return string.Format("X:{0} Y:{1}", x, y);
        }
    }
}
