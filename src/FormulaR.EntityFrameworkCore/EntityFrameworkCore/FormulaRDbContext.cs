using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using FormulaR.Authorization.Roles;
using FormulaR.Authorization.Users;
using FormulaR.MultiTenancy;

namespace FormulaR.EntityFrameworkCore
{
    public class FormulaRDbContext : AbpZeroDbContext<Tenant, Role, User, FormulaRDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public FormulaRDbContext(DbContextOptions<FormulaRDbContext> options)
            : base(options)
        {
        }
    }
}
