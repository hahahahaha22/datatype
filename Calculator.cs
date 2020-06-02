using System;
using System.Collections.Generic;
using System.Text;

namespace Firstprogram
{
    class Calculator
    {
        public static void plus() {
            int a = 10;
            int b = 10;
            Console.WriteLine("plus is " + (a+b));
        }
        public static void minus()
        {
            int a = 10;
            int b = 10;
            Console.WriteLine("minus is " + (a - b));
        }
        public static void into()
        {
            int a = 10;
            int b = 10;
            Console.WriteLine("into is " + (a * b));

        }
        public static void divide()
        {
            int a = 10;
            int b = 10;
            Console.WriteLine("divide is " + (a / b));
        }
    }
}
