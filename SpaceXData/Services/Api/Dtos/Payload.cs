using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SpaceXData.Services.Dtos
{
    public class Payload
    {
        [JsonPropertyName("payload_id")]
        public string PayloadId { get; set; }

        [JsonPropertyName("norad_id")]
        public List<int> NoradId { get; set; }

        [JsonPropertyName("reused")]
        public bool Reused { get; set; }

        [JsonPropertyName("customers")]
        public List<string> Customers { get; set; }

        [JsonPropertyName("nationality")]
        public string Nationality { get; set; }

        [JsonPropertyName("manufacturer")]
        public string Manufacturer { get; set; }

        [JsonPropertyName("payload_type")]
        public string PayloadType { get; set; }

        [JsonPropertyName("payload_mass_kg")]
        public double? PayloadMassKg { get; set; }

        [JsonPropertyName("payload_mass_lbs")]
        public double? PayloadMassLbs { get; set; }

        [JsonPropertyName("orbit")]
        public string Orbit { get; set; }

        [JsonPropertyName("orbit_params")]
        public OrbitParams OrbitParams { get; set; }

        [JsonPropertyName("cap_serial")]
        public string CapSerial { get; set; }

        [JsonPropertyName("mass_returned_kg")]
        public double? MassReturnedKg { get; set; }

        [JsonPropertyName("mass_returned_lbs")]
        public double? MassReturnedLbs { get; set; }

        [JsonPropertyName("flight_time_sec")]
        public int? FlightTimeSec { get; set; }

        [JsonPropertyName("cargo_manifest")]
        public string CargoManifest { get; set; }

        [JsonPropertyName("uid")]
        public string Uid { get; set; }
    }


}

