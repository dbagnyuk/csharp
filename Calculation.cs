using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleDigitInsert
{
    class Calculation
    {
        public static int Plus(int a, int b)
        {
            return a + b;
        }
        public static double Plus(double a, double b)
        {
            return a + b;
        }

        public static int Minus(int a, int b)
        {
            return a - b;
        }
        public static double Minus(double a, double b)
        {
            return a - b;
        }

        public static int Multiplication(int a, int b)
        {
            return a * b;
        }
        public static double Multiplication(double a, double b)
        {
            return a * b;
        }
        public static int Division(int a, int b)
        {
            return a / b;
        }
        public static double Division(double a, double b)
        {
            return a / b;
        }
        public static int MultiAction(int a, int b)
        {
            return Calculation.Division(Calculation.Minus(Calculation.Plus(a, b), Calculation.Minus(a, b)), Calculation.Multiplication(a, b));
        }
        public static double MultiAction(double a, double b)
        {
            return Calculation.Division(Calculation.Minus(Calculation.Plus(a, b), Calculation.Minus(a, b)), Calculation.Multiplication(a, b));
        }
    }
}