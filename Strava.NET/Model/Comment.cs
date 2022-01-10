using Newtonsoft.Json;

namespace StravaSharp
{
	///<summary>
	/// 
	///</summary>
	public class Comment
	{
		///<summary>
		/// The unique identifier of this comment
		///</summary>
		[JsonProperty("id")]
		public long Id { get; set; }

		///<summary>
		/// The identifier of the activity this comment is related to
		///</summary>
		[JsonProperty("activity_id")]
		public long ActivityId { get; set; }

		///<summary>
		/// The content of the comment
		///</summary>
		[JsonProperty("text")]
		public string Text { get; set; }

		///<summary>
		/// The time at which this comment was created.
		///</summary>
		[JsonProperty("created_at")]
		public DateTime CreatedAt { get; set; }

	}
}