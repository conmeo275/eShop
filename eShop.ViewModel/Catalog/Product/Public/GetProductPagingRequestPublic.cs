using eShop.ViewModel.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShop.ViewModel.Catalog.Product.Public
{
    public class GetProductPagingRequestPublic : PagingRequestBase
    {
        public int? CategoryId { get; set; }
    }
}
