using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuoteRatingEngine.Model
{
    public class QuoteRequest
    {
        public double Revenue { get; set; }
        public string State { get; set; }
        public string Business { get; set; }
    }
}
