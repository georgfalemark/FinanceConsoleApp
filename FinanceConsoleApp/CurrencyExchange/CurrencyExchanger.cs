using RestSharp;
using System;

namespace CurrencyExchange
{
    public class Class1
    {


       public void GetCurrencyExchanged(string fromStr, string toStr)
        {
            string fromCurr = fromStr.Trim().ToUpper();
            string toCurr = toStr.Trim().ToUpper();
            var client = new RestClient("https://currency-exchange.p.rapidapi.com/exchange?q=1.0&from=fromCurr&to=toCurr");
            var request = new RestRequest(Method.GET);
            request.AddHeader("x-rapidapi-host", "currency-exchange.p.rapidapi.com");
            request.AddHeader("x-rapidapi-key", "85555bd492msh7d7227cb26869c0p1cdb59jsn22e3dfc6975f");
            IRestResponse response = client.Execute(request);

            var x = 1;

        }
    }
}
