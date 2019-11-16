using FinnhubAPI.Classes;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Net;
using System.Threading.Tasks;
using unirest;
using static FinnhubAPI.Classes.EarningsClasses;

namespace FinnhubAPI
{
    public class FinnhubAPIController
    {
        public void GetEarningsForSymbol(string symbol)
        {
            var client = new RestClient($"https://finnhub-realtime-stock-price.p.rapidapi.com/stock/earnings?symbol={symbol}");
            var request = new RestRequest(Method.GET);
            request.AddHeader("finnhub-realtime-stock-price.p.rapidapi.com", "finnhub-realtime-stock-price.p.rapidapi.com");
            request.AddHeader("x-rapidapi-key", "7ac1b9cebamsh9185a8282bb919cp1fa9e1jsn9f334da35cc3");
            IRestResponse response = client.Execute(request);

            if (response.StatusCode == HttpStatusCode.OK)
            {
                Earning[] earnings = JsonConvert.DeserializeObject<Earning[]>(response.Content);
                Console.Clear();
                string actual = "actual:";
                string estimate = "estimate:";
                string actualSymbol = "symbol:";
                foreach (Earning earning in earnings)
                {
                    Console.WriteLine($"{earning.period}: {actual.PadLeft(12)} {earning.actual.ToString().PadLeft(5)} {estimate.PadLeft(12)} {earning.estimate.ToString().PadLeft(5)} {actualSymbol.PadLeft(12)} {earning.symbol}");
                }
                Console.ReadKey();
            }
        }

        public void Go2()
        {
            var client = new RestClient("https://finnhub-realtime-stock-price.p.rapidapi.com/stock/price-target?symbol=MSFT");
            var request = new RestRequest(Method.GET);
            request.AddHeader("x-rapidapi-host", "finnhub-realtime-stock-price.p.rapidapi.com");
            request.AddHeader("x-rapidapi-key", "7ac1b9cebamsh9185a8282bb919cp1fa9e1jsn9f334da35cc3");
            IRestResponse response = client.Execute(request);
        }



    }
}
