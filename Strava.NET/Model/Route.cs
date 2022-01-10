using Newtonsoft.Json;

namespace StravaSharp
{
	///<summary>
	/// 
	///</summary>
	public class Route
	{
		///<summary>
		/// An instance of <a href="#api-models-SummaryAthlete">SummaryAthlete</a>.
		///</summary>
		[JsonProperty("athlete")]
		public SummaryAthlete Athlete { get; set; }

		///<summary>
		/// The description of the route
		///</summary>
		[JsonProperty("description")]
		public string Description { get; set; }

		///<summary>
		/// The route&#39;s distance, in meters
		///</summary>
		[JsonProperty("distance")]
		public float Distance { get; set; }

		///<summary>
		/// The route&#39;s elevation gain.
		///</summary>
		[JsonProperty("elevation_gain")]
		public float ElevationGain { get; set; }

		///<summary>
		/// The unique identifier of this route
		///</summary>
		[JsonProperty("id")]
		public long Id { get; set; }

		///<summary>
		/// The unique identifier of the route in string format
		///</summary>
		[JsonProperty("id_str")]
		public string IdStr { get; set; }

		///<summary>
		/// An instance of <a href="#api-models-PolylineMap">PolylineMap</a>.
		///</summary>
		[JsonProperty("map")]
		public PolylineMap Map { get; set; }

		///<summary>
		/// The name of this route
		///</summary>
		[JsonProperty("name")]
		public string Name { get; set; }

		///<summary>
		/// Whether this route is private
		///</summary>
		[JsonProperty("private")]
		public bool Private { get; set; }

		///<summary>
		/// Whether this route is starred by the logged-in athlete
		///</summary>
		[JsonProperty("starred")]
		public bool Starred { get; set; }

		///<summary>
		/// An epoch timestamp of when the route was created
		///</summary>
		[JsonProperty("timestamp")]
		public int Timestamp { get; set; }

		///<summary>
		/// This route&#39;s type (1 for ride, 2 for runs)
		///</summary>
		[JsonProperty("type")]
		public int Type { get; set; }

		///<summary>
		/// This route&#39;s sub-type (1 for road, 2 for mountain bike, 3 for cross, 4 for trail, 5 for mixed)
		///</summary>
		[JsonProperty("sub_type")]
		public int SubType { get; set; }

		///<summary>
		/// The time at which the route was created
		///</summary>
		[JsonProperty("created_at")]
		public DateTime CreatedAt { get; set; }

		///<summary>
		/// The time at which the route was last updated
		///</summary>
		[JsonProperty("updated_at")]
		public DateTime UpdatedAt { get; set; }

		///<summary>
		/// The segments traversed by this route
		///</summary>
		[JsonProperty("segments")]
		public SummarySegment Segments { get; set; }

	}
}