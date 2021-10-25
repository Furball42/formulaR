using System.Collections.Generic;
using FormulaR.Roles.Dto;

namespace FormulaR.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}