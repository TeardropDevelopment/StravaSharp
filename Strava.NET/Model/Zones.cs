using Newtonsoft.Json;

namespace StravaSharp
{
	///<summary>
	/// 
	///</summary>
	public class Zones
	{
		///<summary>
		/// An instance of <a href="#api-models-HeartRateZoneRanges">HeartRateZoneRanges</a>.
		///</summary>
		[JsonProperty("heart_rate")]
		public HeartRateZoneRanges HeartRate { get; set; }

	}
}