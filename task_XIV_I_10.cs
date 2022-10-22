using System;
using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Task
{
    class Program
    {
        public struct Point3
        {
            public int x, y, z;
            public Point3(int x, int y, int z)
            {
                this.x = x;
                this.y = y;
                this.z = z;
            }
            public void Show()
            {
                Console.Write("({0}, {1}, {2})", x, y, z);
            }
        }
        public struct Point
        {
            public int x, y;
            public Point(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
            public void Show()
            {
                Console.WriteLine("({0}, {1})", x, y);
            }
        }

        public static double dist3(Point3 a, Point3 b)
        {
            return Math.Sqrt((b.x - a.x) * (b.x - a.x) + (b.y - a.y) * (b.y - a.y) + (b.z - a.z) * (b.z - a.z));
        }
        public static double dist(Point a, Point b)
        {
            return Math.Sqrt((b.x - a.x) * (b.x - a.x) + (b.y - a.y) * (b.y - a.y));
        }

        public struct OXY
        {
            public static StringBuilder[] o = new StringBuilder[] { new StringBuilder("___________"),
                                                                    new StringBuilder("|.........."),
                                                                    new StringBuilder("|.........."),
                                                                    new StringBuilder("|.........."),
                                                                    new StringBuilder("|.........."),
                                                                    new StringBuilder("|.........."),
                                                                    new StringBuilder("|.........."),
                                                                    new StringBuilder("|.........."),
                                                                    new StringBuilder("|.........."),
                                                                    new StringBuilder("|.........."),
                                                                    new StringBuilder("|..........") };

            public void set(Point A, char c)
            {
                o[A.y][A.x] = c;
            }
            public void Show()
            {
                for (int i = o.Length-1; i >= 0; i--)
                {
                    Console.WriteLine(o[i]);
                }
            }
        }
        static void Main(string[] args)
        {
            //OXY pole = new OXY();

            List<Point3> mass = new List<Point3> { new Point3(1, 1, 1),
                                                   new Point3(2, 3, 4), 
                                                   new Point3(2, 1, 3),
                                                   new Point3(2, 4, 1),
                                                   new Point3(5, 5, 2),
                                                   new Point3(3, 1, 1),
                                                   new Point3(3, 3, 3) };

           //{
           //     pole.set(new Point(2, 2), 'A');
           //     pole.set(new Point(3, 8), 'B');
           //     pole.set(new Point(6, 5), 'C');
           //     pole.set(new Point(8, 9), 'D');
           //     pole.set(new Point(9, 3), 'E');
           //     pole.set(new Point(10, 8), 'F');
           //     pole.Show();
           // }

            int r = 3, k, maxk = 0, ik = 0;

            for (int i = 0; i < mass.Count; i++)
            {
                k = 0;

                for (int j = 0; j < mass.Count; j++)
                    if (dist3(mass[i], mass[j]) <= r)
                        k++;

                if (k > maxk)
                {
                    maxk = k;
                    ik = i;
                }
                mass[i].Show();
                Console.WriteLine(" = " + k);
            }

            Console.WriteLine("answer:");
            mass[ik].Show();
        }
    }
}
