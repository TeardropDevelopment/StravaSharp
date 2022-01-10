using Newtonsoft.Json;

namespace StravaSharp
{
	///<summary>
	/// A union type representing the time spent in a given zone.
	///</summary>
	public class TimedZoneRange
	{
		///<summary>
		/// The minimum value in the range.
		///</summary>
		[JsonProperty("min")]
		public int Min { get; set; }

		///<summary>
		/// The number of seconds spent in this zone
		///</summary>
		[JsonProperty("time")]
		public int Time { get; set; }

	}
}