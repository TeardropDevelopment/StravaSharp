using StravaSharp.Client;
using StravaSharp.Model;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace StravaSharp.API.Authentication
{
    public class OAuth
    {
        /// <summary>
        /// Start browser and navigate to the Strava OAuth page
        /// </summary>
        /// <param name="client_id">ClientID privided by Strava</param>
        /// <param name="client_secret">Client secret provided by Strava</param>
        /// <param name="scope">The Scope of the access key</param>
        /// <param name="port">Default port is 5000, can be changed if this port is already used by the machine</param>
        /// <returns>The code</returns>
        public string? Authenticate(int client_id, Scope scope, int port = 5000)
        {
            try
            {
                // Start the browser and navigate to strava.com/oauth/authorize
                string text;
                switch (scope)
                {
                    default:
                    case Scope.Read:
                        text = "read";
                        break;
                    case Scope.Write:
                        text = "activity:write";
                        break;
                    case Scope.Full:
                        text = "activity:write,read_all";
                        break;
                }
                var uri = $"https://www.strava.com/oauth/authorize?client_id={client_id}&response_type=code&redirect_uri=http://localhost:{port}&scope={text}&approval_prompt=auto";
                var psi = new System.Diagnostics.ProcessStartInfo();
                psi.UseShellExecute = true;
                psi.FileName = uri;
                System.Diagnostics.Process.Start(psi);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            System.IO.Stream? output = null;
            HttpListener? listener = null;
            string code = string.Empty;

            // callback url
            try
            {
                string[] prefixes = new string[] { $"http://localhost:{port}/" };
                if (!HttpListener.IsSupported)
                {
                    Console.WriteLine("Windows XP SP2 or Server 2003 is required to use the HttpListener class.");
                    return String.Empty;
                }
                // URI prefixes are required,
                if (prefixes == null || prefixes.Length == 0)
                    throw new ArgumentException("prefixes");

                // Create a listener.
                listener = new HttpListener();
                // Add the prefixes.
                foreach (string s in prefixes)
                {
                    listener.Prefixes.Add(s);
                }
                listener.Start();
                // Note: The GetContext method blocks while waiting for a request.
                HttpListenerContext context = listener.GetContext();
                // Obtain a request object
                HttpListenerRequest request = context.Request;
                //var url = request.Url;
                //AccessKey = HttpUtility.ParseQueryString(url?.Query).Get("code");

                #region ParseQueryString

                var url = request.Url;
                NameValueCollection urlParams = HttpUtility.ParseQueryString(url?.Query ?? String.Empty);

                code = urlParams["code"];

                #endregion

                // Obtain a response object.
                HttpListenerResponse response = context.Response;
                // Construct a response.
                string responseString = "<HTML><BODY> You can close this window now!</BODY></HTML>";
                byte[] buffer = System.Text.Encoding.UTF8.GetBytes(responseString);
                // Get a response stream and write the response to it.
                response.ContentLength64 = buffer.Length;
                output = response.OutputStream;
                output.Write(buffer, 0, buffer.Length);
            } 
            catch (Exception ex) 
            {
                Console.WriteLine(ex);
            }
            finally 
            {
                // You must close the output stream.
                output?.Close();
                listener?.Stop();
            }

            return code;
        }
    }
}
