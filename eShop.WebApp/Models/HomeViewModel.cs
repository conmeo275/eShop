using eShop.ViewModel.Catalog.Products;
using eShop.ViewModel.Utilities.Slides;
using System.Collections.Generic;

namespace eShop.WebApp.Models
{
    public class HomeViewModel
    {
        public List<SlideVm> Slides { get; set; }

        public List<ProductVm> FeaturedProducts { get; set; }
    }
}
