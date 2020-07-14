using Abp.Authorization;
using ReactTest.Authorization.Roles;
using ReactTest.Authorization.Users;

namespace ReactTest.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
