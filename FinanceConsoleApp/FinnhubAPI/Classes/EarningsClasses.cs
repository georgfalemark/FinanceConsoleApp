using System;
using System.Collections.Generic;
using System.Text;

namespace FinnhubAPI.Classes
{
    public class EarningsClasses
    {
        public class Rootobject
        {
            public Earning[] Earnings { get; set; }
        }

        public class Earning
        {
            public float actual { get; set; }
            public float estimate { get; set; }
            public string period { get; set; }
            public string symbol { get; set; }
        }
    }
}
