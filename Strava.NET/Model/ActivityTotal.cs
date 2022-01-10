using Newtonsoft.Json;

namespace StravaSharp
{
	///<summary>
	/// A roll-up of metrics pertaining to a set of activities. Values are in seconds and meters.
	///</summary>
	public class ActivityTotal
	{
		///<summary>
		/// The number of activities considered in this total.
		///</summary>
		[JsonProperty("count")]
		public int Count { get; set; }

		///<summary>
		/// The total distance covered by the considered activities.
		///</summary>
		[JsonProperty("distance")]
		public float Distance { get; set; }

		///<summary>
		/// The total moving time of the considered activities.
		///</summary>
		[JsonProperty("moving_time")]
		public int MovingTime { get; set; }

		///<summary>
		/// The total elapsed time of the considered activities.
		///</summary>
		[JsonProperty("elapsed_time")]
		public int ElapsedTime { get; set; }

		///<summary>
		/// The total number of achievements of the considered activities.
		///</summary>
		[JsonProperty("achievement_count")]
		public int AchievementCount { get; set; }

	}
}