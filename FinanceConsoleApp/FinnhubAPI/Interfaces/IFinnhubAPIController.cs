using System;
using System.Collections.Generic;
using System.Text;
using static FinnhubAPI.Classes.AnalystsPriceTargetClasses;
using static FinnhubAPI.Classes.EarningsClasses;

namespace FinnhubAPI.Interfaces
{
    public interface IFinnhubAPIController
    {
        Earning[] GetEarningsForSymbol(string symbol);
        AnalystsPriceTarget GetAnalystsPriceTargetForSymbol(string symbol);

    }
}
