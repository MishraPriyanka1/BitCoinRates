using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DisplayCurrencyRates.Data
{
    public class BitCoinSeeder
    {
        private CurrencyContext _ctx;
        public BitCoinSeeder(CurrencyContext ctx)
        {
            _ctx = ctx;
        }
        public void Seed()
        {
            _ctx.Database.EnsureCreated();
            if(!_ctx.BitCoinIndexes.Any())
            {

            }
        }
    }
}
