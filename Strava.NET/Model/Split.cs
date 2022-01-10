using Newtonsoft.Json;

namespace StravaSharp
{
	///<summary>
	/// 
	///</summary>
	public class Split
	{
		///<summary>
		/// The average speed of this split, in meters per second
		///</summary>
		[JsonProperty("average_speed")]
		public float AverageSpeed { get; set; }

		///<summary>
		/// The distance of this split, in meters
		///</summary>
		[JsonProperty("distance")]
		public float Distance { get; set; }

		///<summary>
		/// The elapsed time of this split, in seconds
		///</summary>
		[JsonProperty("elapsed_time")]
		public int ElapsedTime { get; set; }

		///<summary>
		/// The elevation difference of this split, in meters
		///</summary>
		[JsonProperty("elevation_difference")]
		public float ElevationDifference { get; set; }

		///<summary>
		/// The pacing zone of this split
		///</summary>
		[JsonProperty("pace_zone")]
		public int PaceZone { get; set; }

		///<summary>
		/// N/A
		///</summary>
		[JsonProperty("split")]
		public int SplitNr { get; set; }

	}
}