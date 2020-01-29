using Newtonsoft.Json;
using System.Collections.Generic;

namespace Insomnia.NET.Models
{
    public class ExportDoc
    {
        [JsonProperty("_type")]
        public string Type { get; set; }

        [JsonProperty("__export_format")]
        public int ExportFormat { get; set; }

        [JsonProperty("__export_source")]
        public string ExportSource { get; set; }

        public List<dynamic> Resources { get; set; }
    }
}
