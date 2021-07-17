using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeDashboard
{
    public class ApiResponseResults
    {
        public List<ApiResponseModel> Articles { get; set; }  // name of root-level key containing articles returned in json object.
    }
}
