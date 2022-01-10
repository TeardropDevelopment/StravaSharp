using Newtonsoft.Json;

namespace StravaSharp
{
	///<summary>
	/// 
	///</summary>
	public class SummaryClub
	{
		///<summary>
		/// The club&#39;s unique identifier.
		///</summary>
		[JsonProperty("id")]
		public long Id { get; set; }

		///<summary>
		/// Resource state, indicates level of detail. Possible values: 1 -&gt; &quot;meta&quot;, 2 -&gt; &quot;summary&quot;, 3 -&gt; &quot;detail&quot;
		///</summary>
		[JsonProperty("resource_state")]
		public int ResourceState { get; set; }

		///<summary>
		/// The club&#39;s name.
		///</summary>
		[JsonProperty("name")]
		public string Name { get; set; }

		///<summary>
		/// URL to a 60x60 pixel profile picture.
		///</summary>
		[JsonProperty("profile_medium")]
		public string ProfileMedium { get; set; }

		///<summary>
		/// URL to a ~1185x580 pixel cover photo.
		///</summary>
		[JsonProperty("cover_photo")]
		public string CoverPhoto { get; set; }

		///<summary>
		/// URL to a ~360x176  pixel cover photo.
		///</summary>
		[JsonProperty("cover_photo_small")]
		public string CoverPhotoSmall { get; set; }

		///<summary>
		/// Deprecated. Prefer to use activity_types. May take one of the following values: <code>cycling</code>, <code>running</code>, <code>triathlon</code>, <code>other</code>
		///</summary>
		[JsonProperty("sport_type")]
		public string SportType { get; set; }

		///<summary>
		/// The activity types that count for a club. This takes precedence over sport_type.
		///</summary>
		[JsonProperty("activity_types")]
		public ActivityType ActivityTypes { get; set; }

		///<summary>
		/// The club&#39;s city.
		///</summary>
		[JsonProperty("city")]
		public string City { get; set; }

		///<summary>
		/// The club&#39;s state or geographical region.
		///</summary>
		[JsonProperty("state")]
		public string State { get; set; }

		///<summary>
		/// The club&#39;s country.
		///</summary>
		[JsonProperty("country")]
		public string Country { get; set; }

		///<summary>
		/// Whether the club is private.
		///</summary>
		[JsonProperty("private")]
		public bool Private { get; set; }

		///<summary>
		/// The club&#39;s member count.
		///</summary>
		[JsonProperty("member_count")]
		public int MemberCount { get; set; }

		///<summary>
		/// Whether the club is featured or not.
		///</summary>
		[JsonProperty("featured")]
		public bool Featured { get; set; }

		///<summary>
		/// The club&#39;s vanity URL.
		///</summary>
		[JsonProperty("url")]
		public string Url { get; set; }

	}
}