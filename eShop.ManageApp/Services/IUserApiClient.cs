using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eShop.ViewModel.Common;
using eShop.ViewModel.System.Users;

namespace eShop.ManageApp.Services
{
    public interface IUserApiClient
    {
        Task<string> Authenticate(LoginRequest request);

        Task<PagedResult<UserVm>> GetUsersPagings(GetUserPagingRequest request);

        Task<bool> RegisterUser(RegisterRequest registerRequest);
    }
}
