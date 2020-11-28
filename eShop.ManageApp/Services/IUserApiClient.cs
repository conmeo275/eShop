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
        Task<ApiResult<string>> Authenticate(LoginRequest request);

        Task<ApiResult<PagedResult<UserVm>>> GetUsersPagings(GetUserPagingRequest request);

        Task<ApiResult<bool>> RegisterUser(RegisterRequest registerRequest);

        Task<ApiResult<bool>> UpdateUser(Guid id, UserUpdateRequest request);

        Task<ApiResult<UserVm>> GetById(Guid id);
    }
}
