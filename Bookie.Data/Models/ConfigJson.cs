using System.Text.Json.Serialization;

namespace Bookie.Data.Models
{
    public class ConfigJson
    {
        [JsonPropertyName("connectionstring")]
        public string? ConnectionString { get; set; }
        [JsonPropertyName("token")]
        public string? Token { get; set; }
        [JsonPropertyName("prefix")]
        public string? Prefix { get; set; }

    }
}
