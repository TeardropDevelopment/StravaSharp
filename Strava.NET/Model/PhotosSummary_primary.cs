using Newtonsoft.Json;

namespace StravaSharp
{
	///<summary>
	/// 
	///</summary>
	public class PhotosSummary_primary
	{
		///<summary>
		/// An instance of <a href="#api-models-long">long</a>.
		///</summary>
		[JsonProperty("id")]
		public long Id { get; set; }

		///<summary>
		/// An instance of <a href="#api-models-integer">integer</a>.
		///</summary>
		[JsonProperty("source")]
		public int Source { get; set; }

		///<summary>
		/// An instance of <a href="#api-models-string">string</a>.
		///</summary>
		[JsonProperty("urls")]
		public string Urls { get; set; }

	}
}