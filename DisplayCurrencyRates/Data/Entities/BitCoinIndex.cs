using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DisplayCurrencyRates.Data.Entities
{
    public class BitCoinIndex
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public double Rate { get; set; }
        public string Symbol { get; set; }

    }
}
