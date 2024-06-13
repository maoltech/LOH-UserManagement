using Microsoft.AspNetCore.Http;

namespace LOH_UserManagement.Core.Helper
{
    public class UrlHelper
    {
        public static string BaseAddress(HttpContext context)
        {
            return context.Request.Scheme + "://" + context.Request.Host;
        }

        public static string BaseAddress(HttpContext context, string path)
        {
            return context.Request.Scheme + "://" + path;
        }

        //Create a url given the url Path
        public static string CreateUrl(string urlPath, HttpContext context)
        {
            return string.Join('/', BaseAddress(context), urlPath);
        }

        public static string CreateUrl(string urlPath, string url, HttpContext context)
        {
            return string.Join('/', BaseAddress(context, url), urlPath);
        }
    }
}
