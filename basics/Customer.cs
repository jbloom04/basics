using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basics
{
    class Customer
    {
        public int age { get; set; }
        public virtual double GetDiscount(double total) { return total; }
    }
}
