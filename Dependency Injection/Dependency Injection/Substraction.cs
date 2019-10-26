using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Substraction : IOperation
    {
        public int Execute(int a, int b)
        {
            return a - b;
        }
    }
}
