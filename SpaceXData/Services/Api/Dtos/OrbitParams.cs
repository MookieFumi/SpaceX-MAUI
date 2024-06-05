using System;
using System.Text.Json.Serialization;

namespace SpaceXData.Services.Dtos
{
    public class OrbitParams
    {
        [JsonPropertyName("reference_system")]
        public string ReferenceSystem { get; set; }

        [JsonPropertyName("regime")]
        public string Regime { get; set; }

        [JsonPropertyName("longitude")]
        public double? Longitude { get; set; }

        [JsonPropertyName("semi_major_axis_km")]
        public double? SemiMajorAxisKm { get; set; }

        [JsonPropertyName("eccentricity")]
        public double? Eccentricity { get; set; }

        [JsonPropertyName("periapsis_km")]
        public double? PeriapsisKm { get; set; }

        [JsonPropertyName("apoapsis_km")]
        public double? ApoapsisKm { get; set; }

        [JsonPropertyName("inclination_deg")]
        public double? InclinationDeg { get; set; }

        [JsonPropertyName("period_min")]
        public double? PeriodMin { get; set; }

        [JsonPropertyName("lifespan_years")]
        public double? LifespanYears { get; set; }

        [JsonPropertyName("epoch")]
        public DateTime? Epoch { get; set; }

        [JsonPropertyName("mean_motion")]
        public double? MeanMotion { get; set; }

        [JsonPropertyName("raan")]
        public double? Raan { get; set; }

        [JsonPropertyName("arg_of_pericenter")]
        public double? ArgOfPericenter { get; set; }

        [JsonPropertyName("mean_anomaly")]
        public double? MeanAnomaly { get; set; }
    }


}

