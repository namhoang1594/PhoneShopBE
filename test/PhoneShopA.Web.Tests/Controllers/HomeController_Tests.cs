using System.Threading.Tasks;
using PhoneShopA.Models.TokenAuth;
using PhoneShopA.Web.Controllers;
using Shouldly;
using Xunit;

namespace PhoneShopA.Web.Tests.Controllers
{
    public class HomeController_Tests: PhoneShopAWebTestBase
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