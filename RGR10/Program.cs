using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace RGR10
{

    class Program
    {
        static bool first = true;
        static List<Vector3D> vectors = new List<Vector3D>();
        static void Main(string[] args)
        {
            do
            {
                if (!first) {
                Console.WriteLine("Нажмите любую клавишу для продолжения...");
                Console.ReadKey();
                Console.Clear();
                }
                first = false;
                Console.WriteLine("Векторы и операции над ними. Выберите пожалуйста вектор для операции.");
                int counter = 0;
                foreach (Vector3D vector in vectors)
                {
                    counter++;
                    Console.WriteLine("{3}. x:{0},y:{1},z:{2}", vector.x, vector.y, vector.z, counter);
                }
                Console.WriteLine("+. Добавить новый вектор");
                do
                {
                    Vector3D vector1;
                    Vector3D vector2;
                    string input = Console.ReadLine();
                    int vectorNum = -1;
                    Console.Clear();
                    if (int.TryParse(input, out vectorNum) && vectorNum-1>=0 && vectorNum <= vectors.Count)
                    {
                        vectorNum -= 1;
                        vector1 = vectors[vectorNum];
                        Console.WriteLine("Какие операции выполнить?");
                        Console.WriteLine("1.Сложить");
                        Console.WriteLine("2.Вычитать");
                        Console.WriteLine("3.Скалярное произведение");
                        Console.WriteLine("4.Векторное произведение");
                        Console.WriteLine("5.Длина вектора");
                        Console.WriteLine("6.Косинус угла между векторами");
                        int input2=ReadInt(1,6);
                        switch (input2)
                        {
                            case 1:
                                Console.WriteLine("Сложение");
                                vector2 = GetVector();
                                Console.WriteLine("Результат={0}", vector1 + vector2);
                                break;
                            case 2:
                                Console.WriteLine("Вычитание");
                                vector2 = GetVector();
                                     Console.WriteLine("Результат={0}", vector1 - vector2);
                                break;
                            case 3:
                                Console.WriteLine("Скалярное произведение");
                                vector2 = GetVector();
                                Console.WriteLine("Результат={0}", vector1*vector2);
                                break;
                            case 4:
                                Console.WriteLine("Векторное произведение");
                                vector2 = GetVector();
                                Vector3D vector3 = vector1 ^ vector2;
                                Console.WriteLine("Результат = X:{0} Y:{1} Z:{2}", vector3.x, vector3.y, vector3.z);
                                break;
                            case 5:
                                Console.WriteLine("Длина вектора={0}", vector1.Length());
                                break;
                            case 6:
                                Console.WriteLine("Косинус угла между векторами");
                                vector2 = GetVector();
                                Console.WriteLine("Результат={0}", vector1.AngleBetween(vector2));
                                break;

                        }
                        break;
                    }
                    else if (input == "+")
                    {
                        double x, y, z;
                        Console.WriteLine("Добавление вектора. Введите координату x:");
                        x = ReadDouble();
                        Console.WriteLine("Введите координату y:");
                        y = ReadDouble();
                        Console.WriteLine("Введите координату z:");
                        z = ReadDouble();
                        vectors.Add(new Vector3D(x, y, z));
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Некорректный ввод");
                        break;
                    }
                } while (true);
            } while (true);
        }

        static Vector3D GetVector()
        {
            int counter = 0;
            Console.WriteLine("Выберите вектор");
            foreach (Vector3D vector in vectors)
            {
                counter++;
                Console.WriteLine("{3}. x:{0},y:{1},z:{2}", vector.x, vector.y, vector.z, counter);
            }
            string input;
            int num = 0;
            do
            {
                input = Console.ReadLine();
            } while (!int.TryParse(input, out num) || num < 1 || num > vectors.Count);
            num -= 1;
            return vectors[num];
        }

        static double ReadDouble()
        {
            double result = 0;
            string input;
            do
            {
                Console.WriteLine("Введите число");
                input = Console.ReadLine();
            } while (!double.TryParse(input, out result));
            return result;
        }

        static int ReadInt(int min, int max)
        {
            int result = 0;
            string input;
            do
            {
                Console.WriteLine("Введите число");
                input = Console.ReadLine();
            } while (!int.TryParse(input, out result) || result<min || result>max);
            return result;
        }
    }
}
