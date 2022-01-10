using Newtonsoft.Json;

namespace StravaSharp
{
	///<summary>
	/// 
	///</summary>
	public class PolylineMap
	{
		///<summary>
		/// The identifier of the map
		///</summary>
		[JsonProperty("id")]
		public string Id { get; set; }

		///<summary>
		/// The summary polyline of the map
		///</summary>
		[JsonProperty("summary_polyline")]
		public string SummaryPolyline { get; set; }

	}
}