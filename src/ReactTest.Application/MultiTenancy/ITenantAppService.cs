using Abp.Application.Services;
using Abp.Application.Services.Dto;
using ReactTest.MultiTenancy.Dto;

namespace ReactTest.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

