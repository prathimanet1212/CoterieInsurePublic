using QuoteRatingEngine.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuoteRatingEngine.Service
{
    public class Calculator
    {
        public QuoteResponse getQuote(QuoteRequest quoteRequest)
        {
            QuoteResponse quoteResponse = new QuoteResponse();

            //Factors
            Dictionary<string, Double> stateFactor = new Dictionary<string, double>();
            stateFactor.Add("OH", 1);
            stateFactor.Add("FL", 1.2);
            stateFactor.Add("TX", 0.943);

            Dictionary<string, Double> businessFactor = new Dictionary<string, double>();
            businessFactor.Add("Architect", 1);
            businessFactor.Add("Plumber", 0.5);
            businessFactor.Add("Programmer", 1.25);

            double hazardFactor = 4;

            double basePremium = Math.Ceiling(quoteRequest.Revenue / 1000);

            double totalPremium = stateFactor[quoteRequest.State] * businessFactor[quoteRequest.Business] * hazardFactor * basePremium;
            quoteResponse.Premium = totalPremium;
            return quoteResponse;
        }
    }
}
