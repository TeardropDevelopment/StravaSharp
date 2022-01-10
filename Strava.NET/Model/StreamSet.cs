using Newtonsoft.Json;

namespace StravaSharp
{
	///<summary>
	/// 
	///</summary>
	public class StreamSet
	{
		///<summary>
		/// An instance of <a href="#api-models-TimeStream">TimeStream</a>.
		///</summary>
		[JsonProperty("time")]
		public TimeStream Time { get; set; }

		///<summary>
		/// An instance of <a href="#api-models-DistanceStream">DistanceStream</a>.
		///</summary>
		[JsonProperty("distance")]
		public DistanceStream Distance { get; set; }

		///<summary>
		/// An instance of <a href="#api-models-LatLngStream">LatLngStream</a>.
		///</summary>
		[JsonProperty("latlng")]
		public LatLngStream Latlng { get; set; }

		///<summary>
		/// An instance of <a href="#api-models-AltitudeStream">AltitudeStream</a>.
		///</summary>
		[JsonProperty("altitude")]
		public AltitudeStream Altitude { get; set; }

		///<summary>
		/// An instance of <a href="#api-models-SmoothVelocityStream">SmoothVelocityStream</a>.
		///</summary>
		[JsonProperty("velocity_smooth")]
		public SmoothVelocityStream VelocitySmooth { get; set; }

		///<summary>
		/// An instance of <a href="#api-models-HeartrateStream">HeartrateStream</a>.
		///</summary>
		[JsonProperty("heartrate")]
		public HeartrateStream Heartrate { get; set; }

		///<summary>
		/// An instance of <a href="#api-models-CadenceStream">CadenceStream</a>.
		///</summary>
		[JsonProperty("cadence")]
		public CadenceStream Cadence { get; set; }

		///<summary>
		/// An instance of <a href="#api-models-PowerStream">PowerStream</a>.
		///</summary>
		[JsonProperty("watts")]
		public PowerStream Watts { get; set; }

		///<summary>
		/// An instance of <a href="#api-models-TemperatureStream">TemperatureStream</a>.
		///</summary>
		[JsonProperty("temp")]
		public TemperatureStream Temp { get; set; }

		///<summary>
		/// An instance of <a href="#api-models-SmoothGradeStream">SmoothGradeStream</a>.
		///</summary>
		[JsonProperty("grade_smooth")]
		public SmoothGradeStream GradeSmooth { get; set; }

	}
}