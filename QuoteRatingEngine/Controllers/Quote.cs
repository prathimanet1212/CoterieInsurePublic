using Microsoft.AspNetCore.Mvc;
using QuoteRatingEngine.Model;
using QuoteRatingEngine.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace QuoteRatingEngine.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Quote : ControllerBase
    {
        // POST api/<Quote>
        [HttpPost]
        public QuoteResponse Post([FromBody] QuoteRequest quoteRequest)
        {
            Calculator calculator = new Calculator();
            return calculator.getQuote(quoteRequest);
        }
    }
}
