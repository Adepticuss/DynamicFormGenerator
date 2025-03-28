using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace DynamicFormGenerator.Models
{
    public class FormConfig
    {
        // The title of the form, which can be displayed in the UI
        [JsonPropertyName("title")]
        public string Title { get; set; } = "";

        // A list of fields that define the structure and behavior of the form
        [JsonPropertyName("fields")]
        public List<FormField> Fields { get; set; } = new();
    }
}