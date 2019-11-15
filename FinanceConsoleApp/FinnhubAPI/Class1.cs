using RestSharp;

namespace FinnhubAPI
{
    public class Class1
    {
        public void Go()
        {
            var client = new RestClient("https://finnhub-realtime-stock-price.p.rapidapi.com/stock/earnings?symbol=AAPL");
            var request = new RestRequest(Method.GET);
            request.AddHeader("finnhub-realtime-stock-price.p.rapidapi.com", "finnhub-realtime-stock-price.p.rapidapi.com");
            request.AddHeader("x-rapidapi-key", "7ac1b9cebamsh9185a8282bb919cp1fa9e1jsn9f334da35cc3");
            IRestResponse response = client.Execute(request);

            



            //Task<HttpResponse<MyClass>> response = Unirest.get("https://finnhub-realtime-stock-price.p.rapidapi.com/stock/earnings?symbol=AAPL")
            //                                        .header("X-RapidAPI-Host", "finnhub-realtime-stock-price.p.rapidapi.com")
            //                                        .header("X-RapidAPI-Key", "7ac1b9cebamsh9185a8282bb919cp1fa9e1jsn9f334da35cc3")
            //                                        .asJson();









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
