using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basics
{
    public class SimpleOperation
    {
        public int operate(int typeOfOperation, int int1, int int2)
        {
            int temp = 0;
            switch (typeOfOperation)
            {
                case 1:
                    temp = int1 + int2;
                    break;

                case 2:
                    temp = int1 - int2;
                    break;

                
            }
            return temp;
        }
    }
}
