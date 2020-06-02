using System;
using System.Collections.Generic;
using System.Text;

namespace Firstprogram
{
    class Casting
    {
        public static void ImplicitCasting()
        {
            double cd = 335.88;
            int ci;
            Console.WriteLine("double value " + cd);
            ci = (int)cd;
            Console.WriteLine("double to integer " + ci);

            float f = 10.5F;
            int i;
            Console.WriteLine("float value " + f);
            i = (int)f;
            Console.WriteLine("float to integer " + i);

            decimal  dc= 10.5M;
            double d;
            Console.WriteLine("decimal value " + dc);
            d = (double)dc;
            Console.WriteLine("decimal to double " + i);

            int a = 10;
            short s;
            Console.WriteLine("integer value " + a);
            s = (short)a;
            Console.WriteLine("integer to short " + s);
            
        }
        public static void ExplicitCasting()
        {
            int i = 75;
            float f = 53.005f;
            double d = 2345.7652;
            bool b = true;

            Console.WriteLine(i.ToString());
            Console.WriteLine(f.ToString());
            Console.WriteLine(d.ToString());
            Console.WriteLine(b.ToString());


        }
    }
}
