using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SpaceXData.Services.Dtos
{
    public class FirstStage
    {
        [JsonPropertyName("cores")]
        public List<Core> Cores { get; set; }
    }


}

