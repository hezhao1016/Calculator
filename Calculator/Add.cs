using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Add:Sum
    {
        public Add(double a,double b):base(a,b)
        {
        
        }
        public override double Math()
        {
            return A+B;
        }
    }
}
