using System;
using System.Collections.Generic;
using System.Text;
using static FinnhubAPI.Classes.EarningsClasses;

namespace FinanceConsoleApp.Interfaces
{
    public interface IFinnhubAPIConnection
    {
        void Start(App app);
        void PresentEarningsArr(Earning[] earnings);
        void PresentFinnhubMainMenu();
    }
}
