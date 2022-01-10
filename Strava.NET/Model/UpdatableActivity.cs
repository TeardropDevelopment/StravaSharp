using Newtonsoft.Json;

namespace StravaSharp
{
	///<summary>
	/// 
	///</summary>
	public class UpdatableActivity
	{
		///<summary>
		/// Whether this activity is a commute
		///</summary>
		[JsonProperty("commute")]
		public bool Commute { get; set; }

		///<summary>
		/// Whether this activity was recorded on a training machine
		///</summary>
		[JsonProperty("trainer")]
		public bool Trainer { get; set; }

		///<summary>
		/// Whether this activity is muted
		///</summary>
		[JsonProperty("hide_from_home")]
		public bool HideFromHome { get; set; }

		///<summary>
		/// The description of the activity
		///</summary>
		[JsonProperty("description")]
		public string Description { get; set; }

		///<summary>
		/// The name of the activity
		///</summary>
		[JsonProperty("name")]
		public string Name { get; set; }

		///<summary>
		/// Identifier for the gear associated with the activity. ‘none’ clears gear from activity
		///</summary>
		[JsonProperty("gear_id")]
		public string GearId { get; set; }

	}
}