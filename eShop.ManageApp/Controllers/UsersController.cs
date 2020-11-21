using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eShop.ManageApp.Services;
using eShop.ViewModel.System.Users;
using Microsoft.AspNetCore.Mvc;

namespace eShop.ManageApp.Controllers
{
    public class UsersController : Controller
    {
        private readonly IUserApiClient _userApiClient;

        public UsersController(IUserApiClient userApiClient)
        {
            _userApiClient = userApiClient;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginRequest request)
        {
            if (!ModelState.IsValid)
                return View(ModelState);

            var token = await _userApiClient.Authenticate(request);

            return View(token);
        }
    }
}
