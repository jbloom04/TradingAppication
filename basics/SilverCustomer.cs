﻿using System;
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
            try
                throw new Exception();
            }
        }

        public override double GetDiscount(double total)
        {
            return total - 10;
        }
    }
}