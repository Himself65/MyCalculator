using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorClass
{
   public class Calculator
    {
        public double a, b;
        public double Add()
        {
            return this.a + this.b;
        }
        public double Sub()
        {
            return this.a * this.b;
        } 
        public double Max()
        {
            if (this.a > this.b)
                return a;
            else
                return b;
        }
        public double Min()
        {
            if (this.a < this.b)
                return a;
            else
                return b;
        }

    }
}
