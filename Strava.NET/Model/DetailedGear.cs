using Newtonsoft.Json;

namespace StravaSharp
{
	///<summary>
	/// 
	///</summary>
	public class DetailedGear
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
		/// The gear&#39;s name.
		///</summary>
		[JsonProperty("name")]
		public string Name { get; set; }

		///<summary>
		/// The distance logged with this gear.
		///</summary>
		[JsonProperty("distance")]
		public float Distance { get; set; }

		///<summary>
		/// The gear&#39;s brand name.
		///</summary>
		[JsonProperty("brand_name")]
		public string BrandName { get; set; }

		///<summary>
		/// The gear&#39;s model name.
		///</summary>
		[JsonProperty("model_name")]
		public string ModelName { get; set; }

		///<summary>
		/// The gear&#39;s description.
		///</summary>
		[JsonProperty("description")]
		public string Description { get; set; }

	}
}