using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyLib
{
    public class Penny : Coin
    {
        public Penny() : base(Currency.GetCountryCurrency("USD"), 0.01m)
        {
            
        }
    }

    public class Nickel : Coin
    {
        public Nickel() : base(Currency.GetCountryCurrency("USD"), .05m)
        {
            
        }
    }

    public class Dime : Coin
    {
        public Dime() : base(Currency.GetCountryCurrency("USD"), .1m)
        {
            
        }
    }

    public class Quarter : Coin
    {
        public Quarter() : base(Currency.GetCountryCurrency("USD"), .25m)
        {
            
        }
    }

    public class SilverDollar : Coin
    {
        public SilverDollar() : base(Currency.GetCountryCurrency("USD"), 1)
        {
            
        }
    }
}
