using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyLib
{
    public abstract class CirculatingMoney : Money
    {
        // Fields
        private int _issueYear = 0;
        private string _side1Picture = "not yet defined";
        private string _side2Picture = "not yet defined";

        // Properties
        public int IssueYear
        {
            get
            {
                return _issueYear;
            }
            internal set
            {
                _issueYear = value;
            }
        }

        public string Side1
        {
            get
            {
                return _side1Picture;
            }
            internal set
            {
                _side2Picture = value;
            }
        }

        public string Side2
        {
            get
            {
                return _side2Picture;
            }
            internal set
            {
                _side2Picture = value;
            }
        }


        // Constructors
        public CirculatingMoney(Currency currency, decimal denomination) : base(currency, denomination)
        {

        }
    }

}
