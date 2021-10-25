using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using FormulaR.Configuration;

namespace FormulaR.Web.Host.Startup
{
    [DependsOn(
       typeof(FormulaRWebCoreModule))]
    public class FormulaRWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public FormulaRWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(FormulaRWebHostModule).GetAssembly());
        }
    }
}
