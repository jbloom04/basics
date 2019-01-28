using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basics
{
    public class BlackScholes
    {
        public int price { get; set; }

        public void PriceOption(int p)
        {
            this.price = p*5;
        }

    }
}
