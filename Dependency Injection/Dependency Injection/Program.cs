using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {
            Addition a = new Addition();
            Substraction s = new Substraction();
            Calculator c = new Calculator(a);
            Console.WriteLine(c.doaction(10,15));
            Console.ReadKey();
            Calculator c1 = new Calculator(s);
            Console.WriteLine(c1.doaction(10, 15));
            Console.ReadKey();

            Calculator2 c2 = new Calculator2();
            c2.operation = a;
            Console.WriteLine(c2.doaction(20, 4));
            Console.ReadKey();

            c2.operation = s;
            Console.WriteLine(c2.doaction(16, 11));
            Console.ReadKey();



        }
    }
}
