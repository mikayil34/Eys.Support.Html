using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Abp.Application.Services.Dto;
using Abp.AspNetCore.Mvc.Authorization;
using Eys.Support.Authorization;
using Eys.Support.Controllers;
using Eys.Support.MultiTenancy;

namespace Eys.Support.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [AbpMvcAuthorize(PermissionNames.Pages_Tenants)]
    public class TenantsController : SupportControllerBase
    {
        private readonly ITenantAppService _tenantAppService;

        public TenantsController(ITenantAppService tenantAppService)
        {
            _tenantAppService = tenantAppService;
        }

        public ActionResult Index() => View();

        public async Task<ActionResult> EditModal(int tenantId)
        {
            var tenantDto = await _tenantAppService.GetAsync(new EntityDto(tenantId));
            return PartialView("_EditModal", tenantDto);
        }
    }
}
