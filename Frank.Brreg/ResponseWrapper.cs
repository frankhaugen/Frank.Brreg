using System.Collections.Generic;

namespace Frank.Brreg
{
    class ResponseWrapper
    {
    }

    public class Self
    {
        public string href { get; set; }

    }

    public class Organisasjonsformer
    {
        public string kode { get; set; }
        public string beskrivelse { get; set; }
        public _links _links { get; set; }

    }
    public class _embedded
    {
        public IList<Organisasjonsformer> organisasjonsformer { get; set; }

    }

    public class Enheter
    {
        public string href { get; set; }

    }
    public class Underenheter
    {
        public string href { get; set; }

    }
    public class _links
    {
        public Self self { get; set; }
        public Enheter enheter { get; set; }
        public Underenheter underenheter { get; set; }

    }
    public class Application
    {
        public _embedded _embedded { get; set; }
        public _links _links { get; set; }

    }
}
