using Newtonsoft.Json;

namespace StravaSharp
{
	///<summary>
	/// 
	///</summary>
	public class DistanceStream
	{
		///<summary>
		/// The number of data points in this stream
		///</summary>
		[JsonProperty("original_size")]
		public int OriginalSize { get; set; }

		///<summary>
		/// The level of detail (sampling) in which this stream was returned May take one of the following values: <code>low</code>, <code>medium</code>, <code>high</code>
		///</summary>
		[JsonProperty("resolution")]
		public string Resolution { get; set; }

		///<summary>
		/// The sequence of distance values for this stream, in meters
		///</summary>
		[JsonProperty("data")]
		public float Data { get; set; }

	}
}