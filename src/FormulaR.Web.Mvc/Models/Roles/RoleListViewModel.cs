using System.Collections.Generic;
using FormulaR.Roles.Dto;

namespace FormulaR.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}
