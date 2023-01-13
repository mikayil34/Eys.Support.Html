using System.Collections.Generic;
using Eys.Support.Roles.Dto;

namespace Eys.Support.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}