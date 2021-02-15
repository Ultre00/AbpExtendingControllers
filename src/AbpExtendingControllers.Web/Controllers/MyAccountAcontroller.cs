using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using Volo.Abp.Account;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Identity;

namespace AbpExtendingControllers.Web.Controllers
{
    [Dependency(ReplaceServices = true)]
    [ExposeServices(typeof(AccountController))]
    public class MyAccountAcontroller : AccountController
    {
        public MyAccountAcontroller(IAccountAppService accountAppService) : base(accountAppService)
        {
        }

        [HttpGet]
        [Route("my-function")]
        public Task<string> MyFucntion()
        {
            return Task.FromResult("This doesn't work");
        }

        public override Task<IdentityUserDto> RegisterAsync(RegisterDto input)
        {
            throw new Exception("This works");
        }
    }
}