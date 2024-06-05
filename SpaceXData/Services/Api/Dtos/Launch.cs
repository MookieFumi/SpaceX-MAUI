using System.Text.Json.Serialization;

namespace SpaceXData.Services.Dtos
{
    public class Launch
    {
        [JsonPropertyName("flight_number")]
        public int FlightNumber { get; set; }

        [JsonPropertyName("mission_name")]
        public string MissionName { get; set; }

        [JsonPropertyName("mission_id")]
        public List<string> MissionId { get; set; }

        [JsonPropertyName("upcoming")]
        public bool Upcoming { get; set; }

        [JsonPropertyName("launch_year")]
        public string LaunchYear { get; set; }

        [JsonPropertyName("launch_date_unix")]
        public int LaunchDateUnix { get; set; }

        [JsonPropertyName("launch_date_utc")]
        public DateTime LaunchDateUtc { get; set; }

        [JsonPropertyName("launch_date_local")]
        public DateTime LaunchDateLocal { get; set; }

        [JsonPropertyName("is_tentative")]
        public bool IsTentative { get; set; }

        [JsonPropertyName("tentative_max_precision")]
        public string TentativeMaxPrecision { get; set; }

        [JsonPropertyName("tbd")]
        public bool Tbd { get; set; }

        [JsonPropertyName("launch_window")]
        public int? LaunchWindow { get; set; }

        [JsonPropertyName("rocket")]
        public Rocket Rocket { get; set; }

        [JsonPropertyName("ships")]
        public List<string> Ships { get; set; }

        [JsonPropertyName("telemetry")]
        public Telemetry Telemetry { get; set; }

        [JsonPropertyName("launch_site")]
        public LaunchSite LaunchSite { get; set; }

        [JsonPropertyName("launch_success")]
        public bool? LaunchSuccess { get; set; }

        [JsonPropertyName("launch_failure_details")]
        public LaunchFailureDetails LaunchFailureDetails { get; set; }

        [JsonPropertyName("links")]
        public Links Links { get; set; }

        [JsonPropertyName("details")]
        public string Details { get; set; }

        [JsonPropertyName("static_fire_date_utc")]
        public DateTime? StaticFireDateUtc { get; set; }

        [JsonPropertyName("static_fire_date_unix")]
        public int? StaticFireDateUnix { get; set; }

        [JsonPropertyName("timeline")]
        public Timeline Timeline { get; set; }

        [JsonPropertyName("crew")]
        public List<object> Crew { get; set; }

        [JsonPropertyName("last_date_update")]
        public DateTime? LastDateUpdate { get; set; }

        [JsonPropertyName("last_ll_launch_date")]
        public DateTime? LastLlLaunchDate { get; set; }

        [JsonPropertyName("last_ll_update")]
        public DateTime? LastLlUpdate { get; set; }

        [JsonPropertyName("last_wiki_launch_date")]
        public DateTime? LastWikiLaunchDate { get; set; }

        [JsonPropertyName("last_wiki_revision")]
        public string LastWikiRevision { get; set; }

        [JsonPropertyName("last_wiki_update")]
        public DateTime? LastWikiUpdate { get; set; }

        [JsonPropertyName("launch_date_source")]
        public string LaunchDateSource { get; set; }
    }
}