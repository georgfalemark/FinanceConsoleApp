using FinnhubAPI;
using System;

namespace FinanceConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var app = new App();
            app.Run();












 

            var CurrencyEx = new CurrencyExchanger();
           var currEx = CurrencyEx.GetCurrencyExchanged();
            //var c = new Class1();
            //c.Go();

            Console.WriteLine("Just nu står kursen i: " + currEx);

        }
    }
}
