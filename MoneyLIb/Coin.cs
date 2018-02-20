using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyLib
{
    public abstract class Coin : CirculatingMoney
    {
        // Fields
        private double _thicknessInCM = 0;
        private double _radiusInCM = 0;
        private double _weightInGrams = 0;

        // Properties
        public double ThicknessInCM
        {
            get
            {
                return _thicknessInCM;
            }
            internal set
            {
                _thicknessInCM = value;
            }
        }

        public double RadiusInCM
        {
            get
            {
                return _radiusInCM;
            }
            internal set
            {
                _radiusInCM = value;
            }
        }

        // Constructors
        public Coin(Currency currency, decimal denomination) : base(currency, denomination)
        {

        }
    }
}
