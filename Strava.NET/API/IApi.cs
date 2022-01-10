using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StravaSharp.API
{
    internal interface IApi
    {
        string BaseUrl { get; set; }

        Task<object> HttpGetAsync(string url_parameters, StringContent string_content);
        Task<object> HttpPostAsync(string url_parameters, StringContent string_content);
        Task<object> HttpPutAsync(string url_parameters, StringContent string_content);
        Task<object> HttpDeleteAsync(string url_parameters, StringContent string_content);
    }
}
