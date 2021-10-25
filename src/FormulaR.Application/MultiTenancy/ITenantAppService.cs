using Abp.Application.Services;
using FormulaR.MultiTenancy.Dto;

namespace FormulaR.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

