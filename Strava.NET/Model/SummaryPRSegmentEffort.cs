using Newtonsoft.Json;

namespace StravaSharp
{
	///<summary>
	/// 
	///</summary>
	public class SummaryPRSegmentEffort
	{
		///<summary>
		/// The unique identifier of the activity related to the PR effort.
		///</summary>
		[JsonProperty("pr_activity_id")]
		public long PrActivityId { get; set; }

		///<summary>
		/// The elapsed time ot the PR effort.
		///</summary>
		[JsonProperty("pr_elapsed_time")]
		public int PrElapsedTime { get; set; }

		///<summary>
		/// Number of efforts by the authenticated athlete on this segment.
		///</summary>
		[JsonProperty("effort_count")]
		public int EffortCount { get; set; }

	}
}