using Newtonsoft.Json;

namespace StravaSharp
{
	///<summary>
	/// Encapsulates the errors that may be returned from the API.
	///</summary>
	public class Fault
	{
		/// <summary>
		/// The message of the fault.
		/// </summary>
        [JsonProperty("message")]
		public string Message { get; set; }

		///<summary>
		/// The set of specific errors associated with this fault, if any.
		///</summary>
		[JsonProperty("errors")]
		public List<Error> Errors { get; set; }

	}
}