using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basics
{
    class SilverCustomer:Customer,IDatabase
    {
        public void Add()
        {
            try            {
                throw new Exception();
            }            catch (Exception ex)            {                FileLogger f = new FileLogger();                f.log(ex);            }   
        }

        public override double GetDiscount(double total)
        {
            return total - 10;
        }
    }
}
