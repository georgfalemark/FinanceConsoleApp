using FinnhubAPI.Classes;
using FinnhubAPI.Interfaces;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Net;
using System.Threading.Tasks;
using unirest;
using static FinnhubAPI.Classes.AnalystsPriceTargetClasses;
using static FinnhubAPI.Classes.EarningsClasses;

namespace FinnhubAPI
{
    public class FinnhubAPIController : IFinnhubAPIController
    {
        public AnalystsPriceTarget GetAnalystsPriceTargetForSymbol(string symbol)
        {
            var client = new RestClient($"https://finnhub-realtime-stock-price.p.rapidapi.com/stock/price-target?symbol={symbol}");
            var request = new RestRequest(Method.GET);
            request.AddHeader("x-rapidapi-host", "finnhub-realtime-stock-price.p.rapidapi.com");
            request.AddHeader("x-rapidapi-key", "7ac1b9cebamsh9185a8282bb919cp1fa9e1jsn9f334da35cc3");
            IRestResponse response = client.Execute(request);

            if (response.StatusCode == HttpStatusCode.OK)
            {
                AnalystsPriceTarget analystsPriceTarget = JsonConvert.DeserializeObject<AnalystsPriceTarget>(response.Content);
                return analystsPriceTarget;
            }
            else
                return null;
        }

        public Earning[] GetEarningsForSymbol(string symbol)
        {
            var client = new RestClient($"https://finnhub-realtime-stock-price.p.rapidapi.com/stock/earnings?symbol={symbol}");
            var request = new RestRequest(Method.GET);
            request.AddHeader("finnhub-realtime-stock-price.p.rapidapi.com", "finnhub-realtime-stock-price.p.rapidapi.com");
            request.AddHeader("x-rapidapi-key", "7ac1b9cebamsh9185a8282bb919cp1fa9e1jsn9f334da35cc3");
            IRestResponse response = client.Execute(request);

            if (response.StatusCode == HttpStatusCode.OK)
            {
                Earning[] earnings = JsonConvert.DeserializeObject<Earning[]>(response.Content);
                return earnings;
            }
            else
                return null;
        }





    }
}
