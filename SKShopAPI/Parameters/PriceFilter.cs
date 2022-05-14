using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SKShopAPI.Parameters
{
    public class PriceFilter : RequestParamsBase
    {
        public bool LessThan50 { get; set; }
        public bool Between50And100 { get; set; }
        public bool HigherThan100 { get; set; } 
    }
}
