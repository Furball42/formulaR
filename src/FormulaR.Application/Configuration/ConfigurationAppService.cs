using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using FormulaR.Configuration.Dto;

namespace FormulaR.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : FormulaRAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
