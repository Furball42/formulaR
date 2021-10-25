using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace FormulaR.Controllers
{
    public abstract class FormulaRControllerBase: AbpController
    {
        protected FormulaRControllerBase()
        {
            LocalizationSourceName = FormulaRConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
