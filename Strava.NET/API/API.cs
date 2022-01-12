using StravaSharp.API;
using System.Globalization;

namespace StravaSharp
{
    public class StravaAPI : IApi
    {
        //Variables
        protected readonly bool UsesComma = false;
        protected readonly string baseURL;
        protected HttpClient httpClient = new HttpClient();

        protected StravaAPI(string base_url)
        {
            baseURL = base_url;
            if (CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator.Equals(","))
                UsesComma = true;
        }

        public string BaseUrl { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Task<object> HttpDeleteAsync(string url_parameters, StringContent string_content)
        {
            throw new NotImplementedException();
        }

        public Task<object> HttpGetAsync(string url_parameters, StringContent string_content)
        {
            throw new NotImplementedException();
        }

        public Task<object> HttpPostAsync(string url_parameters, StringContent string_content)
        {
            throw new NotImplementedException();
        }

        public Task<object> HttpPutAsync(string url_parameters, StringContent string_content)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// GET request to a baseUrl + query_parameter
        /// </summary>
        /// <param name="query_parameter">Query string</param>
        /// <returns>The returned string</returns>
        protected async Task<string> GET(string query_parameter)
        {
            try
            {
                using var httpResponse = await httpClient.GetAsync(baseURL + query_parameter, HttpCompletionOption.ResponseHeadersRead);

                if (httpResponse.IsSuccessStatusCode)
                {
                    if (httpResponse.Content is object && httpResponse.Content.Headers.ContentType.MediaType == "application/json")
                    {
                        return await httpResponse.Content.ReadAsStringAsync();
                    }
                    else
                    {
                        Console.WriteLine("HTTP Response was invalid and cannot be deserialised.");
                    }
                } 
                else
                {
                    if (httpResponse.Content is object && httpResponse.Content.Headers.ContentType.MediaType == "application/json")
                    {
                        return await httpResponse.Content.ReadAsStringAsync();
                    }
                    else
                    {
                        Console.WriteLine("HTTP Response was invalid and cannot be deserialised.");
                    }
                }
            }
            catch (Exception ex)
            {

            }

            return "{\"message\":\"Authorization Error\",\"errors\":[{\"resource\":\"Athlete\",\"field\":\"access_token\",\"code\":\"invalid\"}]}";
        }

        /// <summary>
        /// POST request to a baseUrl + query_parameter
        /// </summary>
        /// <param name="query_parameter">Query string</param>
        /// <returns>The returned string</returns>
        protected async Task<object> POST(string query_parameter, HttpContent content)
        {
            try
            {
                using var httpResponse = await httpClient.PostAsync(new Uri(baseURL + query_parameter), content);

                try
                {
                    httpResponse.EnsureSuccessStatusCode(); // throws if not 200-299
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message + " on URL: " + baseURL + query_parameter + " with content: " + await content.ReadAsStringAsync());
                    return "{}";
                }

                if (httpResponse.Content is object && httpResponse.Content.Headers.ContentType.MediaType == "application/json")
                {
                    return await httpResponse.Content.ReadAsStringAsync();
                }
                else
                {
                    Console.WriteLine("HTTP Response was invalid and cannot be deserialised.");
                }
            }
            catch
            {
                Console.WriteLine("Please connect to the internet!");
                Console.WriteLine(baseURL + query_parameter + " | " + content.ToString());
            }

            return "{}";
        }

    }
}