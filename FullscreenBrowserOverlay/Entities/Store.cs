using System.Reflection;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace FullscreenBrowserOverlay.Entities
{
    public class Store
    {
        #region Constructor

        public static Store LoadOrDefault()
        {
            var directoryName = Assembly.GetExecutingAssembly().GetName().Name ?? string.Empty;
            var directoryPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), directoryName);
            var itemsPath = Path.Combine(directoryPath, "settings.json");
            var value = File.Exists(itemsPath) ? JsonSerializer.Deserialize<Store>(File.ReadAllText(itemsPath)) : null;
            return value ?? new Store {ItemsPath = itemsPath};
        }

        #endregion
        
        #region Methods

        public void Save()
        {
            var directoryPath = Path.GetDirectoryName(ItemsPath);
            if (directoryPath != null) Directory.CreateDirectory(directoryPath);
            File.WriteAllText(ItemsPath, JsonSerializer.Serialize(this, new JsonSerializerOptions {WriteIndented = true}));
        }

        #endregion

        #region Properties

        [JsonPropertyName("items")]
        public List<StoreItem> Items { get; set; } = new();

        [JsonPropertyName("itemsPath")]
        public string ItemsPath { get; set; } = string.Empty;

        [JsonPropertyName("selectedItemId")]
        public Guid? SelectedItemId { get; set; }

        #endregion
    }
}