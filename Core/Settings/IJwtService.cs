

using LOH_UserManagement.Entities;

namespace LOH_UserManagement.Core.Settings
{
    public interface IJwtService
    {
        public string GenerateToken(LOHUser user, List<string> userRoles);
    }
}
