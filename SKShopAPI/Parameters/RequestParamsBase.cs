using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SKShopAPI.Parameters
{
    public class RequestParamsBase
    {
        private const int _maxPageSize = 50;
        private int _pageSize = 20;

        public int PageNumber { get; set; } = 1;
        public int PageSize
        {
            get => _pageSize;

            set => _pageSize = value > _maxPageSize ? _maxPageSize : value;
        }

    }
}
