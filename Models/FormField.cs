//namespace DynamicFormGenerator.Models
//{
//    // Class to represent the form structure from the JSON configuration
//    public class FormField
//    {
//        public string Type { get; set; } = string.Empty;
//        public string Label { get; set; } = string.Empty;
//        public bool Required { get; set; }
//        public int? Min { get; set; }
//        public int? Max { get; set; }
//        public List<string>? Values { get; set; }
//    }
//}
using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace DynamicFormGenerator.Models
{
    public class FormField
    {
        [JsonPropertyName("type")]
        public string Type { get; set; } = string.Empty;

        [JsonPropertyName("label")]
        public string Label { get; set; } = string.Empty;

        [JsonPropertyName("required")]
        public bool Required { get; set; }

        [JsonPropertyName("values")]
        public List<string>? Values { get; set; }

        [JsonPropertyName("min")]
        public int? Min { get; set; }

        [JsonPropertyName("max")]
        public int? Max { get; set; }

        public object Value { get; set; }
    }
}