using eShop.ViewModel.Common;
using System.Collections.Generic;

namespace eShop.ViewModel.Catalog.Products
{
    public class CategoryAssignRequest
    {
        public int Id { get; set; }
        public List<SelectItem> Categories { get; set; } = new List<SelectItem>();
    }
}