using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Identity.Client;

namespace OutlookRESTAPI_CSharpApp_Basic
{
    class AuthHelper
    {
        private static string ClientId = "ENTER_YOUR_CLIENT_ID_HERE";

        public static PublicClientApplication PublicClientApp = new PublicClientApplication(ClientId);

        internal static string GetAuthToken(string[] scopes)
        {

            AuthenticationResult authResult;
            try
            {
                // In production apps, try using AcquireTokenSilentAsync first as it attempts to aquire access token from cache.
                authResult = PublicClientApp.AcquireTokenAsync(scopes).Result;
            }
            catch (Exception exx)
            {
                Console.WriteLine($"Error Acquiring Token:{System.Environment.NewLine}{exx}");
                return null;
            }

            return authResult.AccessToken;
        }
    }
}
