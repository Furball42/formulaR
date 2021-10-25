using Abp.Authorization;
using FormulaR.Authorization.Roles;
using FormulaR.Authorization.Users;

namespace FormulaR.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
