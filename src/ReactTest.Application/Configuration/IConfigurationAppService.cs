using System.Threading.Tasks;
using ReactTest.Configuration.Dto;

namespace ReactTest.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
