using DisplayCurrencyRates.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DisplayCurrencyRates.Repository
{
   public interface IGenericRepository<TEntity>
        where TEntity : BitCoinIndex
    {
        IQueryable<TEntity> GetAll();
        IQueryable<TEntity> GetByDates(DateTime startDate);
    }
}
