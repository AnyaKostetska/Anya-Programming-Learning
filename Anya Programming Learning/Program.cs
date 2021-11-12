using System;

namespace Anya_Programming_Learning
{
    public class Program
    {
        static void Main ()
        {
            Console.WriteLine(Cycles.GetAToPowerB(5,5));
        }

        public static double Task1(int A, int B)
        {
            return ((5 * A) + (B * B)) / (B - A);
        }

            public static void Task2(ref string A, ref string B)
        {
            string temp = A;
            A = B;
            B = temp;
        }

            public static (int division, int reminder) Task3(int A, int B)
        {
            return (A / B, A % B);
        }

            public static double Task4(double A, double B, double C)
        {
            return (C - B) / A;
        }

            public static (double A, double B) Task5(double X1, double Y1, double X2, double Y2)
        {
            double A = (Y1 - Y2) / (X1 - X2);
            double B = Y2 - A * X2;
            return (A, B);
        }
    }
 }
