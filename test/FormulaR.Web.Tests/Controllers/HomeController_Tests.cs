using System.Threading.Tasks;
using FormulaR.Models.TokenAuth;
using FormulaR.Web.Controllers;
using Shouldly;
using Xunit;

namespace FormulaR.Web.Tests.Controllers
{
    public class HomeController_Tests: FormulaRWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}