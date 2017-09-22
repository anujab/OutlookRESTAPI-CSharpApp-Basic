using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutlookRESTAPI_CSharpApp_Basic
{
    class Program
    {
        static void Main(string[] args)
        {
            //Set the API Endpoint to Graph 'me' endpoint
            var outlookRESTAPIEndpoint = "https://outlook.office365.com/api/v2.0/me/messages?$top=1";

            //Set the scope for API call to user.read
            var scopes = new string[] { "https://outlook.office.com/mail.read" };


            string authToken = AuthHelper.GetAuthToken(scopes);

            if (authToken != null)
            {
                Console.WriteLine(HttpHelper.SendAsync(outlookRESTAPIEndpoint, authToken));
            }
        }
    }
}
