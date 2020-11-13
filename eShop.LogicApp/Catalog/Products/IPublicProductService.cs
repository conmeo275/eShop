using eShop.ViewModel.Catalog.Product;
using eShop.ViewModel.Catalog.Product.Public;
using eShop.ViewModel.Common;
using System.Threading.Tasks;

namespace eShop.LogicApp.Catalog.Products
{
    public interface IPublicProductService
    {
        Task<PagedResult<ProductViewModel>> GetAllByCategoryId(GetProductPagingRequestPublic req);
    }
}
