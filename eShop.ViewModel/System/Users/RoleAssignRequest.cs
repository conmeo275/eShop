using eShop.ViewModel.Common;
using System;
using System.Collections.Generic;

namespace eShop.ViewModel.System.Users
{
    public class RoleAssignRequest
    {
        public Guid Id { get; set; }
        public List<SelectItem> Roles { get; set; } = new List<SelectItem>();
    }
}