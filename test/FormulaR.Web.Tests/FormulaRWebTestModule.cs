using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using FormulaR.EntityFrameworkCore;
using FormulaR.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace FormulaR.Web.Tests
{
    [DependsOn(
        typeof(FormulaRWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class FormulaRWebTestModule : AbpModule
    {
        public FormulaRWebTestModule(FormulaREntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(FormulaRWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(FormulaRWebMvcModule).Assembly);
        }
    }
}