using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace OutlookRESTAPI_CSharpApp_Basic
{
    class HttpHelper
    {
        /// <summary>
        /// Perform an HTTP GET request to a URL using an HTTP Authorization header
        /// </summary>
        /// <param name="url">The URL</param>
        /// <param name="token">The token</param>
        /// <returns>String containing the results of the GET operation</returns>
        public static string SendAsync(string url, string token)
        {
            var httpClient = new System.Net.Http.HttpClient();
            try
            {
                var request = new System.Net.Http.HttpRequestMessage(System.Net.Http.HttpMethod.Get, url);
                //Add the token in Authorization header
                request.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
                var response = httpClient.SendAsync(request).Result;

                if (response.IsSuccessStatusCode)
                {
                    var content = response.Content.ReadAsStringAsync().Result;
                    return content;
                }

                return "HTTP Request Failed.  Status Code : " + response.StatusCode;
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
    }
}
