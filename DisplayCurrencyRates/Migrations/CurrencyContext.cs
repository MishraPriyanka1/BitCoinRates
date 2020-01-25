using DisplayCurrencyRates.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DisplayCurrencyRates.Data
{
    public class CurrencyContext : DbContext
    {
        public CurrencyContext(DbContextOptions<CurrencyContext> options) : base(options)
        {

        }
        public DbSet<BitCoinIndex> BitCoinIndexes { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<BitCoinIndex>()
                .HasData( new BitCoinIndex() {
                    Id = 1,
                    Date = DateTime.Now
                } );
        }
    }
}
