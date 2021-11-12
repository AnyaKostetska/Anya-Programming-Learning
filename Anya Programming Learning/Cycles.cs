using System;

namespace Anya_Programming_Learning
{
    public class Cycles
    {
        public static double GetAToPowerB(double A, double B)
        {
            double count = 1;
            for (double i = 1; i <= B; i++)
        {
            count *= A; 
        }

            return count;
        }

        public static double GetADevidedNumbers (double A)
        {
            double count = 1;
            for (double i = 1; i <= 1000; i++)
            {
            if( i % A == 0)
            { 
            count++;
            }
        }

            return count;
        }
        public static int GetPositiveNumbers(int A)
        {
            int count = 1;
            for (int i = 1; i > 0; i++)
        {
            if (i*i < A)
            {
            count++;
            }
        }

            return count;
        //}
        //public static int GetGreatestDivisorOfA(int A) // TO BE DONE
        //{ }
        //public static int GetSumDevidedonSeven(int A, int B) // TO BE DONE
        //{
        //	int count = 1;
        //              for (int i = 0; i < length; i++)
        //          {

        //          }
    }
    public static GetFibonachiLine(int N)
    {
        int A = 0;
        int B = 1;
        for (int i = 1; i < N; i++)
        {
            int sum = A + B;
            A = B;
            B = sum;
        }

        return B;
    }
}
}
