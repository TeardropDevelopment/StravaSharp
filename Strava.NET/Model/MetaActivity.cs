using Newtonsoft.Json;

namespace StravaSharp
{
	///<summary>
	/// 
	///</summary>
	public class MetaActivity
	{
		///<summary>
		/// The unique identifier of the activity
		///</summary>
		[JsonProperty("id")]
		public long Id { get; set; }

	}
}