using System.Collections.Generic;
using Eys.Support.Roles.Dto;

namespace Eys.Support.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
