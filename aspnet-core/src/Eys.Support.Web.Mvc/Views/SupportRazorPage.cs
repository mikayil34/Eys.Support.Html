﻿using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace Eys.Support.Web.Views
{
    public abstract class SupportRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected SupportRazorPage()
        {
            LocalizationSourceName = SupportConsts.LocalizationSourceName;
        }
    }
}
