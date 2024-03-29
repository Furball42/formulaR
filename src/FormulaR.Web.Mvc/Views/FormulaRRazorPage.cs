﻿using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace FormulaR.Web.Views
{
    public abstract class FormulaRRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected FormulaRRazorPage()
        {
            LocalizationSourceName = FormulaRConsts.LocalizationSourceName;
        }
    }
}
