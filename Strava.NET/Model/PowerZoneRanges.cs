using Newtonsoft.Json;

namespace StravaSharp
{
	///<summary>
	/// 
	///</summary>
	public class PowerZoneRanges
	{
		///<summary>
		/// An instance of <a href="#api-models-ZoneRanges">ZoneRanges</a>.
		///</summary>
		[JsonProperty("zones")]
		public ZoneRanges Zones { get; set; }

	}
}