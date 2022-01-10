using Newtonsoft.Json;

namespace StravaSharp
{
	///<summary>
	/// 
	///</summary>
	public class MetaClub
	{
		///<summary>
		/// The club&#39;s unique identifier.
		///</summary>
		[JsonProperty("id")]
		public long Id { get; set; }

		///<summary>
		/// The club&#39;s name.
		///</summary>
		[JsonProperty("name")]
		public string Name { get; set; }

	}
}