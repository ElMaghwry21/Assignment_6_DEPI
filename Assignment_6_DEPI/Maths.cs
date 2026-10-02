using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_6_DEPI
{
    static class Maths
    {
        public static double Add(double a, double b)
        {
            return a + b;
        }

        public static double Subtract(double a, double b)
        {
            return a - b;
        }

        public static double Multiply(double a, double b)
        {
            return a * b;
        }

        public static double Divide(double a, double b)
        {
            if (b == 0)
            {
                System.Console.WriteLine("Error: Division by zero!");
                return 0;
            }
            return a / b;
        }
    }
}