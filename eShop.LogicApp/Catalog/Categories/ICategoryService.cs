using eShop.ViewModel.Catalog.Categories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace eShop.LogicApp.Catalog.Categories
{
    public interface ICategoryService
    {
        Task<List<CategoryVm>> GetAll(string languageId);

        Task<CategoryVm> GetById(string languageId, int id);
    }
}