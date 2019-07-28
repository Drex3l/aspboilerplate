using System.Threading.Tasks;
using Abp.Application.Services;
using blogger.Authorization.Accounts.Dto;

namespace blogger.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
