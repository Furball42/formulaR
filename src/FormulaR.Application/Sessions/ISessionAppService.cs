using System.Threading.Tasks;
using Abp.Application.Services;
using FormulaR.Sessions.Dto;

namespace FormulaR.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
