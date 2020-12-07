using eShop.ViewModel.Catalog.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eShop.ManageApp.Services
{
    public interface ICategoryApiClient
    {
        Task<List<CategoryVm>> GetAll(string languageId);
    }
}
