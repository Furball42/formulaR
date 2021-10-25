using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using FormulaR.Controllers;

namespace FormulaR.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : FormulaRControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
