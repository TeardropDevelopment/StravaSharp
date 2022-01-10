using Newtonsoft.Json;

namespace StravaSharp
{
	///<summary>
	/// 
	///</summary>
	public class Error
	{
		///<summary>
		/// The code associated with this error.
		///</summary>
		[JsonProperty("code")]
		public string Code { get; set; }

		///<summary>
		/// The specific field or aspect of the resource associated with this error.
		///</summary>
		[JsonProperty("field")]
		public string Field { get; set; }

		///<summary>
		/// The type of resource associated with this error.
		///</summary>
		[JsonProperty("resource")]
		public string Resource { get; set; }

	}
}