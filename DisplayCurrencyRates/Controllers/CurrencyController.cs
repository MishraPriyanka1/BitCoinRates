using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using DisplayCurrencyRates.Data;
using DisplayCurrencyRates.Data.Entities;
using DisplayCurrencyRates.Data.Repository;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DisplayCurrencyRates.Controllers
{
   
    [Route("api/[controller]")]
    public class CurrencyController : Controller
    {
        private IBitCoinRepository _bitcoinRepository;

        public CurrencyController(IBitCoinRepository bitCoinRepository)
        {
            _bitcoinRepository = bitCoinRepository;
        }
        // GET: api/<controller>
        [HttpGet]
        public IActionResult Get()
        {

            HttpClient http = new HttpClient();
            var data = http.GetAsync("https://api.coindesk.com/v1/bpi/historical/close.json?start=" + DateTime.Now.AddDays(-14).ToString("yyyy-MM-dd") + "&end=" + DateTime.Now.ToString("yyyy-MM-dd"))
                       .Result.Content.ReadAsStringAsync().Result;
          
            ViewData["bitcoinValues"] = data;
            return View();
            //var bci = _bitcoinRepository.GetByDates(DateTime.Now.AddDays(-14)).ToDictionary(t => t.Date.ToString(), t => t.Rate);
            //return bci;
        }
    }
}
