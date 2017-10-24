using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_TDD
{
    public class Checkout
    {
        private Dictionary<char, decimal> PriceLookup;

        public Checkout()
        {
            PriceLookup = new Dictionary<char, decimal>()
            {
                { 'A', 20 },
                { 'B', 10 },
                { 'C', 15 }
            };
        }

        public decimal GetPrice(string code)
        {
            if (string.IsNullOrEmpty(code))
                return 0;

            decimal total = 0;
            foreach (var letter in code)
            {
                decimal price;
                if (PriceLookup.TryGetValue(letter, out price))
                    total += price;
            }
            return total;
        }
    }
}
