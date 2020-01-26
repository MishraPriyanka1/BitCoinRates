using DisplayCurrencyRates.Data;
using DisplayCurrencyRates.Data.Entities;
using DisplayCurrencyRates.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DisplayCurrencyRates.Data.Repository
{
    public class BitCoinRepository<TEntity> : IGenericRepository<TEntity>
        where TEntity : BitCoinIndex
    {
        private CurrencyContext _dbContext;
        private ILogger<BitCoinRepository<BitCoinIndex>> _logger;

        public BitCoinRepository(CurrencyContext dbContext, ILogger<BitCoinRepository<BitCoinIndex>> logger)
        {
            _dbContext = dbContext;
            _logger = logger;
        }
        public IQueryable<TEntity> GetAll()
        {
            return _dbContext.Set<TEntity>().AsNoTracking();
        }
        public IQueryable<TEntity> GetByDates(DateTime startDate)
        {
            try
            {
                _logger.LogInformation("GetBitCoinDates was called");
                return _dbContext.Set<TEntity>()
                    .AsNoTracking()
                    .Where(e => e.Date >= startDate && e.Date <= DateTime.Now);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Failed to get BitCoinRates:{ex}");
                return null;
            }         
        }
        
    }
}
    