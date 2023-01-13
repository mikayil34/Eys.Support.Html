using System.Collections.Generic;
using Eys.Support.Roles.Dto;

namespace Eys.Support.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}
