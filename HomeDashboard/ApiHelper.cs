using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;

namespace HomeDashboard
{
    public static class ApiHelper  // class used to configure HttpClient.
    {
        public static HttpClient ApiClient { get; set; }  // static class  - single HttpClient object for entire application.

        public static void InitializeClient()  // method to init HttpClient and to specify its request header.
        {
            ApiClient = new HttpClient();  // new HttpClient object.
            ApiClient.DefaultRequestHeaders.Accept.Clear();  // clear the default headers sent with each request.
            ApiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            // specify that we want our HttpClient to return a json object.
        }
    }
}
