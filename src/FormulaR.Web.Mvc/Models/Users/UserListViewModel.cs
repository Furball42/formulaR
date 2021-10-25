using System.Collections.Generic;
using FormulaR.Roles.Dto;

namespace FormulaR.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
