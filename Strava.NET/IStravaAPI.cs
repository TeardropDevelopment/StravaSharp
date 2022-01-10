namespace StravaSharp
{
    public interface IStravaAPI
    {
        #region Activity

        /// <summary>
        /// Creates a manual activity for an athlete, requires <code>activity:write</code> scope.
        /// </summary>
        /// <returns>
        /// HTTP code 201: The activity's detailed representation. An instance of <see cref="DetailedActivity"/>.<br></br>
        /// HTTP code 4xx, 5xx: A <see cref="Fault"/> describing the reason for the error.
        /// </returns>
        object CreateActivity(Activity activity);

        /// <summary>
        /// Returns the given activity that is owned by the authenticated athlete. Requires <code>activity:read</code> for Everyone and Followers activities. Requires <code>activity:read_all</code> for Only Me activities.
        /// </summary>
        /// <param name="id">The identifier of the activity.</param>
        /// <param name="include_all_efforts">To include all segments efforts.</param>
        /// <returns>
        /// HTTP code 201: The activity's detailed representation. An instance of <see cref="DetailedActivity"/>.<br></br>
        /// HTTP code 4xx, 5xx: A <see cref="Fault"/> describing the reason for the error.
        /// </returns>
        object GetActivityById(long id, bool include_all_efforts);

        /// <summary>
        /// Returns the comments on the given activity. Requires <code>activity:read</code> for Everyone and Followers activities. Requires <code>activity:read_all</code> for Only Me activities.
        /// </summary>
        /// <param name="id">The identifier of the activity.</param>
        /// <param name="page">Page number. Defaults to 1.</param>
        /// <param name="per_page">Number of items per page. Defaults to 30.</param>
        /// <returns>
        /// HTTP code 201: An array of <see cref="Comment"/> objects.<br></br>
        /// HTTP code 4xx, 5xx: A <see cref="Fault"/> describing the reason for the error.
        /// </returns>
        object GetCommentsByActivityId(long id, int page = 1, int per_page = 30);

        /// <summary>
        /// Returns the athletes who kudoed an activity identified by an identifier. Requires <code>activity:read</code> for Everyone and Followers activities. Requires <code>activity:read_all</code> for Only Me activities.
        /// </summary>
        /// <param name="id">The identifier of the activity.</param>
        /// <param name="page">Page number. Defaults to 1.</param>
        /// <param name="per_page">Number of items per page. Defaults to 30.</param>
        /// <returns>
        /// HTTP code 201: An array of <see cref="SummaryAthlete"/> objects.<br></br>
        /// HTTP code 4xx, 5xx: A <see cref="Fault"/> describing the reason for the error.
        /// </returns>
        object GetKudoersByActivityId(long id, int page = 1, int per_page = 30);

        /// <summary>
        /// Returns the laps of an activity identified by an identifier. Requires <code>activity:read</code> for Everyone and Followers activities. Requires <code>activity:read_all</code> for Only Me activities.
        /// </summary>
        /// <param name="id">The identifier of the activity.</param>
        /// <returns>
        /// HTTP code 201: An array of <see cref="Lap"/> objects.<br></br>
        /// HTTP code 4xx, 5xx: A <see cref="Fault"/> describing the reason for the error.
        /// </returns>
        object GetLapsByActivityId(long id);

        /// <summary>
        /// Returns the activities of an athlete for a specific identifier. Requires <code>activity:read</code>. Only Me activities will be filtered out unless requested by a token with <code>activity:read_all</code>.
        /// </summary>
        /// <param name="before">An epoch timestamp to use for filtering activities that have taken place before a certain time.</param>
        /// <param name="after">An epoch timestamp to use for filtering activities that have taken place after a certain time.</param>
        /// <param name="page">Page number. Defaults to 1.</param>
        /// <param name="per_page">Number of items per page. Defaults to 30.</param>
        /// <returns>
        /// HTTP code 201: An array of <see cref="SummaryActivity"/> objects.<br></br>
        /// HTTP code 4xx, 5xx: A <see cref="Fault"/> describing the reason for the error.
        /// </returns>
        object GetLoggedInAthleteActivities(int before, int after, int page = 1, int per_page = 30);

        /// <summary>
        /// Summit Feature. Returns the zones of a given activity. Requires <code>activity:read</code> for Everyone and Followers activities. Requires <code>activity:read_all</code> for Only Me activities.
        /// </summary>
        /// <param name="id">The identifier of the activity.</param>
        /// <returns>
        /// HTTP code 201: An array of <see cref="ActivityZone"/> objects.<br></br>
        /// HTTP code 4xx, 5xx: A <see cref="Fault"/> describing the reason for the error.
        /// </returns>
        object GetZonesByActivityId(long id);

        /// <summary>
        /// Updates the given activity that is owned by the authenticated athlete. Requires <code>activity:write</code>. Also requires <code>activity:read_all</code> in order to update Only Me activities
        /// </summary>
        /// <param name="id">The identifier of the activity.</param>
        /// <param name="updatable_activity">An instance of <see cref="UpdatableActivity"/>.</param>
        /// <returns>
        /// HTTP code 201: The activity's detailed representation. An instance of <see cref="DetailedActivity"/>.<br></br>
        /// HTTP code 4xx, 5xx: A <see cref="Fault"/> describing the reason for the error.
        /// </returns>
        object UpdateActivityById(long id, UpdatableActivity updatable_activity);

        #endregion
    }
}