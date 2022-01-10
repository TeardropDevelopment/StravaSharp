using Newtonsoft.Json;

namespace StravaSharp
{
	///<summary>
	/// 
	///</summary>
	public class PhotosSummary
	{
		///<summary>
		/// The number of photos
		///</summary>
		[JsonProperty("count")]
		public int Count { get; set; }

	}
}