using Newtonsoft.Json;

namespace Insomnia.NET.Models
{
    public abstract class BaseResource
    {
        [JsonProperty("_type")]
        public string Type { get; set; }

        [JsonProperty("_id")]
        public string Id { get; set; }

        public string ParentId { get; set; }

        public string Name { get; set; }
    }
}
