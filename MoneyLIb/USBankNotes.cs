using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyLib
{
    public class DollarBill : BankNote
    {
        public DollarBill() : base(Currency.GetCountryCurrency("USD"),1)
        {

        }
    }

    public class TwoDollarBill : BankNote
    {
        public TwoDollarBill() : base(Currency.GetCountryCurrency("USD"), 2)
        {

        }
    }

    public class FiveDollarBill : BankNote
    {
        public FiveDollarBill() : base(Currency.GetCountryCurrency("USD"), 5)
        {

        }
    }

    public class TenDollarBill : BankNote
    {
        public TenDollarBill() : base(Currency.GetCountryCurrency("USD"), 10)
        {

        }
    }

    public class TwentyDollarBill : BankNote
    {
        public TwentyDollarBill() : base(Currency.GetCountryCurrency("USD"), 20)
        {
            
        }
    }
}
