using Newtonsoft.Json;

namespace StravaSharp
{
	///<summary>
	/// 
	///</summary>
	public class DetailedSegment
	{
		///<summary>
		/// The unique identifier of this segment
		///</summary>
		[JsonProperty("id")]
		public long Id { get; set; }

		///<summary>
		/// The name of this segment
		///</summary>
		[JsonProperty("name")]
		public string Name { get; set; }

		///<summary>
		/// May take one of the following values: <code>Ride</code>, <code>Run</code>
		///</summary>
		[JsonProperty("activity_type")]
		public string ActivityType { get; set; }

		///<summary>
		/// The segment&#39;s distance, in meters
		///</summary>
		[JsonProperty("distance")]
		public float Distance { get; set; }

		///<summary>
		/// The segment&#39;s average grade, in percents
		///</summary>
		[JsonProperty("average_grade")]
		public float AverageGrade { get; set; }

		///<summary>
		/// The segments&#39;s maximum grade, in percents
		///</summary>
		[JsonProperty("maximum_grade")]
		public float MaximumGrade { get; set; }

		///<summary>
		/// The segments&#39;s highest elevation, in meters
		///</summary>
		[JsonProperty("elevation_high")]
		public float ElevationHigh { get; set; }

		///<summary>
		/// The segments&#39;s lowest elevation, in meters
		///</summary>
		[JsonProperty("elevation_low")]
		public float ElevationLow { get; set; }

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
		/// The category of the climb [0, 5]. Higher is harder ie. 5 is Hors catégorie, 0 is uncategorized in climb_category.
		///</summary>
		[JsonProperty("climb_category")]
		public int ClimbCategory { get; set; }

		///<summary>
		/// The segments&#39;s city.
		///</summary>
		[JsonProperty("city")]
		public string City { get; set; }

		///<summary>
		/// The segments&#39;s state or geographical region.
		///</summary>
		[JsonProperty("state")]
		public string State { get; set; }

		///<summary>
		/// The segment&#39;s country.
		///</summary>
		[JsonProperty("country")]
		public string Country { get; set; }

		///<summary>
		/// Whether this segment is private.
		///</summary>
		[JsonProperty("private")]
		public bool Private { get; set; }

		///<summary>
		/// An instance of <a href="#api-models-SummarySegmentEffort">SummarySegmentEffort</a>.
		///</summary>
		[JsonProperty("athlete_pr_effort")]
		public SummarySegmentEffort AthletePrEffort { get; set; }

		///<summary>
		/// An instance of <a href="#api-models-SummaryPRSegmentEffort">SummaryPRSegmentEffort</a>.
		///</summary>
		[JsonProperty("athlete_segment_stats")]
		public SummaryPRSegmentEffort AthleteSegmentStats { get; set; }

		///<summary>
		/// The time at which the segment was created.
		///</summary>
		[JsonProperty("created_at")]
		public DateTime CreatedAt { get; set; }

		///<summary>
		/// The time at which the segment was last updated.
		///</summary>
		[JsonProperty("updated_at")]
		public DateTime UpdatedAt { get; set; }

		///<summary>
		/// The segment&#39;s total elevation gain.
		///</summary>
		[JsonProperty("total_elevation_gain")]
		public float TotalElevationGain { get; set; }

		///<summary>
		/// An instance of <a href="#api-models-PolylineMap">PolylineMap</a>.
		///</summary>
		[JsonProperty("map")]
		public PolylineMap Map { get; set; }

		///<summary>
		/// The total number of efforts for this segment
		///</summary>
		[JsonProperty("effort_count")]
		public int EffortCount { get; set; }

		///<summary>
		/// The number of unique athletes who have an effort for this segment
		///</summary>
		[JsonProperty("athlete_count")]
		public int AthleteCount { get; set; }

		///<summary>
		/// The number of stars for this segment
		///</summary>
		[JsonProperty("star_count")]
		public int StarCount { get; set; }

	}
}