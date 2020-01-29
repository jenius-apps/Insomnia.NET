using Newtonsoft.Json;
using System.Collections.Generic;

namespace Insomnia.NET.Models
{
    public class Body
    {
        public string MimeType { get; set; }

        public string Text { get; set; }

        public string FileName { get; set; }

        [JsonProperty("params")]
        public List<BodyParameter> Parameters { get; set; }
    }
}
