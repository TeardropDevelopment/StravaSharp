using StravaSharp.API;
using StravaSharp.API.Authentication;
using StravaSharp.Client;
using StravaSharp.Model;

namespace StravaSharp
{
    public class StravaSharp : StravaAPI, IStravaAPI
    {

        #region properties

        private string protocol = string.Empty;
        public string Protocol { get => protocol; set => protocol = value; }

        #endregion

        #region client

        private AppClient client;

        #endregion

        #region Access keys

        private string? accessKey = string.Empty;
        private string? refreshKey = string.Empty;

        #endregion

        #region ctor

        public Guid Id { get; private set; }
        public StravaSharp(Guid id, AppClient client) : base("https://www.strava.com/api/v3") 
        {
            this.client = client;
            Id = id;
        }

        #endregion

        #region OAuth2.0

        public bool OAuth(Scope scope, int port = 5000)
        {
            OAuth oAuth = new OAuth();
            string? code = oAuth.Authenticate(client.ClientId, scope, port);

            // Get real accessKey and refreshKey

            return true;
        }

        #endregion

        #region Activity

        public object CreateActivity(Activity activity)
        {
            Console.WriteLine(accessKey);
            return activity;
        }

        public object GetActivityById(long id, bool include_all_efforts)
        {
            Console.WriteLine(GET($"/activities/{id}?include_all_efforts={include_all_efforts}"));
            return "";
        }

        public object GetCommentsByActivityId(long id, int page = 1, int per_page = 30)
        {
            throw new NotImplementedException();
        }

        public object GetKudoersByActivityId(long id, int page = 1, int per_page = 30)
        {
            throw new NotImplementedException();
        }

        public object GetLapsByActivityId(long id)
        {
            throw new NotImplementedException();
        }

        public object GetLoggedInAthleteActivities(int before, int after, int page = 1, int per_page = 30)
        {
            throw new NotImplementedException();
        }

        public object GetZonesByActivityId(long id)
        {
            throw new NotImplementedException();
        }

        public object UpdateActivityById(long id, UpdatableActivity updatable_activity)
        {
            throw new NotImplementedException();
        }

        #endregion

    }
}