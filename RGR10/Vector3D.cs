using System;

namespace RGR10
{
    public class Vector3D : Vector2D
    {
        public double z = 0;
        
        public Vector3D(double x =0, double y =0, double z =0)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public static Vector3D operator +(Vector3D vector1, Vector3D vector2){
            return new Vector3D(vector1.x+vector2.x,vector1.y+vector2.y,vector1.z+vector2.z);
            }
        public static Vector3D operator -(Vector3D vector1, Vector3D vector2)
        {
            return new Vector3D(vector1.x - vector2.x, vector1.y - vector2.y, vector1.z - vector2.z);
        }
        public static double operator *(Vector3D vector1, Vector3D vector2)
        {
            return vector1.x * vector2.x + vector1.y * vector2.y + vector1.z * vector2.z;
        }
        public static Vector3D operator ^(Vector3D vector1, Vector3D vector2)
        {
            Vector3D vector3 = new Vector3D(vector1.y * vector2.z - vector1.z * vector2.y, vector1.z * vector2.x - vector1.x * vector2.z, vector1.x * vector2.y - vector1.y * vector2.x);
            return vector3;
        }
        public override double Length()
        {
            return Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2) + Math.Pow(z, 2));
        }

        public double AngleBetween(Vector3D vector2)
        {
            return (this * vector2) / (Length() * vector2.Length());
        }

        public override string ToString()
        {
            return string.Format("X:{0} Y:{1} Z:{2}", x, y, z);
        }
    }
}
