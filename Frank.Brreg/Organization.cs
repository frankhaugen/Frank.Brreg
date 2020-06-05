using Newtonsoft.Json;
using System;

namespace Frank.Brreg
{
    public class Organization
    {
        [JsonProperty("organisasjonsnummer")]
        public long OrganizationNumber { get; set; }

        [JsonProperty("navn")]
        public string? Name { get; set; }

        [JsonProperty("organisasjonsform")]
        public OrganizationType? Type { get; set; }

        [JsonProperty("postadresse")]
        public Address? PostalAddress { get; set; }

        [JsonProperty("registreringsdatoEnhetsregisteret")]
        public DateTimeOffset Registered { get; set; }

        [JsonProperty("registrertIMvaregisteret")]
        public bool IsInVatRegistry { get; set; }

        [JsonProperty("naeringskode1")]
        public BusinessArea? BusinessArea { get; set; }

        [JsonProperty("antallAnsatte")]
        public long EmployeeCount { get; set; }

        [JsonProperty("forretningsadresse")]
        public Address? BusinessAddress { get; set; }

        [JsonProperty("stiftelsesdato")]
        public DateTimeOffset Founded { get; set; }

        [JsonProperty("registrertIForetaksregisteret")]
        public bool IsInCompanyRegistry { get; set; }

        [JsonProperty("registrertIStiftelsesregisteret")]
        public bool IsInFoundationsRegistry { get; set; }

        [JsonProperty("registrertIFrivillighetsregisteret")]
        public bool IsInNonProfitRegistry { get; set; }

        [JsonProperty("konkurs")]
        public bool IsBankrupt { get; set; }

        [JsonProperty("underAvvikling")]
        public bool IsInLiquidation { get; set; }

        [JsonProperty("underTvangsavviklingEllerTvangsopplosning")]
        public bool IsInForcedLiquidation { get; set; }

        [JsonProperty("maalform")]
        public string? Language { get; set; }
    }
}
