using eShop.ViewModel.Catalog.Product;
using eShop.ViewModel.Catalog.Product.Manage;
using eShop.ViewModel.Common;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace eShop.LogicApp.Catalog.Products
{
    public interface IManageProductService
    {
        Task<int> Create(CreateRequest req);

        Task<int> Update(UpdateRequest req);

        Task<bool> UpDatePrice(int productId, decimal newPrice);

        Task<bool> UpDateStock(int productId, int addQuantity);

        Task<int> Delete(int productId);

        Task AddViewCount(int productId);

        Task<PagedResult<ProductViewModel>> GetAllPaging(GetProductPagingRequestManage req);

        Task<int> Addimages(int productId, List<IFormFile> files);

        Task<int> Removeimages(int imageId);

        Task<int> Updateimages(int imageId, string caption, bool isDefault);

        Task<List<ProductImageViewModel>> GetListImage(int productId);
    }
}
