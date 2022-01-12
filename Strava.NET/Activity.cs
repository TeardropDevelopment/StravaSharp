namespace StravaSharp
{
    public class Activity
    {

        /// <summary>
        /// The name of the activity.
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// Type of activity. For example - Run, Ride etc.
        /// </summary>
        public ActivityType? Type { get; set; }

        /// <summary>
        /// ISO 8601 formatted date time. 
        /// </summary>
        public DateTime? StartDateLocal { get; set; }

        /// <summary>
        /// In seconds
        /// </summary>
        public int? ElapsedTime { get; set; }

        /// <summary>
        /// Description of the activity
        /// </summary>
        public string? Description { get; set; }

        /// <summary>
        /// In meters.
        /// </summary>
        public float? Distance { get; set; }

        /// <summary>
        /// Set to <bool>true</bool> to mark as a trainer activity.
        /// </summary>
        public bool? Trainer { get; set; }

        /// <summary>
        /// Set to <bool>true</bool> to mark as commute.
        /// </summary>
        public bool? Commute { get; set; }

        /// <summary>
        /// Set to <bool>true</bool> to mute activity.
        /// </summary>
        public bool? HideFromHome { get; set; }

        // Empty constructor
        public Activity() { }

        /// <summary>
        /// Constructor for a activity
        /// </summary>
        /// <param name="name">The name of the activity.</param>
        /// <param name="type">Type of activity. For example - Run, Ride etc.</param>
        /// <param name="startDateLocal">ISO 8601 formatted date time. </param>
        /// <param name="elapsedTime">In seconds</param>
        /// <param name="description">Description of the activity</param>
        /// <param name="distance">In meters.</param>
        /// <param name="trainer">Set to <bool>true</bool> to mark as commute.</param>
        /// <param name="commute">Set to <bool>true</bool> to mute activity.</param>
        /// <param name="hideFromHome">Set to <bool>true</bool> to mute activity.</param>
        public Activity(string? name, ActivityType? type, DateTime? startDateLocal, int? elapsedTime, string? description, float? distance, bool? trainer, bool? commute, bool? hideFromHome)
        {
            Name = name;
            Type = type;
            StartDateLocal = startDateLocal;
            ElapsedTime = elapsedTime;
            Description = description;
            Distance = distance;
            Trainer = trainer;
            Commute = commute;
            HideFromHome = hideFromHome;
        }
    }
}