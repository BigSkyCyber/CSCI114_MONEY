﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyLib
{ 
    public class Money : IComparable
    {
        // Fields
        private Currency _currency;
        private decimal _value = 0;

        // Properties
        public Currency Currency
        {
            get
            {
                return _currency;
            }
        }

        public decimal Value
        {
            get
            {
                return _value;
            }
        }

        public int MajorValue
        {
            get
            {
                return (int)_value;
            }
        }

        public int MinorValue
        {
            get
            {
                return (int)((_value - MajorValue) * Currency.UnitRatio);
            }
        }

        public string CurrencyValue
        {
            get
            {
                return string.Format("{0} {1} and {2} {3}", MajorValue, Currency.MajorSymbol, MinorValue, Currency.MinorSymbol);
            }
        }

        //Constructors
        public Money(Currency currency, decimal value)
        {
            _currency = currency;
            _value = value;
        }

        // IComparable interface implementation
        public int CompareTo(object obj)
        {
            if(obj is Money tempMoney)
            {
                return _value.CompareTo(tempMoney.Value);
            }
            else
            {
                throw new Exception("Thrown from Money CompareTo method.");
            }
        }
    }
}
