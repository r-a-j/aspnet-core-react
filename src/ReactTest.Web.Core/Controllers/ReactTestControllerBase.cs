using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace ReactTest.Controllers
{
    public abstract class ReactTestControllerBase: AbpController
    {
        protected ReactTestControllerBase()
        {
            LocalizationSourceName = ReactTestConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
