using System.Text.Json.Serialization;

namespace FullscreenBrowserOverlay.Entities
{
    public class StoreItem
    {
        [JsonPropertyName("id")]
        public Guid Id { get; set; } = Guid.NewGuid();

        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;

        [JsonPropertyName("url")]
        public string Url { get; set; } = string.Empty;

        [JsonPropertyName("css")]
        public string Css { get; set; } = string.Empty;
    }
}