using System.Threading.Tasks;
using FormulaR.Configuration.Dto;

namespace FormulaR.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
