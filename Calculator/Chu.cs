using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Chu : Sum
    {
        public override double Math()
        {
            return A / B;
        }
        public Chu(double a, double b)
            : base(a, b)
        { 
            
        }
    }
}
