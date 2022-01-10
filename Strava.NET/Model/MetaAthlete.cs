using Newtonsoft.Json;

namespace StravaSharp
{
	///<summary>
	/// 
	///</summary>
	public class MetaAthlete
	{
		///<summary>
		/// The unique identifier of the athlete
		///</summary>
		[JsonProperty("id")]
		public long Id { get; set; }

	}
}