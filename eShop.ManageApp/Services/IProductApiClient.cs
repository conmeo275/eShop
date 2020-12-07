using eShop.ViewModel.Catalog.Products;
using eShop.ViewModel.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eShop.ManageApp.Services
{
    public interface IProductApiClient
    {
        Task<PagedResult<ProductVm>> GetPagings(GetManageProductPagingRequest request);

        Task<bool> CreateProduct(ProductCreateRequest request);

        Task<ApiResult<bool>> CategoryAssign(int id, CategoryAssignRequest request);

        Task<ProductVm> GetById(int id, string languageId);
    }
}
