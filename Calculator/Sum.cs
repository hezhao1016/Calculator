using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Sum
    {
        public double A { get; set; }
        public double B { get; set; }

        public Sum(double a, double b)
        {
            this.A = a;
            this.B = b;
        }
        public virtual double Math()
        {
            return 0;
        }
    }
}
