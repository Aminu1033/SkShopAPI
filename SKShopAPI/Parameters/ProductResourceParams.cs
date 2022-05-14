using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SKShopAPI.Parameters
{
    public class ProductResourceParams : PriceFilter
    {
        public string SearchQuery { get; set; }
        public string Category { get; set; }

        public bool Exact { get; set; }

        public bool ItemsOfTheWeek { get; set; }
        public bool NoPaging { get; set; }

        public string Color {get; set; }
    }
}
