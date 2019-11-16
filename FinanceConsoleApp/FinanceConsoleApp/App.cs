using FinanceConsoleApp.Classes;
using FinanceConsoleApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinanceConsoleApp
{
    public class App
    {
        private readonly IFinnhubAPIConnection _finnhubAPIConnection;

        public void Run()
        {
            Console.Clear();
            Console.WriteLine("1) Nått val");
            Console.WriteLine("2) Nått val");
            Console.WriteLine("3) Finnhub API");

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
                    _finnhubAPIConnection.Start(this);
                    break;
                default:
                    Run();
                    break;
            }

        }

        public App()
        {
            _finnhubAPIConnection = new FinnhubAPIConnection();

        }
    }
}
