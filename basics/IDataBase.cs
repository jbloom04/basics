using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basics
{
    interface IDatabase
    {
        void Add();
        //void Read();  adding this would break existing clients. Apply ISP and add new interface for Read functionality
    }
}
