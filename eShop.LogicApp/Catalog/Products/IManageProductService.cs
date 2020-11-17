using eShop.ViewModel.Catalog.Product;
using eShop.ViewModel.Catalog.Product.Images;
using eShop.ViewModel.Catalog.Product.Manage;
using eShop.ViewModel.Common;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace eShop.LogicApp.Catalog.Products
{
    public interface IManageProductService
    {
        Task<ProductViewModel> GetById(int productId, string languageId);

        Task<int> Create(CreateRequest req);

        Task<int> Update(UpdateRequest req);

        Task<bool> UpDatePrice(int productId, decimal newPrice);

        Task<bool> UpDateStock(int productId, int addQuantity);

        Task<int> Delete(int productId);

        Task AddViewCount(int productId);

        Task<PagedResult<ProductViewModel>> GetAllPaging(GetProductPagingRequestManage req);

        Task<ProductImageViewModel> GetImageById(int imageId);

        Task<int> AddImage(int productId, ProductImageCreateRequest req);

        Task<int> RemoveImage(int imageId);

        Task<int> UpdateImage(int imageId, ProductImageUpdateRequest req);

        Task<List<ProductImageViewModel>> GetListImages(int productId);
    }
}
