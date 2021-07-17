using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeDashboard
{
    public class ApiResponseModel
    {
        public string Title { get; set; }  // one of the desired properties from json object response.
        public string Content { get; set; }  // another property from the json object.
    }
}
