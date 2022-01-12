using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StravaSharp.Model
{
    /// <summary>
    /// A refresh token, access token, and access token expiration date will be issued upon successful authentication.
    /// </summary>
    public class Token
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("token_type")]
        public string? TokenType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("expires_at")]
        public int ExpiresAt { get; set; }

        /// <summary>
        /// The number of seconds since the epoch when the provided access token will expire 
        /// </summary>
        [JsonProperty("expires_in")]
        public int ExpiresIn { get; set; }

        /// <summary>
        /// Seconds until the short-lived access token will expire 
        /// </summary>
        [JsonProperty("refresh_token")]
        public string? RefreshToken { get; set; }

        /// <summary>
        /// The refresh token for this user, to be used to get the next access token for this user. Please expect that this value can change anytime you retrieve a new access token. Once a new refresh token code has been returned, the older code will no longer work. 
        /// </summary>
        [JsonProperty("access_token")]
        public string? AccessToken { get; set; }

        /// <summary>
        /// A summary of athlete information 
        /// </summary>
        [JsonProperty("athlete")]
        public SummaryAthlete? Athlete { get; set; }
    }
}
