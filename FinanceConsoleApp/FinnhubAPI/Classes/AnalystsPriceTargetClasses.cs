using System;
using System.Collections.Generic;
using System.Text;

namespace FinnhubAPI.Classes
{
    public class AnalystsPriceTargetClasses
    {
        public class Rootobject
        {
            public AnalystsPriceTarget AnalystsPriceTarget { get; set; }
        }

        public class AnalystsPriceTarget
        {
            public string lastUpdated { get; set; }
            public string symbol { get; set; }
            public int targetHigh { get; set; }
            public int targetLow { get; set; }
            public float targetMean { get; set; }
            public int targetMedian { get; set; }
        }
    }
}
