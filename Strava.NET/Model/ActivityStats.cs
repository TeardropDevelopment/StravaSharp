using Newtonsoft.Json;

namespace StravaSharp
{
	///<summary>
	/// A set of rolled-up statistics and totals for an athlete
	///</summary>
	public class ActivityStats
	{
		///<summary>
		/// The longest distance ridden by the athlete.
		///</summary>
		[JsonProperty("biggest_ride_distance")]
		public double BiggestRideDistance { get; set; }

		///<summary>
		/// The highest climb ridden by the athlete.
		///</summary>
		[JsonProperty("biggest_climb_elevation_gain")]
		public double BiggestClimbElevationGain { get; set; }

		///<summary>
		/// The recent (last 4 weeks) ride stats for the athlete.
		///</summary>
		[JsonProperty("recent_ride_totals")]
		public ActivityTotal RecentRideTotals { get; set; }

		///<summary>
		/// The recent (last 4 weeks) run stats for the athlete.
		///</summary>
		[JsonProperty("recent_run_totals")]
		public ActivityTotal RecentRunTotals { get; set; }

		///<summary>
		/// The recent (last 4 weeks) swim stats for the athlete.
		///</summary>
		[JsonProperty("recent_swim_totals")]
		public ActivityTotal RecentSwimTotals { get; set; }

		///<summary>
		/// The year to date ride stats for the athlete.
		///</summary>
		[JsonProperty("ytd_ride_totals")]
		public ActivityTotal YtdRideTotals { get; set; }

		///<summary>
		/// The year to date run stats for the athlete.
		///</summary>
		[JsonProperty("ytd_run_totals")]
		public ActivityTotal YtdRunTotals { get; set; }

		///<summary>
		/// The year to date swim stats for the athlete.
		///</summary>
		[JsonProperty("ytd_swim_totals")]
		public ActivityTotal YtdSwimTotals { get; set; }

		///<summary>
		/// The all time ride stats for the athlete.
		///</summary>
		[JsonProperty("all_ride_totals")]
		public ActivityTotal AllRideTotals { get; set; }

		///<summary>
		/// The all time swim stats for the athlete.
		///</summary>
		[JsonProperty("all_swim_totals")]
		public ActivityTotal AllSwimTotals { get; set; }

	}
}