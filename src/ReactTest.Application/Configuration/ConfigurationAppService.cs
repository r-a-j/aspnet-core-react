using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using ReactTest.Configuration.Dto;

namespace ReactTest.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : ReactTestAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
