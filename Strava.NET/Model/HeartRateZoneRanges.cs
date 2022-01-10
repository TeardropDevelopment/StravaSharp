using Newtonsoft.Json;

namespace StravaSharp
{
	///<summary>
	/// 
	///</summary>
	public class HeartRateZoneRanges
	{
		///<summary>
		/// Whether the athlete has set their own custom heart rate zones
		///</summary>
		[JsonProperty("custom_zones")]
		public bool CustomZones { get; set; }

	}
}