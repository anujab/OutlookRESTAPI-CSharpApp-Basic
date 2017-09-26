using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace OutlookRESTAPI_CSharpApp_Basic
{
    class Program
    {
        static void Main(string[] args)
        {
            string authToken = AuthHelper.GetAuthToken(Constants.Scopes);

            if (authToken != null)
            {
                string response = HttpHelper.SendAsync(Constants.OutlookRestapiEndpoint, authToken);
                dynamic responseObject = JObject.Parse(response);
                var mailitem = responseObject.value[0];
                Console.WriteLine("Id : " + mailitem.Id + "\nSubject : " + mailitem.Subject + "\nBody : " + mailitem.Body);
            }
        }
    }
}
