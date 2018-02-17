using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoneyLib;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            MyWallet w = new MyWallet();

            Penny p = new Penny();
            Quarter q = new Quarter();

            w.AddMoney(p);
            w.AddMoney(q);
            Console.WriteLine("My wallet has {0} in it.", w.TotalValue);
            // p = w.RemoveMoney(p);
            // List<CirculatingMoney> moneyBag = w.GetMoney(25.25m);

            Console.ReadLine();
        }
    }

    class MyWallet
    {
        // Hold a collection of CirculatingMoney objects
        // Create an object constructor
        // Create an AddMoney method param ??
        // Create a RemoveMoney method parms ??
        // Create a GetMoney method param ?? return ??

        private List<CirculatingMoney> _myMoney;

        public decimal TotalValue
        {
            get
            {
                decimal total = 0;
                foreach(CirculatingMoney tempM in _myMoney)
                {
                    total += tempM.Value;
                }
                return total;
            }
        }

        public MyWallet()
        {
            _myMoney = new List<CirculatingMoney>();
        }

        public void AddMoney(CirculatingMoney cash)
        {
            _myMoney.Add(cash);
        }

        public CirculatingMoney RemoveMoney(CirculatingMoney cash)
        {
            throw new NotImplementedException();
        }

        public List<CirculatingMoney> GetMoney(decimal amount)
        {
            throw new NotImplementedException();
        }
    }
}
