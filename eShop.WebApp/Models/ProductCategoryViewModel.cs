using eShop.ViewModel.Catalog.Categories;
using eShop.ViewModel.Catalog.Products;
using eShop.ViewModel.Common;

namespace eShop.WebApp.Models
{
    public class ProductCategoryViewModel
    {
        public CategoryVm Category { get; set; }

        public PagedResult<ProductVm> Products { get; set; }
    }
}