using FinanceConsoleApp.Interfaces;
using FinnhubAPI;
using FinnhubAPI.Classes;
using FinnhubAPI.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using static FinnhubAPI.Classes.AnalystsPriceTargetClasses;
using static FinnhubAPI.Classes.EarningsClasses;

namespace FinanceConsoleApp.Classes
{
    public class FinnhubAPIConnection : IFinnhubAPIConnection
    {
        private IFinnhubAPIController finnhubAPIController;
        private Earning[] earnings;
        private AnalystsPriceTarget analystsPriceTarget;

        public FinnhubAPIConnection()
        {
            finnhubAPIController = new FinnhubAPIController();
        }

        public void Start(App app)
        {
            PresentFinnhubMainMenu();

            int choice;
            while (true)
            {
                try
                {
                    choice = int.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    PresentFinnhubMainMenu();
                    Console.WriteLine("ange en siffra!");
                }
            }

            switch (choice)
            {
                case 2:
                    analystsPriceTarget = finnhubAPIController.GetAnalystsPriceTargetForSymbol("MSFT");
                    if (analystsPriceTarget != null)
                        PresentAnalystsPriceTarget(analystsPriceTarget);
                    break;
                case 3:
                    earnings = finnhubAPIController.GetEarningsForSymbol("MSFT");
                    if (earnings != null)
                        PresentEarningsArr(earnings);
                    break;
                case 4:
                    app.Run();
                    break;
                default:
                    Start(app);
                    break;
            }
            Start(app);
        }

        private void PresentAnalystsPriceTarget(AnalystsPriceTarget analystsPriceTarget)
        {
            Console.Clear();
            string lastUpdated = "Last updated:";
            string targetLow = "Target low:";
            string targetHigh = "Target high:";
            string targetMean = "Target mean:";
            string targetMedian = "Target median:";
            string symbol = "Symbol:";
            Console.WriteLine($"{lastUpdated.PadLeft(15)} {analystsPriceTarget.lastUpdated.PadLeft(25)}");
            Console.WriteLine($"{targetLow.PadLeft(15)} {analystsPriceTarget.targetLow.ToString().PadLeft(25 - analystsPriceTarget.lastUpdated.Length + analystsPriceTarget.targetLow.ToString().Length)}");
            Console.WriteLine($"{targetHigh.PadLeft(15)} {analystsPriceTarget.targetHigh.ToString().PadLeft(25 - analystsPriceTarget.lastUpdated.Length + analystsPriceTarget.targetHigh.ToString().Length)}");
            Console.WriteLine($"{targetMean.PadLeft(15)} {analystsPriceTarget.targetMean.ToString().PadLeft(25 - analystsPriceTarget.lastUpdated.Length + analystsPriceTarget.targetMean.ToString().Length)}");
            Console.WriteLine($"{targetMedian.PadLeft(15)} {analystsPriceTarget.targetMedian.ToString().PadLeft(25 - analystsPriceTarget.lastUpdated.Length + analystsPriceTarget.targetMedian.ToString().Length)}");
            Console.WriteLine($"{symbol.PadLeft(15)} {analystsPriceTarget.symbol.PadLeft(25 - analystsPriceTarget.lastUpdated.Length + analystsPriceTarget.symbol.Length)}");
            Console.ReadKey();
        }

        public void PresentEarningsArr(Earning[] earnings)
        {
            Console.Clear();
            string actual = "actual:";
            string estimate = "estimate:";
            string symbol = "symbol:";

            foreach (Earning earning in earnings)
                Console.WriteLine($"{earning.period}: {actual.PadLeft(12)} {earning.actual.ToString().PadLeft(5)} {estimate.PadLeft(12)} {earning.estimate.ToString().PadLeft(5)} {symbol.PadLeft(12)} {earning.symbol}");

            Console.ReadKey();
        }

        public void PresentFinnhubMainMenu()
        {
            Console.Clear();
            Console.WriteLine("1) Nått val");
            Console.WriteLine("2) Analytikers riktpriser för en viss aktie");
            Console.WriteLine("3) Earnings för viss aktie");
            Console.WriteLine("4) MAIN MENU");
        }
    }
}
