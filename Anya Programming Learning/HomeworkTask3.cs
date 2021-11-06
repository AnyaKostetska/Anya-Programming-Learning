using System;
namespace Anya_Programming_Learning
{
    public class HomeworkTask3
    {
        public static double Task1(double A, double B)
        {
            double result;
            if (A > B)
            {
                result = A + B;
            }
            else if (A == B)
            {
                result = A * B;
            }
            else if (A < B)
            {
                result = A - B;
            }
            return result;
        }
        public static int Task2(int X, int Y)
        {
            int result;
            if (X > 0 & Y > 0)
            {
                result = 1;
            }
            else if (X < 0 & Y > 0)
            {
                result = 2;
            }
            else if (X < 0 & Y < 0)
            {
                result = 3;
            }
            else if (X > 0 & Y < 0)
            {
                result = 4;
            }
            return result;

            //public static int Task3()
            //{
            //TO BE EDITED
            //}
            static (double X1, double X2) Task4(double a, double b, double c)
            {//null
               double d = b * b - 4 * a * c;
                if (d == 0)//one root
                {
                    double x = -b / (2 * a);

                    return (x, x);
                }
                else if (d > 0)
                {
                    double X1 = (-b + Math.Sqrt(d)) / (2 * a);
                    double X2 = (-b - Math.Sqrt(d)) / (2 * a);

                    return (X1, X2);
                }
                else
                {
                    return (null, null);
                }
            }
            //TASK 5 TO BE EDITED
        }
    }
}
