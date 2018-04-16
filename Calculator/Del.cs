using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Del : Sum
    {
        public override double Math()
        {
            return A - B;
        }
        public Del(double a, double b)
            : base(a, b)
        { 
            
        }
    }
}
