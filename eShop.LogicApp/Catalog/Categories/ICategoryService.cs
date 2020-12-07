using eShop.ViewModel.Catalog.Categories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace eShop.LogicApp.Catalog.Categories
{
    public interface ICategoryService
    {
        Task<List<CategoryVm>> GetAll(string languageId);
    }
}
