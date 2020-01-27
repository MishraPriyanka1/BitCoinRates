using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using DisplayCurrencyRates.Data;
using DisplayCurrencyRates.Data.Entities;
using DisplayCurrencyRates.Data.Repository;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
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
            string url = "https://api.coindesk.com/v1/bpi/historical/close.json?start="
                + DateTime.Now.AddDays(-14).ToString("yyyy-MM-dd")
                + "&end=" + DateTime.Now.AddDays(+1).ToString("yyyy-MM-dd");
            string json = Get_Web_Content(url);
            var bci = JsonConvert.DeserializeObject<BitCoinIndex>(json);
            return View(bci.BPI);
        }
        public string Get_Web_Content(string url)
        {
            Uri uri = new Uri(url);
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(uri);
            request.Method = WebRequestMethods.Http.Get;
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader reader = new StreamReader(response.GetResponseStream());
            string output = reader.ReadToEnd();
            response.Close();
            return output;
        }
    }
   
}
