using FinanceConsoleApp.Interfaces;
using FinnhubAPI;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinanceConsoleApp.Classes
{
    public class FinnhubAPIConnection : IFinnhubAPIConnection
    {
        private FinnhubAPIController finnhubAPIController;
        public FinnhubAPIConnection()
        {
            finnhubAPIController = new FinnhubAPIController();
        }

        public void Start(App app)
        {
            Console.Clear();
            Console.WriteLine("1) Nått val");
            Console.WriteLine("2) Nått val");
            Console.WriteLine("3) Earnings");
            Console.WriteLine("4) MAIN MENU");

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
                    Console.WriteLine("ange en siffra!");
                }
            }

            switch (choice)
            {
                case 3:
                    finnhubAPIController.GetEarningsForSymbol("MSFT");
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
    }
}
