using Newtonsoft.Json;

namespace StravaSharp
{
	///<summary>
	/// 
	///</summary>
	public class ExplorerSegment
	{
		///<summary>
		/// The unique identifier of this segment
		///</summary>
		[JsonProperty("id")]
		public long Id { get; set; }

		///<summary>
		/// The name of this segment
		///</summary>
		[JsonProperty("name")]
		public string Name { get; set; }

		///<summary>
		/// The category of the climb [0, 5]. Higher is harder ie. 5 is Hors catégorie, 0 is uncategorized in climb_category. If climb_category &#x3D; 5, climb_category_desc &#x3D; HC. If climb_category &#x3D; 2, climb_category_desc &#x3D; 3.
		///</summary>
		[JsonProperty("climb_category")]
		public int ClimbCategory { get; set; }

		///<summary>
		/// The description for the category of the climb May take one of the following values: <code>NC</code>, <code>4</code>, <code>3</code>, <code>2</code>, <code>1</code>, <code>HC</code>
		///</summary>
		[JsonProperty("climb_category_desc")]
		public string ClimbCategoryDesc { get; set; }

		///<summary>
		/// The segment&#39;s average grade, in percents
		///</summary>
		[JsonProperty("avg_grade")]
		public float AvgGrade { get; set; }

		///<summary>
		/// An instance of <a href="#api-models-LatLng">LatLng</a>.
		///</summary>
		[JsonProperty("start_latlng")]
		public LatLng StartLatlng { get; set; }

		///<summary>
		/// An instance of <a href="#api-models-LatLng">LatLng</a>.
		///</summary>
		[JsonProperty("end_latlng")]
		public LatLng EndLatlng { get; set; }

		///<summary>
		/// The segments&#39;s evelation difference, in meters
		///</summary>
		[JsonProperty("elev_difference")]
		public float ElevDifference { get; set; }

		///<summary>
		/// The polyline of the segment
		///</summary>
		[JsonProperty("points")]
		public string Points { get; set; }

	}
}