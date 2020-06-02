using System;

namespace Firstprogram
{
    class Program
    {
        public static void Datatype()
        {
            string a = "hello world!";
            int i = 786;
            double d = 1.5;
            decimal dc = 3.5m;
            float f = 4.5f;
            long l = 1233345333456L;
            short s = 22332;
            byte b = 255;
            uint UI = 300;
            ulong UL = 1233345333456L;
            ushort US = 123;
            Console.WriteLine(a);
            Console.WriteLine("intger " + i);
            Console.WriteLine("double " + d);
            Console.WriteLine("decimal " + dc);
            Console.WriteLine("float " + f);
            Console.WriteLine("long " + l);
            Console.WriteLine("short " + s);
            Console.WriteLine("byte " + b);
            Console.WriteLine("unsiged Int " + UI);
            Console.WriteLine("unsiged Long " + UL);
            Console.WriteLine("unsiged short " + US);
        }
        static void Main(string[] args)
        {

            Console.WriteLine(".....all datatype....." + "\n");
            Datatype();
            Console.WriteLine("\n" + "...end here...." + "\n");

            Console.WriteLine(".....Normal calculator....." + "\n");
            Calculator.plus();
            Calculator.minus();
            Calculator.into();
            Calculator.divide();
            Console.WriteLine("\n" + "...end here...." + "\n");

            Console.WriteLine(".....casting....." + "\n");
            Casting.ImplicitCasting();
            Casting.ExplicitCasting();
            Console.WriteLine("\n" + "...end here...." + "\n");

            Console.WriteLine(".....rerturn type ....." + "\n");
            int plus=RerturnTypeCalculator.plus(10,10);
            Console.WriteLine("Return type plus is: "+ plus);

            int minus = RerturnTypeCalculator.minus(10, 10);
            Console.WriteLine("Return type minus is: " + minus);
            
            int into = RerturnTypeCalculator.into(10, 10);
            Console.WriteLine("Return type into is: " + into);
            
            int divide = RerturnTypeCalculator.divide(10, 10);
            Console.WriteLine("Return type divide is: " + divide);
            Console.WriteLine("\n" + "...end here...." + "\n");
        }
    }
}
