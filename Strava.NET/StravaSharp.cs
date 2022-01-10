namespace StravaSharp
{
    public class StravaSharp : API, IStravaAPI
    {
        #region Singleton

        private static StravaSharp? _instance = null;

        public static StravaSharp Instance { 
            get {
                if(_instance == null)
                {
                    _instance = new StravaSharp();
                } 
                return _instance;
            }
        }

        #endregion

        #region ctor

        protected StravaSharp() : base("https://www.strava.com/api/v3") { }

        #endregion

        #region Activity

        public object CreateActivity(Activity activity)
        {
            throw new NotImplementedException();
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