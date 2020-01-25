using System;
using System.Linq;
using DisplayCurrencyRates.Data.Entities;

namespace DisplayCurrencyRates.Data.Repository
{
    public interface IBitCoinRepository
    {
        IQueryable<BitCoinIndex> GetAll();
        IQueryable<BitCoinIndex> GetByDates(DateTime startDate);
    }
}