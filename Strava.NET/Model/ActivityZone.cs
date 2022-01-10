using Newtonsoft.Json;

namespace StravaSharp
{
	///<summary>
	/// 
	///</summary>
	public class ActivityZone
	{
		///<summary>
		/// An instance of <a href="#api-models-integer">integer</a>.
		///</summary>
		[JsonProperty("score")]
		public int Score { get; set; }

		///<summary>
		/// An instance of <a href="#api-models-#/TimedZoneDistribution">#/TimedZoneDistribution</a>.
		///</summary>
		[JsonProperty("distribution_buckets")]
		public #/TimedZoneDistribution DistributionBuckets { get; set; }

		///<summary>
		/// May take one of the following values: <code>heartrate</code>, <code>power</code>
		///</summary>
		[JsonProperty("type")]
		public string Type { get; set; }

		///<summary>
		/// An instance of <a href="#api-models-boolean">boolean</a>.
		///</summary>
		[JsonProperty("sensor_based")]
		public bool SensorBased { get; set; }

		///<summary>
		/// An instance of <a href="#api-models-integer">integer</a>.
		///</summary>
		[JsonProperty("points")]
		public int Points { get; set; }

		///<summary>
		/// An instance of <a href="#api-models-integer">integer</a>.
		///</summary>
		[JsonProperty("max")]
		public int Max { get; set; }

	}
}