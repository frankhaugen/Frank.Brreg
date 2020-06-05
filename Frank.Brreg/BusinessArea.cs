using Newtonsoft.Json;

namespace Frank.Brreg
{


    public class BusinessArea
    {
        [JsonProperty("beskrivelse")]
        public string? Description { get; set; }

        [JsonProperty("kode")]
        public string? Code { get; set; }
    }
}
