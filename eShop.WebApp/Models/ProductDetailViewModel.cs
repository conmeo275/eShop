using eShop.ViewModel.Catalog.Categories;
using eShop.ViewModel.Catalog.ProductImages;
using eShop.ViewModel.Catalog.Products;
using System.Collections.Generic;

namespace eShop.WebApp.Models
{
    public class ProductDetailViewModel
    {
        public CategoryVm Category { get; set; }

        public ProductVm Product { get; set; }

        public List<ProductVm> RelatedProducts { get; set; }

        public List<ProductImageViewModel> ProductImages { get; set; }
    }
}