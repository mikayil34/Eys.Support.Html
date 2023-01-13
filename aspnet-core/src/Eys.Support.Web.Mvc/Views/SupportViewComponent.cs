using Abp.AspNetCore.Mvc.ViewComponents;

namespace Eys.Support.Web.Views
{
    public abstract class SupportViewComponent : AbpViewComponent
    {
        protected SupportViewComponent()
        {
            LocalizationSourceName = SupportConsts.LocalizationSourceName;
        }
    }
}
