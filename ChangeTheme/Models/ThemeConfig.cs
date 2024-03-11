using MaterialDesignColors;
using MaterialDesignThemes.Wpf;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Media;

namespace ChangeTheme.Models
{
    public class ThemeConfig
    {
        private static string Path => System.IO.Path.ChangeExtension(System.Reflection.Assembly.GetExecutingAssembly().Location, ".conf");
        public static ThemeConfig Load()
        {
            return JsonSerializer.Deserialize<ThemeConfig>(System.IO.File.ReadAllText(Path));
        }
        public void Save()
        {
            System.IO.File.WriteAllText(Path, JsonSerializer.Serialize<ThemeConfig>(this));
        }

        [JsonInclude]
        [JsonPropertyName("is_dark_theme")]
        public bool IsDarkTheme { get; set; }
        [JsonInclude]
        [JsonPropertyName("is_color_adjusted")]
        public bool IsColorAdjusted{ get; set; }
        [JsonInclude]
        [JsonPropertyName("desired_contrast_ratio")]
        public float DesiredContrastRatio { get; set; }
        [JsonInclude]
        [JsonPropertyName("contrast_value")]
        public Contrast ContrastValue { get; set; }

        [JsonInclude]
        [JsonPropertyName("color_selection_value")]
        public ColorSelection ColorSelectionValue { get; set; }

        [JsonPropertyName("primay_color")]
        public Color PrimaryColor { get; set; }

        [JsonPropertyName("accent_color")]
        public Color AccentColor { get; set; }
    }
}
