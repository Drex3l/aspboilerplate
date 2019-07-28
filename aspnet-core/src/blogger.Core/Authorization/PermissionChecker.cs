using Abp.Authorization;
using blogger.Authorization.Roles;
using blogger.Authorization.Users;

namespace blogger.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
