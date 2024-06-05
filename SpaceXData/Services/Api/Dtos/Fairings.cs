using System.Text.Json.Serialization;

namespace SpaceXData.Services.Dtos
{
    public class Fairings
    {
        [JsonPropertyName("reused")]
        public bool? Reused { get; set; }

        [JsonPropertyName("recovery_attempt")]
        public bool? RecoveryAttempt { get; set; }

        [JsonPropertyName("recovered")]
        public bool? Recovered { get; set; }

        [JsonPropertyName("ship")]
        public string Ship { get; set; }
    }


}

