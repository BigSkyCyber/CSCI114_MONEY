using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyLib
{
    public class Currency
    {
        // Static Methods
        public static Currency GetCountryCurrency(string country)
        {
            return new Currency(country);
        }

        // Fields
        private string _country;
        private string _name;
        private string _isoCode;
        private char _majorUnicodeSymbol;
        private string _majorUnit;
        private char _minorUnicodeSymbol;
        private string _minorUnit;
        private int _unitRatio;
        private double _USExchangeRate;

        // Properties
        public string Country
        {
            get
            {
                return _country;
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }
        }

        public string ISOCode
        {
            get
            {
                return _isoCode;
            }
        }

        public char MajorSymbol
        {
            get
            {
                return _majorUnicodeSymbol;
            }
        }

        public string MajorUnit
        {
            get
            {
                return _majorUnit;
            }
            
        }

        public char MinorSymbol
        {
            get
            {
                return _minorUnicodeSymbol;
            }
        }

       public string MinorUnit
        {
            get
            {
                return _minorUnit;
            }
            
        }

        public int UnitRatio
        {
            get
            {
                return _unitRatio;
            }
        }

        public double USExchange
        {
            get
            {
                return _USExchangeRate;
            }
        }

        // Constructors
        public Currency(string country)
        {
            this._country = country;
            switch (country.ToUpper())
            {
                case "CAN":
                    _name = "Canadian Dollar";
                    _majorUnit = "dollar";
                    _minorUnit = "cent";
                    _unitRatio = 100;
                    _isoCode = "CAN";
                    _majorUnicodeSymbol = '\u0024';
                    _minorUnicodeSymbol = '\u00A2';
                    _USExchangeRate = 1.05;
                    break;
                case "EUR":
                    _name = "European Euro";
                    _majorUnit = "euro";
                    _minorUnit = "cent";
                    _unitRatio = 100;
                    _isoCode = "EUR";
                    _majorUnicodeSymbol = '\u20AC';
                    _minorUnicodeSymbol = '\u00A2';
                    _USExchangeRate = 2.2;
                    break;
                case "JPY":
                    _name = "Japanese Yen";
                    _majorUnit = "yen";
                    _minorUnit = "none";
                    _unitRatio = 1;
                    _isoCode = "JPY";
                    _majorUnicodeSymbol = '\u00A5';
                    _minorUnicodeSymbol = '\u0000';
                    _USExchangeRate = 80;
                    break;
                case "MSN":
                    _name = "Mexican Peso";
                    _majorUnit = "peso";
                    _minorUnit = "centavo";
                    _unitRatio = 100;
                    _isoCode = "CAN";
                    _majorUnicodeSymbol = '\u20B1';
                    _minorUnicodeSymbol = '\u00A2';
                    _USExchangeRate = 19.04;
                    break;
                case "USD":
                    _name = "United States Dollar";
                    _majorUnit = "dollar";
                    _minorUnit = "cent";
                    _unitRatio = 100;
                    _isoCode = "USD";
                    _majorUnicodeSymbol = '\u0024';
                    _minorUnicodeSymbol = '\u00A2';
                    _USExchangeRate = 1;
                    break;
                default:
                    _name = "unknown";
                    _majorUnit = "unknown";
                    _minorUnit = "unknown";
                    _unitRatio = 1;
                    _isoCode = "XXX";
                    _majorUnicodeSymbol = '\u00A4';
                    _minorUnicodeSymbol = '\u00A4';
                    _USExchangeRate = 1;
                    break;
            }
        }
    }
}
