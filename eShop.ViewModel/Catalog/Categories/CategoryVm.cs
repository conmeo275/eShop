using System;
using System.Collections.Generic;
using System.Text;

namespace eShop.ViewModel.Catalog.Categories
{
    public class CategoryVm
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int? ParentId { get; set; }
    }
}
