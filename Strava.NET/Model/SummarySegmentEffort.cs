using Newtonsoft.Json;

namespace StravaSharp
{
	///<summary>
	/// 
	///</summary>
	public class SummarySegmentEffort
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
		/// Whether this effort is the current best on the leaderboard
		///</summary>
		[JsonProperty("is_kom")]
		public bool IsKom { get; set; }

	}
}