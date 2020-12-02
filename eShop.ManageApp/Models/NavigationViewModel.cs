using eShop.ViewModel.System.Languages;
using System.Collections.Generic;

namespace eShop.ManageApp.Models
{
    public class NavigationViewModel
    {
        public List<LanguageVm> Languages { get; set; }

        public string CurrentLanguageId { get; set; }
    }
}
