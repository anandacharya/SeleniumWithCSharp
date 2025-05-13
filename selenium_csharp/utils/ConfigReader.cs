using System.Text.Json;
namespace selenium_csharp.utils;

public static class ConfigReader
    {
        public static string GetSetting(string key)
        {
            var json = File.ReadAllText("config/appsettings.json");
            using var doc = JsonDocument.Parse(json);
            var root = doc.RootElement.GetProperty("AppSettings");
            return root.GetProperty(key).GetString();
        }
    }