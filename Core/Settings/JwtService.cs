using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;
using JWT;
using JWT.Algorithms;
using JWT.Serializers;
using Microsoft.Extensions.Options;
using LOH_UserManagement.Entities;

namespace LOH_UserManagement.Core.Settings
{
    public static class JwtService
    {
        public static string GenerateToken(LOHUser user, IOptions<JwtData> options)
        {
            var jWTData = options.Value;

            var claims = new Dictionary<string, object>
            {
                { ClaimTypes.NameIdentifier, user.Id.ToString() },
                { ClaimTypes.Email, user.Email },
                { ClaimTypes.Name, user.UserName },
                { "Fullname", user.Fullname },
                { "IsAdmin", user.IsAdmin },
                { "IsBuyer", user.IsBuyer },
                { "IsSeller", user.IsSeller },
                { "IsEmailVerified", user.IsEmailVerified }
            };

            var payload = new Dictionary<string, object>
            {
                { "iss", jWTData.Issuer },
                { "aud", jWTData.Audience },
                { "exp", DateTime.Now + jWTData.TokenLifeTime},
                { "iat", new DateTimeOffset(DateTime.UtcNow).ToUnixTimeSeconds() },
                { "nbf", new DateTimeOffset(DateTime.UtcNow).ToUnixTimeSeconds() },
                { "claims", claims }
            };

            IJwtAlgorithm algorithm = new HMACSHA256Algorithm(); // symmetric
            IJsonSerializer serializer = new JsonNetSerializer();
            IBase64UrlEncoder urlEncoder = new JwtBase64UrlEncoder();
            IJwtEncoder encoder = new JwtEncoder(algorithm, serializer, urlEncoder);

            var token = encoder.Encode(payload, jWTData.Secret);
            return token;
        }
    }
}