using System.Threading.Tasks;
using Abp.Application.Services;
using blogger.Sessions.Dto;

namespace blogger.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
