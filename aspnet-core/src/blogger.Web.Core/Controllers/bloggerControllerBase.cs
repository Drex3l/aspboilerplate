using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace blogger.Controllers
{
    public abstract class bloggerControllerBase: AbpController
    {
        protected bloggerControllerBase()
        {
            LocalizationSourceName = bloggerConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
