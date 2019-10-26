using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Calculator2
    {
        private IOperation _opp;

       public IOperation  operation
        {
            set { this._opp = value; }
        }
       

        public int doaction(int a, int b)
        {
            return this._opp.Execute(a, b);

        }

    }
}
