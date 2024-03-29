﻿using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinnhubAPI
{
    public class CurrencyExchanger
    {
        public string GetCurrencyExchanged()
        {
            //Behöver 3 bokstäverna på valutan
            Console.WriteLine("skriv in valute du vill växla till: ");
            var toCurr = Console.ReadLine().Trim().ToUpper();
            Console.WriteLine("skriv in valute du vill växla från: ");
            var fromCurr = Console.ReadLine().Trim().ToUpper();



            var client = new RestClient("https://currency-exchange.p.rapidapi.com/exchange?q=1.0&from="+fromCurr+"&to="+toCurr);
            var request = new RestRequest(Method.GET);
            request.AddHeader("x-rapidapi-host", "currency-exchange.p.rapidapi.com");
            request.AddHeader("x-rapidapi-key", "85555bd492msh7d7227cb26869c0p1cdb59jsn22e3dfc6975f");
            IRestResponse response = client.Execute(request);

            string answer = response.Content.ToString();
            return answer;


        }
    }
}
