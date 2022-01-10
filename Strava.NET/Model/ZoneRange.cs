using Newtonsoft.Json;

namespace StravaSharp
{
	///<summary>
	/// 
	///</summary>
	public class ZoneRange
	{
		///<summary>
		/// The minimum value in the range.
		///</summary>
		[JsonProperty("min")]
		public int Min { get; set; }

	}
}