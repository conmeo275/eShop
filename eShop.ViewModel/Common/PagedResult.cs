﻿using System.Collections.Generic;

namespace eShop.ViewModel.Common
{
    public class PagedResult<T> : PagedResultBase
    {
        public List<T> Items { set; get; }
    }
}