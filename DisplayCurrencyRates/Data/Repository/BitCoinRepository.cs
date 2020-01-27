using DisplayCurrencyRates.Data;
using DisplayCurrencyRates.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DisplayCurrencyRates.Data.Repository
{
    public class BitCoinRepository : IBitCoinRepository
    {
        private CurrencyContext _dbContext;


        public BitCoinRepository(CurrencyContext dbContext)
        {
            _dbContext = dbContext;

        }
        //public IQueryable<BitCoinIndex> GetAll()
        //{
        //    return _dbContext.BitCoinIndexes
        //                     .OrderBy(p => p.Date);
        //}
        //public IQueryable<BitCoinIndex> GetByDates(DateTime startDate)
        //{
        //    try
        //    {
        //        // _logger.LogInformation("GetBitCoinDates was called");
        //        return _dbContext.BitCoinIndexes
        //            .Where(e => e.Date >= startDate && e.Date <= DateTime.Now);
        //    }
        //    catch (Exception ex)
        //    {
        //        //  _logger.LogError($"Failed to get BitCoinRates:{ex}");
        //        return null;
        //    }
        //}

    }
}
    