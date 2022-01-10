using Newtonsoft.Json;

namespace StravaSharp
{
	///<summary>
	/// 
	///</summary>
	public class SummaryActivity
	{
		///<summary>
		/// The unique identifier of the activity
		///</summary>
		[JsonProperty("id")]
		public long Id { get; set; }

		///<summary>
		/// The identifier provided at upload time
		///</summary>
		[JsonProperty("external_id")]
		public string ExternalId { get; set; }

		///<summary>
		/// The identifier of the upload that resulted in this activity
		///</summary>
		[JsonProperty("upload_id")]
		public long UploadId { get; set; }

		///<summary>
		/// An instance of <a href="#api-models-MetaAthlete">MetaAthlete</a>.
		///</summary>
		[JsonProperty("athlete")]
		public MetaAthlete Athlete { get; set; }

		///<summary>
		/// The name of the activity
		///</summary>
		[JsonProperty("name")]
		public string Name { get; set; }

		///<summary>
		/// The activity&#39;s distance, in meters
		///</summary>
		[JsonProperty("distance")]
		public float Distance { get; set; }

		///<summary>
		/// The activity&#39;s moving time, in seconds
		///</summary>
		[JsonProperty("moving_time")]
		public int MovingTime { get; set; }

		///<summary>
		/// The activity&#39;s elapsed time, in seconds
		///</summary>
		[JsonProperty("elapsed_time")]
		public int ElapsedTime { get; set; }

		///<summary>
		/// The activity&#39;s total elevation gain.
		///</summary>
		[JsonProperty("total_elevation_gain")]
		public float TotalElevationGain { get; set; }

		///<summary>
		/// The activity&#39;s highest elevation, in meters
		///</summary>
		[JsonProperty("elev_high")]
		public float ElevHigh { get; set; }

		///<summary>
		/// The activity&#39;s lowest elevation, in meters
		///</summary>
		[JsonProperty("elev_low")]
		public float ElevLow { get; set; }

		///<summary>
		/// An instance of <a href="#api-models-ActivityType">ActivityType</a>.
		///</summary>
		[JsonProperty("type")]
		public ActivityType Type { get; set; }

		///<summary>
		/// The time at which the activity was started.
		///</summary>
		[JsonProperty("start_date")]
		public DateTime StartDate { get; set; }

		///<summary>
		/// The time at which the activity was started in the local timezone.
		///</summary>
		[JsonProperty("start_date_local")]
		public DateTime StartDateLocal { get; set; }

		///<summary>
		/// The timezone of the activity
		///</summary>
		[JsonProperty("timezone")]
		public string Timezone { get; set; }

		///<summary>
		/// An instance of <a href="#api-models-LatLng">LatLng</a>.
		///</summary>
		[JsonProperty("start_latlng")]
		public LatLng StartLatlng { get; set; }

		///<summary>
		/// An instance of <a href="#api-models-LatLng">LatLng</a>.
		///</summary>
		[JsonProperty("end_latlng")]
		public LatLng EndLatlng { get; set; }

		///<summary>
		/// The number of achievements gained during this activity
		///</summary>
		[JsonProperty("achievement_count")]
		public int AchievementCount { get; set; }

		///<summary>
		/// The number of kudos given for this activity
		///</summary>
		[JsonProperty("kudos_count")]
		public int KudosCount { get; set; }

		///<summary>
		/// The number of comments for this activity
		///</summary>
		[JsonProperty("comment_count")]
		public int CommentCount { get; set; }

		///<summary>
		/// The number of athletes for taking part in a group activity
		///</summary>
		[JsonProperty("athlete_count")]
		public int AthleteCount { get; set; }

		///<summary>
		/// The number of Instagram photos for this activity
		///</summary>
		[JsonProperty("photo_count")]
		public int PhotoCount { get; set; }

		///<summary>
		/// The number of Instagram and Strava photos for this activity
		///</summary>
		[JsonProperty("total_photo_count")]
		public int TotalPhotoCount { get; set; }

		///<summary>
		/// An instance of <a href="#api-models-PolylineMap">PolylineMap</a>.
		///</summary>
		[JsonProperty("map")]
		public PolylineMap Map { get; set; }

		///<summary>
		/// Whether this activity was recorded on a training machine
		///</summary>
		[JsonProperty("trainer")]
		public bool Trainer { get; set; }

		///<summary>
		/// Whether this activity is a commute
		///</summary>
		[JsonProperty("commute")]
		public bool Commute { get; set; }

		///<summary>
		/// Whether this activity was created manually
		///</summary>
		[JsonProperty("manual")]
		public bool Manual { get; set; }

		///<summary>
		/// Whether this activity is private
		///</summary>
		[JsonProperty("private")]
		public bool Private { get; set; }

		///<summary>
		/// Whether this activity is flagged
		///</summary>
		[JsonProperty("flagged")]
		public bool Flagged { get; set; }

		///<summary>
		/// The activity&#39;s workout type
		///</summary>
		[JsonProperty("workout_type")]
		public int WorkoutType { get; set; }

		///<summary>
		/// The unique identifier of the upload in string format
		///</summary>
		[JsonProperty("upload_id_str")]
		public string UploadIdStr { get; set; }

		///<summary>
		/// The activity&#39;s average speed, in meters per second
		///</summary>
		[JsonProperty("average_speed")]
		public float AverageSpeed { get; set; }

		///<summary>
		/// The activity&#39;s max speed, in meters per second
		///</summary>
		[JsonProperty("max_speed")]
		public float MaxSpeed { get; set; }

		///<summary>
		/// Whether the logged-in athlete has kudoed this activity
		///</summary>
		[JsonProperty("has_kudoed")]
		public bool HasKudoed { get; set; }

		///<summary>
		/// Whether the activity is muted
		///</summary>
		[JsonProperty("hide_from_home")]
		public bool HideFromHome { get; set; }

		///<summary>
		/// The id of the gear for the activity
		///</summary>
		[JsonProperty("gear_id")]
		public string GearId { get; set; }

		///<summary>
		/// The total work done in kilojoules during this activity. Rides only
		///</summary>
		[JsonProperty("kilojoules")]
		public float Kilojoules { get; set; }

		///<summary>
		/// Average power output in watts during this activity. Rides only
		///</summary>
		[JsonProperty("average_watts")]
		public float AverageWatts { get; set; }

		///<summary>
		/// Whether the watts are from a power meter, false if estimated
		///</summary>
		[JsonProperty("device_watts")]
		public bool DeviceWatts { get; set; }

		///<summary>
		/// Similar to Normalized Power. Rides with power meter data only
		///</summary>
		[JsonProperty("weighted_average_watts")]
		public int WeightedAverageWatts { get; set; }

	}
}