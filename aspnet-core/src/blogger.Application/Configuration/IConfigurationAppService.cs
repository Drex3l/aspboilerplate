using System.Threading.Tasks;
using blogger.Configuration.Dto;

namespace blogger.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
