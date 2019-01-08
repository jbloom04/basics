using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basics
{
    class Program
    {
        static void Main(string[] args)
        {

            Customer cust = new Customer() { age = 3 };
            //DIP - Inverted dependency - supply it the dependency
            ILogger l = new DatabaseLogger();
            GoldCustomer jon = new GoldCustomer(l) { age = 36 };


            SilverCustomer j = new SilverCustomer() { age = 36 };
            jon.GetDiscount(100);

            jon.Add();
            TempCustomer t = new TempCustomer();

            Customer myCustomer = t;
            myCustomer.GetDiscount(100);



        }
    }
}
