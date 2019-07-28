using Abp.Application.Services;
using Abp.Application.Services.Dto;
using blogger.MultiTenancy.Dto;

namespace blogger.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

