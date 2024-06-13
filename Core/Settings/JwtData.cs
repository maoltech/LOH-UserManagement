
namespace LOH_UserManagement.Core.Settings
{
    public class JwtData
    {
        public const string Data = "JWTConfigurations";
        public TimeSpan TokenLifeTime { get; set; }

        public string SecretKey { get; set; }

        public string Issuer { get; set; }

        public string Audience { get; set; }
    }
}
