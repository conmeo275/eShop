using eShop.ViewModel.Common;
using eShop.ViewModel.System.Languages;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace eShop.LogicApp.System.Languages
{
    public interface ILanguageService
    {
        Task<ApiResult<List<LanguageVm>>> GetAll();
    }
}