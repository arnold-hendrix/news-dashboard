using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

namespace HomeDashboard
{
    public class ApiResponseProcessor
    {
        private string apiKey = "91ebd4279b9b42b08c38d4d9b6f6ba58"; // api key for news api access.
        public string ApiKey
        {
            get
            {
                return apiKey;
            }
            private set
            {
                apiKey = value;
            }
        }
        
        // function that calls news api and parses json response object into a list of ApiResponseModel objects, if call is successful.
        public async Task<List<ApiResponseModel>> LoadArticles(string _category, string _keyword)
        {
            string url = "";
            string country = "ca";
            string keyword = _keyword;
            string category = _category;

            if (category == "general" || category == "sports" || category == "technology") // specify category parameter for api call.
            {
                url = $"https://newsapi.org/v2/top-headlines?country={country}&category={category}&apiKey={ApiKey}";
            }
            else if (keyword == "covid")  // specify keyword parameter "q" for api call.
            {
                url = $"https://newsapi.org/v2/top-headlines?country={country}&q={keyword}&apiKey={ApiKey}";
            }
            else  // default to returning all news articles making headlines in Canada if no other parameters are specified.
            {
                url = $"https://newsapi.org/v2/top-headlines?country={country}&apiKey={ApiKey}";
            }

            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))  // wait on HttpClient object to get a response.
            {
                if (response.IsSuccessStatusCode)  // parse response into list of ApiResponseModel objects if call is successful.
                {
                    ApiResponseResults apiResponse = await response.Content.ReadAsAsync<ApiResponseResults>();
                    return apiResponse.Articles;
                }
                else // return reason for failure if HttpClient is unsuccessful.
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }
    }
}
