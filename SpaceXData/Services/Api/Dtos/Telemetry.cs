using System.Text.Json.Serialization;

namespace SpaceXData.Services.Dtos
{
    public class Telemetry
    {
        [JsonPropertyName("flight_club")]
        public string FlightClub { get; set; }
    }


}

