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
                .HasData(
                   new BitCoinIndex(){
                    Id=1,
                    Date = DateTime.Now,
                    Rate = 8661.01,
                    Symbol = "EUR"
                   },
                   new BitCoinIndex()
                   {
                    Id=2,
                    Date = DateTime.Now.AddDays(-1),
                    Rate = 8727.6033,
                    Symbol = "EUR"
                   },
                    new BitCoinIndex()
                   {
                    Id=3,
                    Date = DateTime.Now.AddDays(-2),
                    Rate =  8631.2883,
                    Symbol = "EUR"
                   },
                    new BitCoinIndex()
                    {
                    Id=4,
                    Date = DateTime.Now.AddDays(-3),
                    Rate = 8698.5717,
                    Symbol = "EUR"
                    },
                    new BitCoinIndex()
                    {
                    Id=5,
                    Date = DateTime.Now.AddDays(-4),
                    Rate = 8901.17,
                    Symbol = "EUR"
                    },
                    new BitCoinIndex()
                    {
                    Id=6,
                    Date = DateTime.Now.AddDays(-5),
                    Rate = 8890.25,
                    Symbol = "EUR"
                    },
                    new BitCoinIndex()
                    {
                    Id=7,
                    Date = DateTime.Now.AddDays(-6),
                    Rate = 8716.9133,
                    Symbol = "EUR"
                    },
                    new BitCoinIndex()
                    {
                    Id=8,
                    Date = DateTime.Now.AddDays(-7),
                    Rate = 8808.4867,
                    Symbol = "EUR"
                    },
                    new BitCoinIndex()
                    {
                    Id=9,
                    Date = DateTime.Now.AddDays(-8),
                    Rate = 8807.4267,
                    Symbol = "EUR"
                    },
                    new BitCoinIndex()
                    {
                    Id=10,
                    Date = DateTime.Now.AddDays(-9),
                    Rate = 8105.4783,
                    Symbol = "EUR"
                    },
                     new BitCoinIndex()
                    {
                    Id=11,
                    Date = DateTime.Now.AddDays(-10),
                    Rate =  8178.8833,
                    Symbol = "EUR"
                    },
                      new BitCoinIndex()
                    {
                    Id=12,
                    Date = DateTime.Now.AddDays(-11),
                    Rate = 8016.4267,
                    Symbol = "EUR"
                    },
                      new BitCoinIndex()
                    {
                    Id=13,
                    Date = DateTime.Now.AddDays(-12),
                    Rate = 8189.265,
                    Symbol = "EUR"
                    },
                    new BitCoinIndex()
                    {
                    Id=14,
                    Date = DateTime.Now.AddDays(-13),
                    Rate = 7816.9233,
                    Symbol = "EUR"
                    },
                    new BitCoinIndex()
                    {
                    Id=15,
                    Date = DateTime.Now.AddDays(-14),
                    Rate =  8560.93,
                    Symbol = "EUR"
                    });
        }
    }
}
