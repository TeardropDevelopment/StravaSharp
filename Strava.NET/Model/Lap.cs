using Newtonsoft.Json;

namespace StravaSharp
{
	///<summary>
	/// 
	///</summary>
	public class Lap
	{
		///<summary>
		/// The unique identifier of this lap
		///</summary>
		[JsonProperty("id")]
		public long Id { get; set; }

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
		/// The lap&#39;s average cadence
		///</summary>
		[JsonProperty("average_cadence")]
		public float AverageCadence { get; set; }

		///<summary>
		/// The lap&#39;s average speed
		///</summary>
		[JsonProperty("average_speed")]
		public float AverageSpeed { get; set; }

		///<summary>
		/// The lap&#39;s distance, in meters
		///</summary>
		[JsonProperty("distance")]
		public float Distance { get; set; }

		///<summary>
		/// The lap&#39;s elapsed time, in seconds
		///</summary>
		[JsonProperty("elapsed_time")]
		public int ElapsedTime { get; set; }

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
		/// The index of this lap in the activity it belongs to
		///</summary>
		[JsonProperty("lap_index")]
		public int LapIndex { get; set; }

		///<summary>
		/// The maximum speed of this lat, in meters per second
		///</summary>
		[JsonProperty("max_speed")]
		public float MaxSpeed { get; set; }

		///<summary>
		/// The lap&#39;s moving time, in seconds
		///</summary>
		[JsonProperty("moving_time")]
		public int MovingTime { get; set; }

		///<summary>
		/// The name of the lap
		///</summary>
		[JsonProperty("name")]
		public string Name { get; set; }

		///<summary>
		/// The athlete&#39;s pace zone during this lap
		///</summary>
		[JsonProperty("pace_zone")]
		public int PaceZone { get; set; }

		///<summary>
		/// An instance of <a href="#api-models-integer">integer</a>.
		///</summary>
		[JsonProperty("split")]
		public int Split { get; set; }

		///<summary>
		/// The time at which the lap was started.
		///</summary>
		[JsonProperty("start_date")]
		public DateTime StartDate { get; set; }

		///<summary>
		/// The elevation gain of this lap, in meters
		///</summary>
		[JsonProperty("total_elevation_gain")]
		public float TotalElevationGain { get; set; }

	}
}