using System.Text.Json.Serialization;

namespace SpaceXData.Services.Dtos
{
    public class LaunchFailureDetails
    {
        [JsonPropertyName("time")]
        public int Time { get; set; }

        [JsonPropertyName("altitude")]
        public int? Altitude { get; set; }

        [JsonPropertyName("reason")]
        public string Reason { get; set; }
    }


}

