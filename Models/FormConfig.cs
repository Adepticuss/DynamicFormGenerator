//namespace DynamicFormGenerator.Models
//{
//    public class FormConfig
//    {
//        public string Title { get; set; } = string.Empty;
//        public List<FormField> Fields { get; set; } = new();
//    }
//}
using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace DynamicFormGenerator.Models
{
    public class FormConfig
    {
        [JsonPropertyName("title")]
        public string Title { get; set; } = string.Empty;

        [JsonPropertyName("fields")]
        public List<FormField> Fields { get; set; } = new();
    }
}