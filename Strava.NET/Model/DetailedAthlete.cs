using Newtonsoft.Json;

namespace StravaSharp
{
	///<summary>
	/// 
	///</summary>
	public class DetailedAthlete
	{
		///<summary>
		/// The unique identifier of the athlete
		///</summary>
		[JsonProperty("id")]
		public long Id { get; set; }

		///<summary>
		/// Resource state, indicates level of detail. Possible values: 1 -&gt; &quot;meta&quot;, 2 -&gt; &quot;summary&quot;, 3 -&gt; &quot;detail&quot;
		///</summary>
		[JsonProperty("resource_state")]
		public int ResourceState { get; set; }

		///<summary>
		/// The athlete&#39;s first name.
		///</summary>
		[JsonProperty("firstname")]
		public string Firstname { get; set; }

		///<summary>
		/// The athlete&#39;s last name.
		///</summary>
		[JsonProperty("lastname")]
		public string Lastname { get; set; }

		///<summary>
		/// URL to a 62x62 pixel profile picture.
		///</summary>
		[JsonProperty("profile_medium")]
		public string ProfileMedium { get; set; }

		///<summary>
		/// URL to a 124x124 pixel profile picture.
		///</summary>
		[JsonProperty("profile")]
		public string Profile { get; set; }

		///<summary>
		/// The athlete&#39;s city.
		///</summary>
		[JsonProperty("city")]
		public string City { get; set; }

		///<summary>
		/// The athlete&#39;s state or geographical region.
		///</summary>
		[JsonProperty("state")]
		public string State { get; set; }

		///<summary>
		/// The athlete&#39;s country.
		///</summary>
		[JsonProperty("country")]
		public string Country { get; set; }

		///<summary>
		/// The athlete&#39;s sex. May take one of the following values: <code>M</code>, <code>F</code>
		///</summary>
		[JsonProperty("sex")]
		public string Sex { get; set; }

		///<summary>
		/// Deprecated.  Use summit field instead. Whether the athlete has any Summit subscription.
		///</summary>
		[JsonProperty("premium")]
		public bool Premium { get; set; }

		///<summary>
		/// Whether the athlete has any Summit subscription.
		///</summary>
		[JsonProperty("summit")]
		public bool Summit { get; set; }

		///<summary>
		/// The time at which the athlete was created.
		///</summary>
		[JsonProperty("created_at")]
		public DateTime CreatedAt { get; set; }

		///<summary>
		/// The time at which the athlete was last updated.
		///</summary>
		[JsonProperty("updated_at")]
		public DateTime UpdatedAt { get; set; }

		///<summary>
		/// The athlete&#39;s follower count.
		///</summary>
		[JsonProperty("follower_count")]
		public int FollowerCount { get; set; }

		///<summary>
		/// The athlete&#39;s friend count.
		///</summary>
		[JsonProperty("friend_count")]
		public int FriendCount { get; set; }

		///<summary>
		/// The athlete&#39;s preferred unit system. May take one of the following values: <code>feet</code>, <code>meters</code>
		///</summary>
		[JsonProperty("measurement_preference")]
		public string MeasurementPreference { get; set; }

		///<summary>
		/// The athlete&#39;s FTP (Functional Threshold Power).
		///</summary>
		[JsonProperty("ftp")]
		public int Ftp { get; set; }

		///<summary>
		/// The athlete&#39;s weight.
		///</summary>
		[JsonProperty("weight")]
		public float Weight { get; set; }

		///<summary>
		/// The athlete&#39;s clubs.
		///</summary>
		[JsonProperty("clubs")]
		public SummaryClub Clubs { get; set; }

		///<summary>
		/// The athlete&#39;s shoes.
		///</summary>
		[JsonProperty("shoes")]
		public SummaryGear Shoes { get; set; }

	}
}