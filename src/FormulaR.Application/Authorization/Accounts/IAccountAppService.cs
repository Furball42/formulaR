using System.Threading.Tasks;
using Abp.Application.Services;
using FormulaR.Authorization.Accounts.Dto;

namespace FormulaR.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
