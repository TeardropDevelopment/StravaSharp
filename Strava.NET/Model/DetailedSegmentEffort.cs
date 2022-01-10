using Newtonsoft.Json;

namespace StravaSharp
{
	///<summary>
	/// 
	///</summary>
	public class DetailedSegmentEffort
	{
		///<summary>
		/// The unique identifier of this effort
		///</summary>
		[JsonProperty("id")]
		public long Id { get; set; }

		///<summary>
		/// The unique identifier of the activity related to this effort
		///</summary>
		[JsonProperty("activity_id")]
		public long ActivityId { get; set; }

		///<summary>
		/// The effort&#39;s elapsed time
		///</summary>
		[JsonProperty("elapsed_time")]
		public int ElapsedTime { get; set; }

		///<summary>
		/// The time at which the effort was started.
		///</summary>
		[JsonProperty("start_date")]
		public DateTime StartDate { get; set; }

		///<summary>
		/// The time at which the effort was started in the local timezone.
		///</summary>
		[JsonProperty("start_date_local")]
		public DateTime StartDateLocal { get; set; }

		///<summary>
		/// The effort&#39;s distance in meters
		///</summary>
		[JsonProperty("distance")]
		public float Distance { get; set; }

		///<summary>
		/// Whether this effort is the current best on the leaderboard
		///</summary>
		[JsonProperty("is_kom")]
		public bool IsKom { get; set; }

		///<summary>
		/// The name of the segment on which this effort was performed
		///</summary>
		[JsonProperty("name")]
		public string Name { get; set; }

		///<summary>
		/// An instance of <a href="#api-models-MetaActivity">MetaActivity</a>.
		///</summary>
		[JsonProperty("activity")]
		public MetaActivity Activity { get; set; }

		///<summary>
		/// An instance of <a href="#api-models-MetaAthlete">MetaAthlete</a>.
		///</summary>
		[JsonProperty("athlete")]
		public MetaAthlete Athlete { get; set; }

		///<summary>
		/// The effort&#39;s moving time
		///</summary>
		[JsonProperty("moving_time")]
		public int MovingTime { get; set; }

		///<summary>
		/// The start index of this effort in its activity&#39;s stream
		///</summary>
		[JsonProperty("start_index")]
		public int StartIndex { get; set; }

		///<summary>
		/// The end index of this effort in its activity&#39;s stream
		///</summary>
		[JsonProperty("end_index")]
		public int EndIndex { get; set; }

		///<summary>
		/// The effort&#39;s average cadence
		///</summary>
		[JsonProperty("average_cadence")]
		public float AverageCadence { get; set; }

		///<summary>
		/// The average wattage of this effort
		///</summary>
		[JsonProperty("average_watts")]
		public float AverageWatts { get; set; }

		///<summary>
		/// For riding efforts, whether the wattage was reported by a dedicated recording device
		///</summary>
		[JsonProperty("device_watts")]
		public bool DeviceWatts { get; set; }

		///<summary>
		/// The heart heart rate of the athlete during this effort
		///</summary>
		[JsonProperty("average_heartrate")]
		public float AverageHeartrate { get; set; }

		///<summary>
		/// The maximum heart rate of the athlete during this effort
		///</summary>
		[JsonProperty("max_heartrate")]
		public float MaxHeartrate { get; set; }

		///<summary>
		/// An instance of <a href="#api-models-SummarySegment">SummarySegment</a>.
		///</summary>
		[JsonProperty("segment")]
		public SummarySegment Segment { get; set; }

		///<summary>
		/// The rank of the effort on the global leaderboard if it belongs in the top 10 at the time of upload
		///</summary>
		[JsonProperty("kom_rank")]
		public int KomRank { get; set; }

		///<summary>
		/// Whether this effort should be hidden when viewed within an activity
		///</summary>
		[JsonProperty("hidden")]
		public bool Hidden { get; set; }

	}
}