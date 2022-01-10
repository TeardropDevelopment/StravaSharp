using Newtonsoft.Json;

namespace StravaSharp
{
	///<summary>
	/// 
	///</summary>
	public class ExplorerResponse
	{
		///<summary>
		/// The set of segments matching an explorer request
		///</summary>
		[JsonProperty("segments")]
		public ExplorerSegment Segments { get; set; }

	}
}