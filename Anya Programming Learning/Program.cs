using System;

namespace Anya_Programming_Learning
{
    class Program
    {
        static void Main(string[] args)
        {
            Task1();
            Task2();
            Task3();
            Task4();
            Task5();
        }

        static void Task1()
        {
            //Value A
            Console.Write($"Enter Value A ");
            string userInput1 = Console.ReadLine();
            int valueA = Convert.ToInt32(userInput1);
            Console.WriteLine($"A = {valueA}");

            //Value B
            Console.Write($"Enter Value B ");
            string userInput2 = Console.ReadLine();
            int valueB = Convert.ToInt32(userInput2);
            Console.WriteLine($"B = {valueB}");

            double result = ((5 * valueA) + (valueB * valueB)) / (valueB - valueA);

            Console.WriteLine($"Result:{result}");

            Console.ReadKey();
        }

        static void Task2()
        {
            Console.Write($"Enter A ");
            string userInput1 = Console.ReadLine();

            Console.Write($"Enter B ");
            string userInput2 = Console.ReadLine();

            Console.WriteLine($"A = {userInput2}");
            Console.WriteLine($"B = {userInput1}");

            Console.ReadKey();
        }

        static void Task3()
        {
            //Value A
            Console.Write($"Enter A ");
            string userInput1 = Console.ReadLine();
            int valueA = Convert.ToInt32(userInput1);
            Console.WriteLine($"A = {valueA}");
            //Value B
            Console.Write($"Enter B ");
            string userInput2 = Console.ReadLine();
            int valueB = Convert.ToInt32(userInput2);
            Console.WriteLine($"B = {valueB}");

            int result1 = valueA / valueB;
            int result2 = valueA % valueB;

            Console.WriteLine($"Result A/B:{result1}");
            Console.WriteLine($"Result module:{result2}");
        }

        //TO BE EDITED
        static void Task4()
        {
            //A* X+B = C.
            Console.Write($"Enter Value A ");
            string userInput1 = Console.ReadLine();
            int valueA = Convert.ToInt32(userInput1);

            Console.Write($"Enter Value B ");
            string userInput2 = Console.ReadLine();
            int valueB = Convert.ToInt32(userInput2);

            Console.Write($"Enter Value C ");
            string userInput3 = Console.ReadLine();
            int valueC = Convert.ToInt32(userInput3);

            Console.WriteLine($"X = {(valueC - valueB) / valueA}");
        }
        static void Task5()
        {
            //X1 Y1
            Console.WriteLine($"Insert X1 number");
            string inputX1 = Console.ReadLine();
            double X1 = Convert.ToDouble(inputX1);

            Console.WriteLine($"Insert Y1 number");
            string inputY1 = Console.ReadLine();
            double Y1 = Convert.ToDouble(inputY1);
            //X2 Y2
            Console.WriteLine($"Insert X2 number");
            string inputX2 = Console.ReadLine();
            double X2 = Convert.ToDouble(inputX2);

            Console.WriteLine($"Insert Y2 number");
            string inputY2 = Console.ReadLine();
            double Y2 = Convert.ToDouble(inputY2);

            double A = (Y1 - Y2) / (X1 - X2);
            Console.WriteLine($"A = " + A);

            double B = Y2 - A * X2;
            Console.WriteLine($"B= " + B);
        }
    }
}

