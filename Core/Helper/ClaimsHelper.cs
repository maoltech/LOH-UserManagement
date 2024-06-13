using System.Security.Claims;

namespace LOH_UserManagement.Core.Helper
{


    public static class ClaimsHelper
    {
        public static string GetUserId(ClaimsPrincipal user)
        {
            var userIdClaim = user.FindFirst(ClaimTypes.NameIdentifier); // Retrieve the user's Id claim
            return userIdClaim?.Value;
        }
    }
}
