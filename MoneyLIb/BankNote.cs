using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyLib
{
    public abstract class BankNote : CirculatingMoney
    {
        // Fields
        private double _widthInCM = 0;
        private double _heightInCM = 0;

        // Properties
        public double WidthInCM
        {
            get
            {
                return _widthInCM;
            }
            internal set
            {
                _widthInCM = value;
            }
        }

        public double HeightInCM
        {
            get
            {
                return _heightInCM;
            }
            internal set
            {
                _heightInCM = value;
            }
        }

        // Contructors
        public BankNote(Currency currency, decimal denomination) : base(currency, denomination)
        {

        }
    }
}
