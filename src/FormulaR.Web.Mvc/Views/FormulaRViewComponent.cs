using Abp.AspNetCore.Mvc.ViewComponents;

namespace FormulaR.Web.Views
{
    public abstract class FormulaRViewComponent : AbpViewComponent
    {
        protected FormulaRViewComponent()
        {
            LocalizationSourceName = FormulaRConsts.LocalizationSourceName;
        }
    }
}
