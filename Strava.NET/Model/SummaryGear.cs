using Newtonsoft.Json;

namespace StravaSharp
{
	///<summary>
	/// 
	///</summary>
	public class SummaryGear
	{
		///<summary>
		/// The gear&#39;s unique identifier.
		///</summary>
		[JsonProperty("id")]
		public string Id { get; set; }

		///<summary>
		/// Resource state, indicates level of detail. Possible values: 2 -&gt; &quot;summary&quot;, 3 -&gt; &quot;detail&quot;
		///</summary>
		[JsonProperty("resource_state")]
		public int ResourceState { get; set; }

		///<summary>
		/// Whether this gear&#39;s is the owner&#39;s default one.
		///</summary>
		[JsonProperty("primary")]
		public bool Primary { get; set; }

		///<summary>
		/// The distance logged with this gear.
		///</summary>
		[JsonProperty("distance")]
		public float Distance { get; set; }

	}
}