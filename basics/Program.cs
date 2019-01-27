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
            //DIP - Dependency inversion principle
            ILogger l = new DatabaseLogger();
            //OCP - Open Closed Principle - Extension should be preferred over modification
            GoldCustomer jon = new GoldCustomer(l) { age = 36 };//dependency injection
            SilverCustomer j = new SilverCustomer() { age = 36 };

            jon.GetDiscount(100);

            jon.Add();
            TempCustomer t = new TempCustomer();

            Customer myCustomer = t;
            myCustomer.GetDiscount(100);



        }
    }
}
