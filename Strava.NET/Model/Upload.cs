using Newtonsoft.Json;

namespace StravaSharp
{
	///<summary>
	/// 
	///</summary>
	public class Upload
	{
		///<summary>
		/// The unique identifier of the upload
		///</summary>
		[JsonProperty("id")]
		public long Id { get; set; }

		///<summary>
		/// The unique identifier of the upload in string format
		///</summary>
		[JsonProperty("id_str")]
		public string IdStr { get; set; }

		///<summary>
		/// The external identifier of the upload
		///</summary>
		[JsonProperty("external_id")]
		public string ExternalId { get; set; }

		///<summary>
		/// The error associated with this upload
		///</summary>
		[JsonProperty("error")]
		public string Error { get; set; }

		///<summary>
		/// The identifier of the activity this upload resulted into
		///</summary>
		[JsonProperty("activity_id")]
		public long ActivityId { get; set; }

	}
}