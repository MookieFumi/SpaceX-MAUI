using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SpaceXData.Services.Dtos
{
    public class SecondStage
    {
        [JsonPropertyName("block")]
        public int? Block { get; set; }

        [JsonPropertyName("payloads")]
        public List<Payload> Payloads { get; set; }
    }
}