using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using blogger.Configuration.Dto;

namespace blogger.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : bloggerAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
