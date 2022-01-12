using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StravaSharp.Client
{
    public class AppClient
    {
        public int ClientId { get; set; }

        public string ClientSecret { get; set; }
        
        public AppClient(int client_id, string client_secret)
        {
            ClientId = client_id;
            ClientSecret = client_secret;
        }

    }
}
