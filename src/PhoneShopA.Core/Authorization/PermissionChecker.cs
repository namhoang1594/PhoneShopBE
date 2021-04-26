using Abp.Authorization;
using PhoneShopA.Authorization.Roles;
using PhoneShopA.Authorization.Users;

namespace PhoneShopA.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
