using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Calculator
    {
        
       private IOperation opp;
        public Calculator(IOperation op)
        {
            this.opp = op;
        }
       public int  doaction(int a,int b)
        {
            return this.opp.Execute(a, b);

        }

    }
}
