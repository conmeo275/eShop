using eShop.ViewModel.Utilities.Slides;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace eShop.LogicApp.Utilities.Slides
{
    public interface ISlideService
    {
        Task<List<SlideVm>> GetAll();
    }
}
