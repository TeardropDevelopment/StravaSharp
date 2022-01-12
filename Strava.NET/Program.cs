using Microsoft.Win32;
using Strava.Authentication;
using StravaSharp.API;
using StravaSharp.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace StravaSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            IStravaAPI stravaAPI = StravaFactory.GetApiInstance(new AppClient(60628, "820e2e72db310629e037d32edbbe3b7d894395d1"));
            stravaAPI.OAuth();

            stravaAPI.CreateActivity(new Activity { Description = "Moin", Name = "API Test #1", Distance = 1, ElapsedTime = 10, Type = ActivityType.Run, StartDateLocal = DateTime.Now });

            //WebAuthentication auth = new WebAuthentication();
            //auth.AuthCodeReceived += delegate (object sender, AuthCodeReceivedEventArgs args) { Console.WriteLine("Auth Code: " + args.AuthCode); };
            //auth.AccessTokenReceived += delegate (object sender, TokenReceivedEventArgs args) { Console.WriteLine("Access Token: " + args.Token); };
            //auth.GetTokenAsync("60628", "820e2e72db310629e037d32edbbe3b7d894395d1", Scope.Public, 5000);

            //string mutex_id = "TreadRun";
            //using (Mutex mutex = new Mutex(false, mutex_id))
            //{
            //    OAuth oAuth = new OAuth();
            //    OAuth.OnArgs += OAuth_OnArgs;
            //    if (!mutex.WaitOne(0, false))
            //    {
            //        Console.WriteLine("Alredy running");
            //        Console.WriteLine(args[0]);

            //        // Send args to tcp socket of first instance

            //        oAuth.SendArgsToInstance(args);

            //        return;
            //    }
            //    // Do stuff

            //    Console.WriteLine("started");

            //    Task.Run(() => oAuth.StartListenerAsync());

            //    var uri = $"https://www.strava.com/oauth/authorize?client_id=60628&response_type=code&redirect_uri=strava://localhost&scope=activity:write,read_all";
            //    var psi = new System.Diagnostics.ProcessStartInfo();
            //    psi.UseShellExecute = true;
            //    psi.FileName = uri;
            //    System.Diagnostics.Process.Start(psi);

            //    Console.ReadLine();

            //}

            ////System.Diagnostics.Process.Start("https://www.strava.com/oauth/authorize?client_id=60628&response_type=code&redirect_uri=https://localhost/&scope=activity:write,read/");

            //string protocol = "strava";

            //if (args.Any())
            //{
            //    foreach (var item in args)
            //    {
            //        Console.WriteLine(item);
            //    }

            //    Console.ReadLine();
            //}
            //else
            //{
            //    var uri = $"https://www.strava.com/oauth/authorize?client_id=60628&response_type=code&redirect_uri=http://localhost:5000&scope=activity:write,read_all";
            //    var psi = new System.Diagnostics.ProcessStartInfo();
            //    psi.UseShellExecute = true;
            //    psi.FileName = uri;
            //    System.Diagnostics.Process.Start(psi);

            //    string[] prefixes = new string[] { "http://localhost:5000/" };
            //    if (!HttpListener.IsSupported)
            //    {
            //        Console.WriteLine("Windows XP SP2 or Server 2003 is required to use the HttpListener class.");
            //        return;
            //    }
            //    // URI prefixes are required,
            //    // for example "http://contoso.com:8080/index/".
            //    if (prefixes == null || prefixes.Length == 0)
            //        throw new ArgumentException("prefixes");

            //    // Create a listener.
            //    HttpListener listener = new HttpListener();
            //    // Add the prefixes.
            //    foreach (string s in prefixes)
            //    {
            //        listener.Prefixes.Add(s);
            //    }
            //    listener.Start();
            //    Console.WriteLine("Listening...");
            //    // Note: The GetContext method blocks while waiting for a request.
            //    HttpListenerContext context = listener.GetContext();
            //    // Obtain a request object
            //    HttpListenerRequest request = context.Request;
            //    Console.WriteLine(request.Url);

            //    // Obtain a response object.
            //    HttpListenerResponse response = context.Response;
            //    // Construct a response.
            //    string responseString = "<HTML><BODY> Hello world!</BODY></HTML>";
            //    byte[] buffer = System.Text.Encoding.UTF8.GetBytes(responseString);
            //    // Get a response stream and write the response to it.
            //    response.ContentLength64 = buffer.Length;
            //    System.IO.Stream output = response.OutputStream;
            //    output.Write(buffer, 0, buffer.Length);
            //    // You must close the output stream.
            //    output.Close();
            //    listener.Stop();
            //}
            //else
            //{
            //    var key = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\Classes").CreateSubKey($"{protocol}");
            //    key.SetValue("", $"URL:{protocol} Protocol");
            //    key.SetValue("URL Protocol", "");
            //    var subkey = key.CreateSubKey("shell\\open\\command");
            //    var execPath = Path.Combine(Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location), Environment.ProcessPath);
            //    subkey.SetValue("", $"{execPath} %1");
            //    subkey.Close();
            //    key.Close();

            //    Console.WriteLine("Successfully registered the custom protocol handler");

            //    System.Environment.Exit(205);
            //}


            //IStravaAPI strava = StravaFactory.GetApiInstance(new AppClient(60628, "820e2e72db310629e037d32edbbe3b7d894395d1"));

        }

        private static void OAuth_OnArgs(object? sender, string e)
        {
            Console.WriteLine("Args: " + e);
        }
    }
}
