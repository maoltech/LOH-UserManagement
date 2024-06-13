


using Core.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Security.Claims;
using System.Diagnostics.Metrics;
using System;

namespace LOH_UserManagement.Core.Helper
{
    public class Utilities
    {
        private static readonly Random random = new Random();
        private static int counter = 0;
        public static ResponseDto<T> CreateResponse<T>(string message,
           ModelStateDictionary errs, T data,  int? responseCode = 0)
        {
            var errors = new Dictionary<string, string>();
            if (errs != null)
            {
                foreach (var err in errs)
                {
                    var counter = 0;
                    var key = err.Key;
                    var errVals = err.Value;
                    foreach (var errMsg in errVals.Errors)
                    {
                        errors.Add($"{(counter + 1)} - {key}", errMsg.ErrorMessage);
                        counter++;
                    }
                }
            }

            var obj = new ResponseDto<T>()
            {
                Message = message,
                Errs = errors,
                Data = data,
                ResponseCode = responseCode ?? 0
            };
            return obj;
        }

        public static string EmailHtmlStringTemplate(string fullName, string routePath, Dictionary<string, string> queryParams, string templateFilename, HttpContext context)
        {
            //get the base address
            var baseUrl = BaseAddress(context);

            //get the email link address
            var link = GetEmailLink(queryParams, routePath, context);

            //Read from the template file and construct the email template
            var templatePath = string.Join("\\MailView", templateFilename);
            var htmlContent = File.ReadAllText(templatePath);
            htmlContent = htmlContent.Replace("[name]", fullName);
            htmlContent = htmlContent.Replace("[baseAddress]", baseUrl);
            htmlContent = htmlContent.Replace("[link]", link);

            return htmlContent;
        }

        public static string BaseAddress(HttpContext context)
        {
            return context.Request.Scheme + "://" + context.Request.Host;
        }

        //Create a url given the url Path
        public static string CreateUrl(string urlPath, HttpContext context)
        {
            return string.Join('/', BaseAddress(context), urlPath);
        }

        //generate link to be embeded in the emails
        public static string GetEmailLink(Dictionary<string, string> queryParams, string urlPath, HttpContext context)
        {
            var path = urlPath.StartsWith('/') ? urlPath.Substring(1) : urlPath;
            var baseUrl = CreateUrl(path, context);
            //construct the account confirmation link
            return QueryHelpers.AddQueryString(baseUrl, queryParams);
        }

        public static string GetUserId(ClaimsPrincipal user)
        {
            var userIdClaim = user.FindFirst(ClaimTypes.NameIdentifier);

            if (userIdClaim == null)
            {
                throw new UnauthorizedAccessException("User's Id claim not found");
            }

            return userIdClaim.Value;
        }


        public static string GenerateUniqueString()
        {
            int uniqueNumber = Interlocked.Increment(ref counter);
            int randomNumber = random.Next(10000, 99999); // Generates a random 5-digit number

            return $"GC-{uniqueNumber.ToString("D5")}-{randomNumber:D5}";
        }


        public static byte[] ConvertBase64ToByteArray(string base64String)
        {
            try
            {
                byte[] byteArray = Convert.FromBase64String(base64String);
                return byteArray;
            }
            catch (FormatException ex)
            {
                throw new ArgumentException("Invalid base64 string.", ex);
            }
        }



    }
}
