using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Bi401f20.WebSite.Modles
{
    public class Anmeldelse
    {
        public string Beskrivelse { get; set; }

        public string Billede { get; set; }
        [JsonPropertyName("Billede")]

        public string Lokation { get; set; }

        public string Email { get; set; }

        public override string ToString() => JsonSerializer.Serialize<Anmeldelse>(this);
    }
}
