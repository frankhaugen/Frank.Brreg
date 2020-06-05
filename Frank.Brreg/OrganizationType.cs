using Newtonsoft.Json;

namespace Frank.Brreg
{
    public class OrganizationType
    {
        [JsonProperty("kode")]
        public string? Code { get; set; }

        [JsonProperty("beskrivelse")]
        public string? Description { get; set; }
    }
}
