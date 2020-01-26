using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DisplayCurrencyRates.Data;
using DisplayCurrencyRates.Data.Entities;
using DisplayCurrencyRates.Data.Repository;
using DisplayCurrencyRates.Repository;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DisplayCurrencyRates.Controllers
{
    [Route("Currency")]
    public class CurrencyController : Controller
    {
        private BitCoinRepository<BitCoinIndex> _repository;

        public CurrencyController(BitCoinRepository<BitCoinIndex> repository)
        {
            _repository = repository;
        }
        // GET: api/<controller>
        [HttpGet("/GetRates/{start}", Name = "getrates")]
        public IActionResult GetRates(DateTime start)
        {
            var bci =  _repository.GetByDates(start).ToDictionary(t => t.Date.ToString(), t => t.Rate);
            return View(bci);    
        }
    }
}
