using Newtonsoft.Json;

namespace StravaSharp
{
	///<summary>
	/// 
	///</summary>
	public class BaseStream
	{
		///<summary>
		/// The number of data points in this stream
		///</summary>
		[JsonProperty("original_size")]
		public int OriginalSize { get; set; }

		///<summary>
		/// The base series used in the case the stream was downsampled May take one of the following values: <code>distance</code>, <code>time</code>
		///</summary>
		[JsonProperty("series_type")]
		public string SeriesType { get; set; }

	}
}