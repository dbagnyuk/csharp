//#define FIRST
#define SECOND

using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.Globalization;

namespace ConsoleDigitInsert
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo pressedKey;

            do
            {
                Console.Clear(); // clearing the console
#if FIRST
                double a;
                do
                {
                    Console.Write("enter a = ");
                    if (!double.TryParse(Console.ReadLine(), out a))
                    {
                        Console.WriteLine("wrong input format");
                        Thread.Sleep(1000);
                        Console.Clear();
                    }
                    else break;
                }
                while (true);

                double b;
                do
                {
                    Console.Write("enter b = ");
                    if (!double.TryParse(Console.ReadLine(), out b))
                    {
                        Console.WriteLine("wrong input format");
                        Thread.Sleep(1000);
                        Console.Clear();
                        Console.WriteLine("enter a = " + a);
                    }
                    else break;
                }
                while (true);
#endif
#if SECOND
                Console.Write("enter a = ");
                double a = insertDigitControl.processingInput();
                Console.WriteLine("enter a = " + a);
                Console.Write("enter b = ");
                double b = insertDigitControl.processingInput();
#endif
                Console.WriteLine("When:");
                Console.WriteLine("a = " + a);
                Console.WriteLine("b = " + b);

                Console.WriteLine("Then:");
                Console.WriteLine("c = a + b = " + Calculation.Plus(a, b));
                Console.WriteLine("c = a - b = " + Calculation.Minus(a, b));
                Console.WriteLine("c = a * b = " + Calculation.Multiplication(a, b));

                if (b == 0)
                    Console.WriteLine("|c = a / b| Error. can`t divide by 0");
                else Console.WriteLine("c = a / b = " + Calculation.Division(a, b));

                if (b == 0)
                    Console.WriteLine("|c = (a+b)-(a-b) / (a*b)| Error. can`t divide by 0");
                else
                    Console.WriteLine("c = (a+b)-(a-b) / (a*b) = " + Calculation.MultiAction(a, b));

                //Console.Clear(); // clearing the console
                Console.WriteLine("\nIf you'd like to stop using calculator, please, press the Esc button.");
                Console.WriteLine("If you'd like to proceed using calculator, please, press the Enter button.\n");

                while (true)
                {
                    pressedKey = Console.ReadKey(true);
                    if (pressedKey.Key == ConsoleKey.Enter || pressedKey.Key == ConsoleKey.Escape)
                        break;
                }

            } while (pressedKey.Key != ConsoleKey.Escape);
        }
    }
}
