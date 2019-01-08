using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basics
{
    class GoldCustomer:Customer,IDatabase //the Add method is separate from the class definition (LSP)
    {
        private ILogger _logger;

        public GoldCustomer(ILogger logger){
            _logger = logger;
        }

        public void Add()
        {
            try            {
                throw new Exception();
            }            catch (Exception ex)            {
                //DIP
                _logger.log(ex);
                //ILogger l = new FileLogger();
                //FileLogger f = new FileLogger();
                //l.log(ex);            }
        }

        public override double GetDiscount(double total)
        {
            return total - 20;
        }
    }
}
