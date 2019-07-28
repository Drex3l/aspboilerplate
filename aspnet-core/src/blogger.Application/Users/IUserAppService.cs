using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using blogger.Roles.Dto;
using blogger.Users.Dto;

namespace blogger.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedUserResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
