using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutlookRESTAPI_CSharpApp_Basic
{
    class Constants
    {
        internal const string OutlookRestapiEndpoint = "https://outlook.office.com/api/v2.0/me/messages?$top=1";

        internal static readonly string[] Scopes = new string[] { "https://outlook.office.com/mail.read" };
    }
}
