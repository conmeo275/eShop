using eShop.ViewModel.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShop.ViewModel.System.Users
{
    public class GetUserPagingRequest : PagingRequestBase
    {
        public string Keyword { get; set; }
    }
}